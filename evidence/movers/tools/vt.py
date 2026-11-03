# Print vtable slots (index, byte offset in Il2CppClass, method) of a type. Read-only.
import sys
sys.path.insert(0, r'D:\games\TruxtonExRecon\evidence\bosses\Bos08\tools')
import il2
for name in sys.argv[1:]:
    td = il2.find_typedef(name)
    print('==', name, td)
    for k, m in il2.vtable(td[0]): print('  %3d 0x%03x %s' % (k, 0x138 + 16 * k, m))
