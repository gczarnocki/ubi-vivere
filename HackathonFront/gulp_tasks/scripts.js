const gulp = require('gulp');
const eslint = require('gulp-eslint');
const replace = require('gulp-replace');
const conf = require('../conf/gulp.conf');

const keys = require('../conf/keys.js')

gulp.task('scripts', scripts);

function scripts() {
  return gulp.src(conf.path.src('**/*.js'))
    .pipe(eslint())
    .pipe(eslint.format())
    .pipe(replace('google_api_key', keys.google_api_key))

    .pipe(gulp.dest(conf.path.tmp()));
}
