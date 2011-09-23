#m {
    * {
        font-size: 12px;
        line-height: 25px;
    }
    p.feed, #etiol {
        height: 2.083em;
    }
    p.feed {
        background: #eee url(../decor/foot.png) no-repeat bottom left;
        width: 360px;
        a {
            background: url(../decor/icon-rss.png) no-repeat left center;
            margin-left: 15px;
            padding-bottom: 1px;
            padding-left: 20px;
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
        background: url(../decor/slogan.png) no-repeat 360px 0;
        dt {
            a, img {
                line-height: 65px;
            }
            a {
                height: 65px;
                width: 350px;
            }
            img {
                font-size: 24px;
                height: 85px;
                margin: -10px;
            }
        }
        dd {
            height: 65px;
            line-height: 12px;
            width: 350px;
        }
    }
    #etiol {
        width: 560px;
        small {
            padding-right: 15px;
        }
    }
    #menu {
        margin-top: 75px;
        ul {
            li {
                a {
                    background:
                        #ddd url(../decor/head.png) no-repeat center top;
                    padding: 0 5px;
                }
                a:focus, a:hover {
                    background:
                        #bbb url(../decor/menu-selected.png) repeat-x top;
                }
                strong {
                    a {
                        background:
                            #eee url(../decor/menu-focus.png) repeat-x top;
                        padding: 0 5px;
                    }
                    a:focus, a:hover {
                        background:
                            #bbb url(../decor/menu-selected.png) repeat-x top;
                    }
                }
            }
            li.here strong {
                padding: 0 5px;
            }
        }
        #sections h2 {
            background: url(../decor/head.png) no-repeat right top;
            padding: 0 15px 0 10px;
        }
        #subsections {
            width: 360px;
            h2 {
                background: url(../decor/head.png) no-repeat left top;
                padding: 0 10px 0 15px;
            }
            ul li strong {
                padding: 0 5px;
            }
        }
    }
    #primary, #secondary {
        padding-bottom: 2.083em;
    }
    #primary.photo {
        dl dd {
            line-height: 18px;
            margin: 60px 35px;
            padding: 13px 15px;
            width: 510px;
            a {
                margin: -4px;
                padding: 3px;
            }
        }
        p.navigation {
            background: #eee url(../decor/foot.png) no-repeat bottom right;
            padding-right: 12px;
            width: 548px;
        }
    }
    #primary.text, #secondary.text {
        height: 320px;
        padding: 15px;
    }
    #primary.text {
        width: 530px;
        form {
            margin-top: 7px;
            table {
                tr.message td textarea {
                    height: 13.5em;
                    line-height: 18px;
                    margin: 2px 0;
                    padding: 3px;
                    width: 522px;
                }
                tr.submit, tr.textbox {
                    td input {
                        padding: 3px;
                    }
                }
                tr.submit td input {
                    margin-top: 3px;
                }
                tr.textbox {
                    th {
                        width: 130px;
                    }
                    td input {
                        margin: 2px 0;
                        width: 392px;
                    }
                }
            }
        }
        h1, p {
            line-height: 18px;
        }
        h1 {
            font-size: 18px;
        }
        p {
            margin-top: 12px;
            a {
                line-height: 12px;
            }
        }
        .winner, #finalist {
            h3 {
                font-size: 18px;
                line-height: 24px;
                margin-bottom: 10px;
                margin-left: 5px;
            }
            img {
                height: 70px;
            }
            ul li {
                margin-left: 5px;
            }
        }
        .winner {
            width: 455px;
            img {
                margin-left: -80px;
            }
            ul li a {
                line-height: 14px;
            }
        }
        #colsa {
            background:
                #a4a4a4 url(../decor/background-primary-emphasis.jpg) -90px -95px;
        }
        #finalist {
            background:
                #a4a4a4 url(../decor/background-primary-emphasis.jpg) -15px -265px;
            margin-top: 10px;
            width: 380px;
            h3 {
                margin-bottom: 13px;
                a#catwalk-star {
                    right: 90px;
                }
                a#no-life {
                    right: 15px;
                }
            }
            ul li {
                line-height: 14px;
            }
        }
        #nikon_ae {
            background:
                #a4a4a4 url(../decor/background-primary-emphasis.jpg) -90px -15px;
        }
        #times_tabasco {
            background:
                #a4a4a4 url(../decor/background-primary-emphasis.jpg) -90px -175px;
        }
    }
    #secondary {
        background:
            #b4b4b4 url(../decor/background-secondary.jpg) repeat-y left top;
        dl.subject {
            margin-top: -2.083em;
            dd {
                margin-top: -4.16em;
                padding-left: 10px;
                a, strong {
                    margin-left: -10px;
                    padding: 0 10px;
                }
            }
        }
        p.thumbnails {
            background:
                #b4b4b4 url(../decor/background-secondary.jpg) repeat-y top left;
            height: 350px;
            width: 360px;
            img {
                font-size: 10px;
                height: 70px;
                line-height: 12px;
                width: 70px;
            }
        }
    }
    #secondary.photo {
        dt img {
            height: 350px;
        }
        dd {
            background: #eee url(../decor/foot.png) no-repeat bottom left;
            padding-left: 15px;
            width: 905px;
        }
    }
    #secondary.text {
        padding-right: 25px;
        h2, p.description {
            line-height: 18px;
        }
        h2 {
            font-size: 18px;
            margin-bottom: 10px;
            margin-top: 12px;
        }
        h2.first {
            margin-top: 0;
        }
        p.newsflash {
            background:
                #a4a4a4 url(../decor/background-secondary-emphasis.jpg) -15px -15px;
            padding: 2px 5px;
            strong {
                line-height: 18px;
            }
        }
        #recent {
            background: url(../decor/background-secondary.jpg) -15px 100%;
            a, a.index-2, a.index-3, a.index-4, a.index-5, a.more {
                img {
                    height: 70px;
                }
            }
            a {
                bottom: 15px;
            }
            a.index-2, a.index-3, a.index-4, a.index-5, a.more {
                img {
                    font-size: 10px;
                    line-height: 12px;
                }
            }
            a.index-2, a.index-3, a.index-4, a.index-5 {
                img {
                    width: 70px;
                }
            }
            a.index-3 {
                left: 75px;
            }
            a.index-4 {
                left: 150px;
            }
            a.index-5 {
                left: 225px;
            }
            a.more {
                background:
                    url(../decor/background-secondary-emphasis.jpg) -315px -265px;
                left: 300px;
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
                margin-bottom: 95px;
                padding-top: 5px;
                width: 320px;
            }
        }
    }
    #secondary.thumbnails p.navigation {
        background: #eee url(../decor/foot.png) no-repeat bottom left;
        padding-left: 12px;
        width: 478px;
    }
    #vc1 {
        width: 920px;
    }
}

