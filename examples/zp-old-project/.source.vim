set guitablabel=%f

edit        csx/x.csx
below split csx/s.csx
below split csx/m.csx
below split csx/l.csx

tabedit     pretty/x.css
below split pretty/s.css
below split pretty/m.css
below split pretty/l.css

tabedit     compact/x.css
below split compact/s.css
below split compact/m.css
below split compact/l.css

tabedit     bare/x.css
below split bare/s.css
below split bare/m.css
below split bare/l.css

tabedit     original/x/branding.css
below split original/x/global.css
below split original/x/menu.css
below split original/x/primary.css
below split original/x/secondary.css

tabedit     original/s/branding.css
below split original/s/global.css
below split original/s/menu.css
below split original/s/primary.css
below split original/s/secondary.css

tabedit     original/m/branding.css
below split original/m/global.css
below split original/m/menu.css
below split original/m/primary.css
below split original/m/secondary.css

tabedit     original/l/branding.css
below split original/l/global.css
below split original/l/menu.css
below split original/l/primary.css
below split original/l/secondary.css

tabdo windo set syn=css
tabdo wincmd t
tabdo resize
tabfirst
