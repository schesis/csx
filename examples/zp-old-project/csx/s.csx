#s {
    * {
        font-size: 10px;
        line-height: 20px;
    }
    p.feed, #etiol {
        height: 2.0em;
    }
    p.feed {
        background: #eee url(../decor/foot.png) no-repeat bottom left;
        width: 288px;
        a {
            background: url(../decor/icon-rss.png) no-repeat left center;
            margin-left: 12px;
            padding-left: 16px;
        }
        a:focus, a:hover {
            background:
                url(../decor/icon-rss-focus.png) no-repeat left center;
        }
    }
    p.navigation {
        a.next {
            background: url(../decor/icon-next.gif) no-repeat center center;
        }
        a.next:focus, a.next:hover {
            background:
                #fff url(../decor/icon-next-focus.gif) no-repeat center center;
        }
        a.next:active {
            background:
                #ccc url(../decor/icon-next-active.gif) no-repeat center center;
        }
        a.previous {
            background:
                url(../decor/icon-previous.gif) no-repeat center center;
        }
        a.previous:focus, a.previous:hover {
            background:
                #fff url(../decor/icon-previous-focus.gif) no-repeat center center;
        }
        a.previous:active {
            background:
                #ccc url(../decor/icon-previous-active.gif) no-repeat center center;
        }
        del.next {
            background:
                url(../decor/icon-next-disabled.gif) no-repeat center center;
        }
        del.previous {
            background:
                url(../decor/icon-previous-disabled.gif) no-repeat center center;
        }
    }
    #branding {
        background: url(../decor/slogan.png) no-repeat 288px 0;
        dt {
            a, img {
                line-height: 52px;
            }
            a {
                height: 52px;
                width: 280px;
            }
            img {
                font-size: 20px;
                height: 68px;
                margin: -8px;
            }
        }
        dd {
            height: 52px;
            line-height: 10px;
            width: 280px;
        }
    }
    #etiol {
        width: 448px;
        small {
            padding-right: 12px;
        }
    }
    #menu {
        margin-top: 60px;
        ul {
            li {
                a {
                    background:
                        #ddd url(../decor/head.png) no-repeat center top;
                    padding: 0 4px;
                }
                a:focus, a:hover {
                    background:
                        #bbb url(../decor/menu-selected.png) repeat-x top;
                }
                strong {
                    a {
                        background:
                            #eee url(../decor/menu-focus.png) repeat-x top;
                        padding: 0 4px;
                    }
                    a:focus, a:hover {
                        background:
                            #bbb url(../decor/menu-selected.png) repeat-x top;
                    }
                }
            }
            li.here strong {
                padding: 0 4px;
            }
        }
        #sections h2 {
            background: url(../decor/head.png) no-repeat right top;
            padding: 0 12px 0 8px;
        }
        #subsections {
            width: 288px;
            h2 {
                background: url(../decor/head.png) no-repeat left top;
                padding: 0 8px 0 12px;
            }
            ul li strong {
                padding: 0 4px;
            }
        }
    }
    #primary, #secondary {
        padding-bottom: 2.0em;
    }
    #primary.photo {
        dl dd {
            line-height: 14px;
            margin: 48px 28px;
            padding: 10px 12px;
            width: 408px;
            a {
                margin: -4px;
                padding: 2px;
            }
        }
        p.navigation {
            background: #eee url(../decor/foot.png) no-repeat bottom right;
            padding-right: 10px;
            width: 438px;
        }
    }
    #primary.text, #secondary.text {
        height: 256px;
        padding: 12px;
    }
    #primary.text {
        width: 424px;
        form {
            margin-top: 6px;
            table {
                tr.message td textarea {
                    height: 12.5em;
                    line-height: 14px;
                    margin: 2px 0;
                    padding: 2px;
                    width: 418px;
                }
                tr.submit, tr.textbox {
                    td input {
                        padding: 2px;
                    }
                }
                tr.submit td input {
                    margin-top: 2px;
                }
                tr.textbox {
                    th {
                        width: 104px;
                    }
                    td input {
                        margin: 2px 0;
                        width: 314px;
                    }
                }
            }
        }
        h1, p {
            line-height: 14px;
        }
        h1 {
            font-size: 14px;
        }
        p {
            margin-top: 10px;
            a {
                line-height: 10px;
            }
        }
        .winner, #finalist {
            h3 {
                font-size: 14px;
                line-height: 19px;
                margin-bottom: 8px;
                margin-left: 4px;
            }
            img {
                height: 56px;
            }
            ul li {
                margin-left: 4px;
            }
        }
        .winner {
            width: 364px;
            img {
                margin-left: -64px;
            }
            ul li a {
                line-height: 11px;
            }
        }
        #colsa {
            background:
                #a4a4a4 url(../decor/background-primary-emphasis.jpg) -72px -76px;
        }
        #finalist {
            background:
                #a4a4a4 url(../decor/background-primary-emphasis.jpg) -12px -212px;
            margin-top: 8px;
            width: 304px;
            h3 {
                margin-bottom: 10px;
                a#catwalk-star {
                    right: 72px;
                }
                a#no-life {
                    right: 12px;
                }
            }
            ul li {
                line-height: 11px;
            }
        }
        #nikon_ae {
            background:
                #a4a4a4 url(../decor/background-primary-emphasis.jpg) -72px -12px;
        }
        #times_tabasco {
            background:
                #a4a4a4 url(../decor/background-primary-emphasis.jpg) -72px -140px;
        }
    }
    #secondary {
        background:
            #b4b4b4 url(../decor/background-secondary.jpg) repeat-y left top;
        dl.subject {
            margin-top: -2.0em;
            dd {
                margin-top: -4.0em;
                padding-left: 8px;
                a, strong {
                    margin-left: -8px;
                    padding: 0 8px;
                }
            }
        }
        p.thumbnails {
            background:
                #b4b4b4 url(../decor/background-secondary.jpg) repeat-y top left;
            height: 280px;
            width: 288px;
            img {
                font-size: 8px;
                height: 56px;
                line-height: 10px;
                width: 56px;
            }
        }
    }
    #secondary.photo {
        dt img {
            height: 280px;
        }
        dd {
            background: #eee url(../decor/foot.png) no-repeat bottom left;
            padding-left: 12px;
            width: 724px;
        }
    }
    #secondary.text {
        padding-right: 20px;
        h2, p.description {
            line-height: 14px;
        }
        h2 {
            font-size: 14px;
            margin-bottom: 8px;
            margin-top: 10px;
        }
        h2.first {
            margin-top: 0;
        }
        p.newsflash {
            background:
                #a4a4a4 url(../decor/background-secondary-emphasis.jpg) -12px -12px;
            padding: 2px 4px;
            strong {
                line-height: 14px;
            }
        }
        #recent {
            background: url(../decor/background-secondary.jpg) -12px 100%;
            a, a.index-2, a.index-3, a.index-4, a.index-5, a.more {
                img {
                    height: 56px;
                }
            }
            a {
                bottom: 12px;
            }
            a.index-2, a.index-3, a.index-4, a.index-5, a.more {
                img {
                    font-size: 8px;
                    line-height: 10px;
                }
            }
            a.index-2, a.index-3, a.index-4, a.index-5 {
                img {
                    width: 56px;
                }
            }
            a.index-3 {
                left: 60px;
            }
            a.index-4 {
                left: 120px;
            }
            a.index-5 {
                left: 180px;
            }
            a.more {
                background:
                    url(../decor/background-secondary-emphasis.jpg) -252px -212px;
                left: 240px;
            }
            a.more:focus, a.more:hover {
                background:
                    url(../decor/icon-more-focus.png) no-repeat top left;
            }
            a.more:active {
                background:
                    url(../decor/icon-more-active.png) no-repeat top left;
            }
            h2 {
                margin-bottom: 76px;
                padding-top: 4px;
                width: 256px;
            }
        }
    }
    #secondary.thumbnails p.navigation {
        background: #eee url(../decor/foot.png) no-repeat bottom left;
        padding-left: 10px;
        width: 382px;
    }
    #vc1 {
        width: 736px;
    }
}

