edit        csx.py
below split script.py

tabedit     doc/lib/declarations.txt
below split doc/lib/declaration.txt
below split doc/lib/error.txt
below split doc/lib/renderable.txt
below split doc/lib/rules.txt
below split doc/lib/rule.txt
below split doc/lib/selectors.txt
below split doc/lib/selector.txt
below split doc/lib/text.txt
below split doc/script/alert.txt
below split doc/script/parser.txt
below split doc/script/source.txt
below split tests.py

tabedit     README.txt
below split FAQ.txt
below split COPYING

tabedit     setup.py
below split clean.py
below split MANIFEST.in

tabedit     .source.vim

tabdo wincmd t
tabdo resize
tabfirst

nmap <silent> <F8> :w<CR>:sp %:p.test<CR>:res<CR>:%!/home/z/etiol/clients/csx.org/bzr/trunk/tests.py<CR>:set syn=c<CR>zRG
imap <buffer> <silent> <F8> <Esc><F8>

