#!/bin/sh
# show.sh startline endline : print a range of dis_all.txt without the il2cpp lazy-init boilerplate
sed -n "$1,$2p" /d/games/TruxtonExRecon/evidence/bosses/Bos02/dis_all.txt | grep -v "call     0x4e0a50$\|call     0x4e0d90$\|cmp      dword ptr \[r.. + 0xe4\], \(0\|r15d\|ebx\|esi\|edi\)\|^$" 