#s.about, #s.category {
    #menu #sections {
        width: 736px;
    }
}

#s.awards, #s.contact, #s.error {
    #etiol {
        background: #eee url(../decor/foot.png) no-repeat bottom right;
    }
    #primary.text {
        padding-left: 300px;
    }
}

#s.awards {
    #etiol {
        width: 736px;
    }
    #menu #sections {
        width: 736px;
    }
    #primary {
        .winner, #finalist {
            img {
                font-size: 8px;
                height: 56px;
                line-height: 10px;
                width: 56px;
            }
        }
    }
    #primary.text {
        background:
            url(../decor/background-photo-tabasco.jpg) no-repeat left top;
    }
}

#s.bono,
#s.classroom,
#s.event-horizon,
#s.gordon-brown-2-moving-in,
#s.horseplay,
#s.napoli-and-coastguard,
#s.napoli-tanker,
#s.phil-bardsley-and-eddie-hutchinson,
#s.samir-durrani-2-freefall {
    #primary.photo dl dd {
        bottom: auto;
        top: -20px;
    }
}

#s.category {
    #primary.text {
        * {
            line-height: 19px;
        }
        h2 {
            font-size: 14px;
            line-height: 14px;
            margin-bottom: 7px;
        }
        li strong {
            margin: -2px -4px;
            padding: 2px 3px;
        }
        p.a-z, ul {
            margin-bottom: 12px;
        }
        p.a-z {
            margin-top: 0px;
            a {
                font-size: 14px;
                line-height: 14px;
            }
        }
        ul li {
            margin-right: 8px;
        }
    }
    #secondary.thumbnails {
        h1 {
            left: 12px;
            top: 60px;
        }
        p.navigation {
            width: 726px;
        }
    }
}

