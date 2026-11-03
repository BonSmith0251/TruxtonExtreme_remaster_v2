# Ene_Bos02 vtable (slot offset in Il2CppClass -> method name), from vtable_bos02_meta.txt (made by vtable_meta.py).
import os
CHAIN=None
def build(chain=None):
    p=os.path.join(os.path.dirname(os.path.abspath(__file__)),'vtable_bos02_meta.txt'); out={}
    for l in open(p):
        if l.startswith('0x'):
            a=l.split(); out[int(a[0],16)]=(a[4].split('::')[-1],)
    return out
