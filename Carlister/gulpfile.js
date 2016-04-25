/// <binding AfterBuild='less' ProjectOpened='watch' />
"use strict";

var gulp = require("gulp"),
    less = require("gulp-less"),
    sourceMaps = require("gulp-sourcemaps");

var paths = {
    less: "./Content/**/*.less",
    contentTarget: "./Content/",
};

gulp.task("less", function () {
    return gulp.src(paths.less)
        .pipe(sourceMaps.init())
        .pipe(less({
            strictMath: true
        }))
        .pipe(sourceMaps.write("."))
        .pipe(gulp.dest(paths.contentTarget));
});

gulp.task("watch", function () {
    gulp.watch([paths.less], ["less"]);
});
