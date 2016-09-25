using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using HackathonServer.Dtos;
using HackathonServer.Models;

namespace HackathonServer.Controllers
{
    public class Points
    {
        public PointDto Point { get; set; }
        public int Count { get; set; }

        
    }
    public class ProductComparer : IEqualityComparer<Points>
    {

        public bool Equals(Points x, Points y)
        {
            //Check whether the objects are the same object. 
            if (Object.ReferenceEquals(x, y)) return true;

            //Check whether the products' properties are equal. 
            return x != null && y != null && x.Point.Equals(y.Point);
        }

        public int GetHashCode(Points obj)
        {
            //Get hash code for the Name field if it is not null. 
            int hashProductName = obj.Point == null ? 0 : obj.Point.GetHashCode();

            //Get hash code for the Code field. 
            int hashProductCode = obj.Point.GetHashCode();

            //Calculate the hash code for the product. 
            return hashProductName ^ hashProductCode;
        }
    }

    public class MagiaController : ApiController
    {
        private static readonly int GRADATION = 2;//długość połowy boku kwadratu podziału punktów dla najmniejszego radiusa (dla radiusa 100, podział będzie co 50m)
        private static readonly double stX = 52.140000;
        private static readonly double stY = 20.880000;
        private static readonly double xMultiplier = 111197*Math.Cos(52*Math.PI/180);
        private static readonly double yMultiplier = 111197;
        // GET api/Magia
        public PointDto[] Get(int busStopWeight, int busStopRadius, int educationWeight, int educationRadius)
        {
            var buspoints = new List<PointDto>();
            var hash = new Tuple<HashSet<PointDto>, Dictionary<PointDto, int>>(new HashSet<PointDto>(),
                new Dictionary<PointDto, int>());
            var educationspoints = new List<PointDto>();
            var mingrad = Math.Min(educationRadius, busStopRadius)/GRADATION;
            var gradX = mingrad/xMultiplier;
            var gradY = mingrad / yMultiplier;
            var educationRadiusConvertedX = educationRadius/xMultiplier;
            var educationRadiusConvertedY = educationRadius / yMultiplier;
            var busRadiusConvertedX = busStopRadius / xMultiplier;
            var busRadiusConvertedY = busStopRadius / yMultiplier;
            using (var context = new HackathonContext())
            {
                var busStops = context.BusStops.ToList().AsParallel();
                var educations = context.EducationFacilities.ToList().AsParallel();
                foreach (var education in educations)
                {
                    var startx = (((int)((education.Latitude - gradX * GRADATION) / gradX)) + 1) * gradX;
                    var starty = (((int)((education.Longitude - gradY * GRADATION) / gradY)) + 1) * gradY;
                    for (var i = startx; i < education.Latitude + educationRadiusConvertedX; i += gradX)
                    {
                        for (var j = starty; j < education.Longitude + educationRadiusConvertedY; j += gradY)
                        {
                            /*for (int k = 0; k < educationWeight; k++)
                            {
                                if (hash.Item1.Add(new PointDto() {X = i, Y = j}))
                                {
                                    hash.Item2.Add(new PointDto(), 0);
                                }
                                else
                                {
                                    hash.Item2[new PointDto() {X = i, Y = j}]++;
                                }
                            }*/
                            educationspoints.AddRange(Enumerable.Repeat(new PointDto() { X = i, Y = j }, educationWeight));
                        }
                    }
                }
                foreach (var busStop in busStops)
                {
                    var startx = (((int)((busStop.X- gradX* GRADATION)/ gradX))+1)* gradX;
                    var starty = (((int)((busStop.Y - gradY * GRADATION) / gradY)) + 1) * gradY;
                    for (var i = startx; i < busStop.X+ busRadiusConvertedX; i+= gradX)
                    {
                        for (var j = starty; j < busStop.Y + busRadiusConvertedY; j+= gradY)
                        {
                            buspoints.AddRange(Enumerable.Repeat(new PointDto() { X = i, Y = j }, busStopWeight));
                        }
                    }
                }

                

            }
            var edupo = educationspoints.AsParallel().GroupBy(s => s).Select(g => new Points() { Point = g.Key, Count = g.Count() });
            var buspo = buspoints.AsParallel().GroupBy(s => s).Select(g => new Points() { Point = g.Key, Count = g.Count() });
            var points = new List<PointDto>();
            if (busStopWeight != 0 && educationWeight != 0)
            {
                foreach (var edu in edupo)
                {
                    foreach (var bu in buspo.Where(bu => bu.Point.Equals(edu.Point)))
                    {
                        points.AddRange(Enumerable.Repeat(edu.Point, edu.Count + bu.Count));
                    }
                }
            }
            else
            {
                if (busStopWeight == 0)
                {
                    points.AddRange(educationspoints);
                }
                else
                {
                    points.AddRange(buspoints);
                }
            }
            
            return points.ToArray();
        }
    }
}
