#!/bin/bash

# CSX example - CSS 2.1 spec stylesheet

NAME="css-21-spec"

cd $(dirname ${0})

base="examples/${NAME}"
cwd2="$(basename $(dirname $(pwd)))/$(basename $(pwd))"

if [[ ${base} != ${cwd2} ]]
then
    echo >&2 "${0}: must be run from ${base}"
    exit 2
else
    set -e
    alias csx="../../scripts/csx"
    export PYTHONPATH="../../:${PYTHONPATH}"

    echo "removing existing output files"
    rm -rf split csx compact bare pretty
    mkdir split csx compact bare pretty

    echo "splitting original/default.css into print and all-media stylesheets"
    sed '/^@media print {$/,$d' original/default.css > split/all.css
    sed '1,/^@media print {$/d;$d' original/default.css > split/print.css

    echo "converting CSS stylesheets to CSX "
    for target in all print
    do
        csx -dmo split/${target}.css > csx/${target}.csx
    done

    echo "converting CSX stylesheets to 'compact' CSS"
    for target in all print
    do
        csx --compact csx/${target}.csx > compact/${target}.css
    done

    echo "converting CSX stylesheets to 'bare' CSS"
    for target in all print
    do
        csx --bare csx/${target}.csx > bare/${target}.css
    done

    echo "converting CSX stylesheets to 'pretty' CSS"
    for target in all print
    do
        csx --pretty csx/${target}.csx > pretty/${target}.css
    done
fi

