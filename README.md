# Kanbang

This project is a work in progress.

## Developer guidance

### Typescript setup

* Install [TypeScript 1.5](https://visualstudiogallery.msdn.microsoft.com/107f89a0-a542-4264-b0a9-eb91037cf7af).
* Look into *C:\Program Files (x86)\Microsoft SDKs\TypeScript* and make sure it only has 1 folder - *1.5*. In case there are other folders make sure to remove them all, but *1.5*.

### How to compile TypeScript files
Simply run *$(SolutionDir)/tsc-watch.bat*. This will start TypeScript compiler and will watch your typescript files for changes. When changes are detected the TypeScript files will be auto-recompiled.