#m.about, #m.category {
    #menu #sections {
        width: 920px;
    }
}

#m.awards, #m.contact, #m.error {
    #etiol {
        background: #eee url(../decor/foot.png) no-repeat bottom right;
    }
    #primary.text {
        padding-left: 375px;
    }
}

#m.awards {
    #etiol {
        width: 920px;
    }
    #menu #sections {
        width: 920px;
    }
    #primary {
        .winner, #finalist {
            img {
                font-size: 10px;
                height: 70px;
                line-height: 12px;
                width: 70px;
            }
        }
    }
    #primary.text {
        background:
            #b4b4b4 url(../decor/background-photo-tabasco.jpg) no-repeat left top;
    }
}

#m.bono,
#m.classroom,
#m.event-horizon,
#m.gordon-brown-2-moving-in,
#m.horseplay,
#m.napoli-and-coastguard,
#m.napoli-tanker,
#m.phil-bardsley-and-eddie-hutchinson,
#m.samir-durrani-2-freefall {
    #primary.photo dl dd {
        bottom: auto;
        top: -25px;
    }
}

#m.category {
    #primary.text {
        * {
            line-height: 24px;
        }
        h2 {
            font-size: 18px;
            line-height: 18px;
            margin-bottom: 9px;
        }
        li strong {
            margin: -3px -5px;
            padding: 2px 4px;
        }
        p.a-z, ul {
            margin-bottom: 15px;
        }
        p.a-z {
            margin-top: 0px;
            a {
                font-size: 18px;
                line-height: 18px;
            }
        }
        ul li {
            margin-right: 10px;
        }
    }
    #secondary.thumbnails {
        h1 {
            left: 15px;
            top: 75px;
        }
        p.navigation {
            width: 908px;
        }
    }
}

#m.contact, #m.error {
    #etiol {
        width: 920px;
    }
}

#m.contact #primary.text {
    background:
        #b4b4b4 url(../decor/background-photo-soldier.jpg) no-repeat left top;
}

#m.error #primary.text {
    background:
        #b4b4b4 url(../decor/background-exclaim.jpg) no-repeat left top;
}

#m.tall {
    p.feed, #branding, #menu, #secondary {
        width: 490px;
    }
    p.feed {
        background-image: url(../decor/foot-secondary.png);
    }
    #contact, #primary {
        width: 420px;
    }
    #contact {
        background: #ddd url(../decor/head-primary.png) no-repeat center top;
        height: 2.083em;
        address.email {
            padding-left: 15px;
        }
        address.telephone {
            padding-right: 15px;
        }
    }
    #menu {
        background:
            #ddd url(../decor/head-secondary.png) no-repeat center top;
        #sections {
            left: 360px;
            width: 130px;
            ul li {
                a, strong {
                    width: 110px;
                }
                a {
                    padding-right: 15px;
                }
                strong a {
                    padding-right: 15px;
                }
            }
        }
    }
    #primary {
        background: #b4b4b4 url(../decor/background-primary.jpg) 100% 75px;
        height: 425px;
        margin-top: 2.083em;
    }
    #primary.photo {
        dl {
            height: 425px;
        }
        h1 {
            padding-left: 15px;
        }
        p.navigation {
            background:
                #eee url(../decor/foot-primary.png) no-repeat bottom right;
            width: 408px;
        }
    }
    #secondary {
        dl.subject {
            padding-right: 140px;
        }
        p.thumbnails {
            margin-right: -130px;
            padding-right: 130px;
        }
    }
    #secondary.thumbnails p.navigation {
        background:
            #eee url(../decor/foot-secondary.png) no-repeat bottom left;
    }
}

#m.tall.root #menu #sections ul {
    background:
        #ccc url(../decor/background-secondary.jpg) no-repeat right bottom;
    height: 349px;
}

#m.wide {
    #branding {
        width: 480px;
    }
    #contact {
        background: #999 url(../decor/slogan-extend.png) repeat-x;
        height: 65px;
        width: 440px;
        address {
            line-height: 12px;
            padding-right: 15px;
        }
        address.email {
            bottom: 14px;
            a {
                line-height: 12px;
            }
        }
        address.telephone {
            background:
                url(../decor/slogan-extend-cap.png) no-repeat right top;
            height: 52px;
            padding-top: 13px;
        }
    }
    #menu {
        background: #ddd url(../decor/head.png) no-repeat center top;
        width: 920px;
        #sections {
            width: 560px;
        }
    }
    #primary {
        background: #b4b4b4 url(../decor/background-primary.jpg) right top;
        height: 350px;
        width: 560px;
    }
    #secondary {
        width: 360px;
    }
}
