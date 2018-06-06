/**
 * System configuration for Angular samples
 * Adjust as necessary for your application needs.
 */
(function (global) {
    System.config({
        paths: {
            // paths serve as alias
            'npm:': 'node_modules/'
        },
        // map tells the System loader where to look for things
        map: {
            // our app is within the app folder
            app: 'app',

            // angular bundles
            '@angular/core': 'npm:@angular/core/bundles/core.umd.js',
            '@angular/common': 'npm:@angular/common/bundles/common.umd.js',
            '@angular/compiler': 'npm:@angular/compiler/bundles/compiler.umd.js',
            '@angular/platform-browser': 'npm:@angular/platform-browser/bundles/platform-browser.umd.js',
            '@angular/platform-browser-dynamic': 'npm:@angular/platform-browser-dynamic/bundles/platform-browser-dynamic.umd.js',
            '@angular/animations': 'npm:@angular/animations/bundles/animations.umd.js',
            '@angular/animations/browser': 'npm:@angular/animations/bundles/animations-browser.umd.js',
            '@angular/platform-browser/animations': 'npm:@angular/platform-browser/bundles/platform-browser-animations.umd.js',
            '@angular/http': 'npm:@angular/http/bundles/http.umd.js',
            '@angular/router': 'npm:@angular/router/bundles/router.umd.js',
            '@angular/forms': 'npm:@angular/forms/bundles/forms.umd.js',

            '@progress': 'npm:@progress',
            '@telerik': 'npm:@telerik',

            // other libraries
            'rxjs': 'npm:rxjs',
            'angular-in-memory-web-api': 'npm:angular-in-memory-web-api/bundles/in-memory-web-api.umd.js',
            'tslib': 'npm:tslib/tslib.js',

            'jszip': 'npm:jszip',
            'pako': 'npm:pako',

            'moment': 'npm:moment/moment.js',
            '@ng-bootstrap/ng-bootstrap': 'npm:@ng-bootstrap/ng-bootstrap/bundles/ng-bootstrap.js'
        },
        // packages tells the System loader how to load when no filename and/or no extension
        packages: {
            app: {
                defaultExtension: 'js'
            },
            rxjs: {
                defaultExtension: 'js'
            },

            "jszip": {
                "main": ".js",
                "defaultExtension": "js"
            },

            "pako": {
                "main": ".js",
                "defaultExtension": "js"
            },

            "@progress/kendo-angular-grid": {
                "main": "./dist/npm/main.js",
                "defaultExtension": "js"
            },
            "@progress/kendo-angular-intl": {
                "main": "./dist/npm/main.js",
                "defaultExtension": "js"
            },
            "@progress/kendo-date-math": {
                "main": "./dist/npm/main.js",
                "defaultExtension": "js"
            },
            "@progress/kendo-angular-resize-sensor": {
                "main": "./dist/npm/main.js",
                "defaultExtension": "js"
            },
            "@progress/kendo-angular-l10n": {
                "main": "./dist/npm/main.js",
                "defaultExtension": "js"
            },
            "@progress/kendo-angular-pdf-export": {
                "main": "./dist/npm/main.js",
                "defaultExtension": "js"
            },
            "@progress/kendo-angular-excel-export": {
                "main": "./dist/npm/main.js",
                "defaultExtension": "js"
            },
            "@progress/kendo-data-query": {
                "main": "./dist/npm/main.js",
                "defaultExtension": "js"
            },
            "@progress/kendo-angular-popup": {
                "main": "./dist/npm/main.js",
                "defaultExtension": "js"
            },
            "@progress/kendo-file-saver": {
                "main": "./dist/npm/main.js",
                "defaultExtension": "js"
            },
            "@progress/kendo-popup-common": {
                "main": "./dist/npm/main.js",
                "defaultExtension": "js"
            },
            "@progress/kendo-drawing": {
                "main": "./dist/npm/main.js",
                "defaultExtension": "js"
            },
            "@progress/kendo-ooxml": {
                "main": "./dist/npm/main.js",
                "defaultExtension": "js"
            },
            "@progress/kendo-angular-dateinputs": {
                "main": "./dist/npm/main.js",
                "defaultExtension": "js"
            },
            "@progress/kendo-angular-inputs": {
                "main": "./dist/npm/main.js",
                "defaultExtension": "js"
            },
            "@progress/kendo-angular-dropdowns": {
                "main": "./dist/npm/main.js",
                "defaultExtension": "js"
            },
            "@telerik/kendo-inputs-common": {
                "main": "./dist/npm/main.js",
                "defaultExtension": "js"
            },
            "@telerik/kendo-intl": {
                "main": "./dist/npm/main.js",
                "defaultExtension": "js"
            },
            "@telerik/kendo-draggable": {
                "main": "./dist/npm/main.js",
                "defaultExtension": "js"
            },
        }
    });
})(this);
