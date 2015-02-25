#! /usr/bin/env python3

from distutils.core import setup

import csx

setup(
    author = "Zero Piraeus",
    author_email = "z@etiol.net",
    description = "Extended Cascading Stylesheets",
    keywords = "css web",
    license = "GPLv3",
    long_description = csx.__doc__,
    name = "csx",
    py_modules = ["csx"],
    scripts = ["csx"],
    url = "https://bitbucket.org/schesis/csx",
    version = csx.__version__,

    classifiers = [
        "Development Status :: 5 - Production/Stable",
        "Environment :: Console",
        "Intended Audience :: Developers",
        "License :: OSI Approved :: GNU General Public License (GPL)",
        "Natural Language :: English",
        "Operating System :: POSIX",
        "Programming Language :: Python :: 3",
        "Topic :: Internet :: WWW/HTTP",
        "Topic :: Text Processing",
        "Topic :: Utilities",
    ]
)

