* {
    border: none;
    font-family: Verdana, "Bitstream Vera Sans", sans-serif;
    margin: 0;
    padding: 0;
}

html, body, #vc1 {
    height: 100%;
}

html, body {
    background: #555;
    margin: auto;
}

body.category #secondary.thumbnails h1 {
    color: #555;
    display: block;
    position: absolute;
}

del {
    text-decoration: none;
}

div#secondary.text div#recent h2 {
    border-top: 1px solid #999;
    margin-top: 0;
}

p.feed, p.navigation, #etiol {
    a {
        text-decoration: none;
    }
}

p.feed, #etiol {
    a:focus, a:hover {
        color: #333;
        text-decoration: underline;
    }
    a:active {
        color: #111;
    }
}

p.feed, #secondary {
    float: left;
}

p.feed a {
    color: #777;
    font-weight: normal;
    img {
        display: none;
    }
}

p.navigation {
    a, del {
        img {
            visibility: hidden;
        }
    }
    a:focus, a:hover {
        outline: #ccc 1px solid;
    }
    a:active {
        outline: #aaa 1px solid;
    }
}

table {
    border-collapse: collapse;
}

ul {
    list-style: none;
}

.awards {
    #primary h1 {
        display: none;
    }
    #primary.text {
        a:focus, a:hover {
            img {
                background: #bbb;
                opacity: 0.8;
            }
        }
    }
}

.category #primary.text {
    h2 {
        color: #555;
        font-weight: normal;
    }
    li {
        display: inline;
        strong {
            background: #ddd;
            border: 1px #888 solid;
            color: #333;
            font-weight: normal;
        }
    }
    p.a-z {
        a {
            color: #12a;
            text-decoration: none;
        }
        a:focus, a:hover {
            text-decoration: underline;
        }
    }
}

.tall {
    #contact {
        address.email {
            left: 0;
            a:focus, a:hover {
                text-decoration: underline;
            }
            a:active {
                color: #000;
            }
        }
        address.telephone {
            right: 0;
        }
    }
    #menu #sections {
        margin: 0;
        padding: 0;
        position: absolute;
        h2 {
            border: none;
        }
        ul {
            border-bottom: 1px solid #bbb;
            float: right;
            li {
                a, strong {
                    background: #ddd;
                    border-left: none;
                    border-top: 1px solid #bbb;
                    text-align: right;
                }
                a:focus, a:hover {
                    background: #bbb;
                }
                strong {
                    border: none;
                    a {
                        background: #eee;
                    }
                    a:focus, a:hover {
                        background: #bbb;
                    }
                }
            }
        }
    }
}

.tall.root #menu #sections ul {
    border-bottom: none;
    border-top: 1px solid #bbb;
}

.wide {
    #contact {
        address {
            right: 0;
        }
        address.email {
            a:focus, a:hover {
                color: #ddd;
            }
            a:active {
                color: #fff;
            }
        }
        address.telephone {
            color: #111;
        }
    }
    #menu #sections {
        float: right;
    }
}

#branding {
    dt {
        a {
            color: #fff;
            left: 0;
            letter-spacing: 1px;
            position: absolute;
            text-align: center;
            text-decoration: none;
            top: 0;
            img {
                display: block;
                z-index: 1;
            }
        }
        a:focus, a:hover {
            img {
                background: #666;
            }
        }
    }
    dd {
        color: #919191;
        left: 0;
        overflow: hidden;
        position: absolute;
        top: 0;
        z-index: -1;
    }
}

#contact, #secondary.text {
    overflow: hidden;
}

#contact {
    right: 0;
    top: 0;
    address {
        font-style: normal;
        position: absolute;
    }
    address.email a {
        color: #111;
        text-decoration: none;
    }
}

#etiol, #primary {
    float: right;
}

#etiol {
    a, small {
        color: #777;
    }
    small {
        display: block;
        text-align: right;
    }
}

#menu {
    h2 {
        color: #555;
        font-weight: bolder;
    }
    ul li {
        display: inline;
        a, strong {
            float: left;
        }
        a {
            color: #333;
            text-decoration: none;
        }
        a:focus, a:hover {
            color: #111;
        }
        strong {
            font-weight: normal;
        }
    }
    #sections {
        h2, ul {
            float: right;
        }
        h2 {
            border-left: 1px solid #bbb;
        }
        ul li {
            a, strong {
                border-left: 1px solid #bbb;
            }
            strong a {
                border: none;
            }
        }
    }
    #subsections {
        h2, ul {
            float: left;
        }
        h2 {
            border-right: 1px solid #bbb;
            a {
                color: #555;
                text-decoration: none;
            }
            a:focus, a:hover {
                color: #333;
                text-decoration: underline;
            }
            a:active {
                color: #111;
            }
        }
        ul li {
            a, strong {
                border-right: 1px solid #bbb;
            }
        }
    }
}

#primary, #secondary.text, #vc2, #vc3 {
    position: relative;
}

