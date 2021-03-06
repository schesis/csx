#!/bin/bash

# CSX example - CSS 2.1 spec stylesheet

cd $(dirname ${0})

base="csx/examples"
cwd2="$(basename $(dirname $(pwd)))/$(basename $(pwd))"

if [[ ${base} != ${cwd2} ]]
then
    echo >&2 "${0}: must be run from ${base}"
    exit 2
else
    set -e

    for example in *
    do
        if [[ -f ${example}/run.sh ]]
        then
            echo "=== ${example} ==="
            ${example}/run.sh
        fi
    done

    echo "=== finished all examples ==="
fi

