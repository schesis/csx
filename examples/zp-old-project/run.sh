#!/bin/bash

# CSX example - CSS 2.1 spec stylesheet

NAME="zp-old-project"

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
    rm -rf csx compact bare pretty
    mkdir csx compact bare pretty

    echo "converting CSS stylesheets to CSX "
    for target in l m s x
    do
        csx --optimize --minimize original/${target}/*.css > csx/${target}.csx
    done

    echo "converting CSX stylesheets to 'compact' CSS"
    for target in l m s x
    do
        csx --compact csx/${target}.csx > compact/${target}.css
    done

    echo "converting CSX stylesheets to 'bare' CSS"
    for target in l m s x
    do
        csx --bare csx/${target}.csx > bare/${target}.css
    done

    echo "converting CSX stylesheets to 'pretty' CSS"
    for target in l m s x
    do
        csx --pretty csx/${target}.csx > pretty/${target}.css
    done
fi

