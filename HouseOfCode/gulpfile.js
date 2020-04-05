var gulp    = require('gulp');
var sass    = require('gulp-sass');
var prefix  = require('gulp-autoprefixer');
var uglify  = require('gulp-uglify-es').default;
var rename  = require('gulp-rename');
var watch   = require('gulp-watch');
var reload  = require('gulp-livereload');
var include = require('gulp-include')

sass.compiler = require('node-sass');

var style  = 'css/assets/style.scss';
var script = 'scripts/assets/main.js';

// Compile scss to css and minify it.
gulp.task('sass', function () {
  return gulp.src(style)
    .pipe(sass({outputStyle: 'compressed'}).on('error', sass.logError))
    .pipe(prefix({
            browsers: ['last 2 versions'],
            cascade: false
        }))
    .pipe(rename({ suffix: '.min' }))
    .pipe(gulp.dest('css/'))
    .pipe(reload());
});

// Minify javascript
gulp.task('js', function () {
  return gulp.src(script)
    .pipe(include())
    .pipe(uglify())
    .pipe(rename({ suffix: '.min' }))
    .pipe(gulp.dest('scripts/'))
    .pipe(reload());
});

// Auto compile on save
gulp.task('watch', function (){
    reload.listen();

    gulp.watch('css/assets/style.scss', gulp.series('sass'));
    gulp.watch('scripts/assets/main.js', gulp.series('js'));
});

gulp.task('default', gulp.series('watch'));
