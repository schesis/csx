set guitablabel=%f

edit        csx/all.csx
below split csx/print.csx

tabedit     pretty/all.css
below split pretty/print.css

tabedit     compact/all.css
below split compact/print.css

tabedit     bare/all.css
below split bare/print.css

tabedit     split/all.css
below split split/print.css

tabedit     original/default.css

tabdo windo set syn=css
tabdo wincmd t
tabdo resize
tabfirst