#s.contact, #s.error {
    #etiol {
        width: 736px;
    }
}

#s.contact #primary.text {
    background:
        #b4b4b4 url(../decor/background-photo-soldier.jpg) no-repeat left top;
}

#s.error #primary.text {
    background:
        #b4b4b4 url(../decor/background-exclaim.jpg) no-repeat left top;
}

#s.tall {
    p.feed, #branding, #menu, #secondary {
        width: 392px;
    }
    p.feed {
        background-image: url(../decor/foot-secondary.png);
    }
    #contact, #primary {
        width: 336px;
    }
    #contact {
        background: #ddd url(../decor/head-primary.png) no-repeat center top;
        height: 2.0em;
        address.email {
            padding-left: 12px;
        }
        address.telephone {
            padding-right: 12px;
        }
    }
    #menu {
        background:
            #ddd url(../decor/head-secondary.png) no-repeat center top;
        #sections {
            left: 288px;
            width: 104px;
            ul li {
                a, strong {
                    width: 88px;
                }
                a {
                    padding-right: 12px;
                }
                strong a {
                    padding-right: 12px;
                }
            }
        }
    }
    #primary {
        background: #b4b4b4 url(../decor/background-primary.jpg) 100% 60px;
        height: 340px;
        margin-top: 2.0em;
    }
    #primary.photo {
        dl {
            height: 340px;
        }
        h1 {
            padding-left: 12px;
        }
        p.navigation {
            background:
                #eee url(../decor/foot-primary.png) no-repeat bottom right;
            width: 326px;
        }
    }
    #secondary {
        dl.subject {
            padding-right: 112px;
        }
        p.thumbnails {
            margin-right: -104px;
            padding-right: 104px;
        }
    }
    #secondary.thumbnails p.navigation {
        background:
            #eee url(../decor/foot-secondary.png) no-repeat bottom left;
    }
}

#s.tall.root #menu #sections ul {
    background:
        #ccc url(../decor/background-secondary.jpg) no-repeat right bottom;
    height: 279px;
}

#s.wide {
    #branding {
        width: 384px;
    }
    #contact {
        background: #999 url(../decor/slogan-extend.png) repeat-x;
        height: 52px;
        width: 352px;
        address {
            line-height: 10px;
            padding-right: 12px;
        }
        address.email {
            bottom: 11px;
            a {
                line-height: 10px;
            }
        }
        address.telephone {
            background:
                url(../decor/slogan-extend-cap.png) no-repeat right top;
            height: 42px;
            padding-top: 10px;
        }
    }
    #menu {
        background: #ddd url(../decor/head.png) no-repeat center top;
        width: 736px;
        #sections {
            width: 448px;
        }
    }
    #primary {
        background: #b4b4b4 url(../decor/background-primary.jpg) right top;
        height: 280px;
        width: 448px;
    }
    #secondary {
        width: 288px;
    }
}
