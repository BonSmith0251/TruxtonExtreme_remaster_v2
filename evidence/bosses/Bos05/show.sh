show () 
{ 
    awk -v k="$1" 'index($0,"== ")==1 && index($0,k){p=1} p&&/^$/{p=0} p' bos05-and-arm.asm.txt | grep -v 'int3$\|call     0x4e0d00$\|call     0x4e0cf0$\|nop  '
}