#primary.photo {
    dl {
        dt {
            text-align: center;
            a, img {
                display: block;
            }
        }
        dd {
            background: #eee;
            bottom: 0;
            color: #000;
            opacity: 0.9;
            position: absolute;
            text-align: justify;
            visibility: hidden;
            a {
                border: 1px #eee solid;
                color: #555;
                font-weight: bolder;
                text-decoration: underline;
            }
            a:focus, a:hover {
                background: #fff;
                border: 1px #ccc solid;
                color: #333;
            }
            a:active {
                border: 1px #aaa solid;
                color: #111;
                opacity: 1.0;
            }
        }
    }
    dl:hover dd {
        visibility: visible;
    }
    h1 {
        bottom: 0;
        color: #555;
        position: absolute;
        small {
            a {
                color: #777;
                font-weight: normal;
                text-decoration: none;
            }
            a:focus, a:hover {
                color: #333;
                text-decoration: underline;
            }
            a:active {
                color: #111;
            }
            strong {
                font-weight: bolder;
            }
        }
    }
    p.navigation {
        display: block;
        float: right;
        text-align: right;
    }
}

#primary.text {
    overflow: auto;
    padding-bottom: 0;
    a {
        color: #12a;
        text-decoration: underline;
    }
    a:visited {
        color: #346;
    }
    a:focus, a:hover {
        color: #24b;
    }
    a:active {
        color: #36e;
    }
    form table {
        tr.message td {
            textarea {
                background: #eee;
                border: 1px #888 solid;
                color: #000;
                opacity: 0.7;
            }
            textarea:focus {
                background: #fff;
                opacity: 0.8;
            }
        }
        tr.submit td {
            input, input:focus, input:hover {
                color: #111;
            }
            input {
                background: #aaa;
                border: 1px #555 solid;
                font-weight: bolder;
            }
            input:focus, input:hover {
                background: #ccc;
            }
            input:active {
                background: #888;
                color: #fff;
            }
        }
        tr.textbox {
            th {
                color: #333;
                font-weight: normal;
                label {
                    font-weight: bold;
                }
            }
            td {
                input {
                    background: #eee;
                    border: 1px #888 solid;
                    color: #000;
                    opacity: 0.7;
                }
                input:focus {
                    background: #fff;
                    opacity: 0.8;
                }
            }
        }
    }
    h1 {
        color: #555;
        font-weight: normal;
    }
    p {
        color: #111;
        text-align: justify;
    }
    .winner, #finalist {
        h3 {
            color: #555;
            font-weight: normal;
        }
        ul li {
            color: #111;
        }
    }
    .winner {
        float: right;
        img {
            float: left;
        }
        ul li {
            a {
                text-decoration: none;
            }
            a:focus, a:hover {
                text-decoration: underline;
            }
        }
    }
    #finalist {
        float: left;
        h3 a {
            position: absolute;
        }
    }
}

#secondary.photo {
    dd {
        a {
            color: #777;
            text-decoration: none;
        }
        a:focus, a:hover {
            color: #333;
            text-decoration: underline;
        }
        a:active {
            color: #111;
        }
    }
    img {
        display: block;
    }
}

#secondary.text {
    h2 {
        color: #555;
        font-weight: normal;
    }
    p.description {
        text-align: justify;
    }
    p.newsflash a {
        line-height: 1em;
    }
    #recent {
        bottom: 0;
        a {
            position: absolute;
            img {
                display: block;
            }
        }
        a.index-2 {
            left: 0;
        }
        a.index-2:focus,
        a.index-2:hover,
        a.index-3:focus,
        a.index-3:hover,
        a.index-4:focus,
        a.index-4:hover,
        a.index-5:focus,
        a.index-5:hover {
            background: #bbb;
            opacity: 0.8;
        }
        a.more:focus, a.more:hover, a.more:active {
            img {
                visibility: hidden;
            }
        }
    }
}

#secondary.thumbnails {
    dl.subject {
        bottom: 0;
        float: right;
        right: 0;
        top: auto;
        dt, dd {
            a {
                text-decoration: none;
            }
            strong {
                font-weight: bolder;
            }
        }
        dt {
            text-align: right;
            a {
                color: #777;
                font-weight: normal;
            }
            a:focus, a:hover {
                color: #333;
                text-decoration: underline;
            }
            a:active {
                color: #111;
            }
            strong {
                color: #999;
            }
        }
        dd {
            background: #eee;
            opacity: 0.8;
            visibility: hidden;
            a, a:focus, a:hover {
                color: #000;
            }
            a, strong {
                display: block;
            }
            a:focus, a:hover {
                background: #fff;
            }
            a:active {
                background: #ddd;
            }
            strong {
                color: #555;
            }
        }
    }
    dl.subject:hover dd {
        visibility: visible;
    }
    h1, h2 {
        display: none;
    }
    p.navigation {
        display: block;
        float: left;
    }
    p.thumbnails {
        a:focus, a:hover {
            img {
                background: #bbb;
                opacity: 0.8;
            }
        }
        img {
            float: left;
            text-align: center;
        }
    }
}

#vc1 {
    display: table;
    overflow: visible;
}

#vc2 {
    display: table-cell;
    vertical-align: middle;
}
