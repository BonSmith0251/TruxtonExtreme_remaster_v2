### Void Enemy.Ene_Bos07::Initialize()  RVA=0x1DA1850 len=0x4A0
01da1850  mov      qword ptr [rsp + 8], rcx
01da1855  push     rbx
01da1856  push     rsi
01da1857  push     rdi
01da1858  push     r12
01da185a  push     r13
01da185c  push     r14
01da185e  push     r15
01da1860  sub      rsp, 0x60
01da1864  mov      rsi, rcx
01da1867  cmp      byte ptr [rip + 0x28c1f9b], 0 ; [4663809] bss
01da186e  jne      0x1da18bf
01da1870  lea      rcx, [rip + 0x2615619] ; [43b6e90] Type#53940
01da1877  call     0x4e0a50 ; il2cpp_init_metadata
01da187c  lea      rcx, [rip + 0x25e9095] ; [438a918] TypeInfo#53940
01da1883  call     0x4e0a50 ; il2cpp_init_metadata
01da1888  lea      rcx, [rip + 0x262b101] ; [43cc990] TypeInfo#39371
01da188f  call     0x4e0a50 ; il2cpp_init_metadata
01da1894  lea      rcx, [rip + 0x262c0c5] ; [43cd960] TypeInfo#39412
01da189b  call     0x4e0a50 ; il2cpp_init_metadata
01da18a0  lea      rcx, [rip + 0x25cf069] ; [4370910] TypeInfo#72329
01da18a7  call     0x4e0a50 ; il2cpp_init_metadata
01da18ac  lea      rcx, [rip + 0x25d35f5] ; [4374ea8] TypeInfo#32139
01da18b3  call     0x4e0a50 ; il2cpp_init_metadata
01da18b8  mov      byte ptr [rip + 0x28c1f4a], 1 ; [4663809] bss
01da18bf  xor      r15d, r15d
01da18c2  mov      qword ptr [rsp + 0xb0], r15
01da18ca  mov      qword ptr [rsp + 0xb8], r15
01da18d2  xor      edx, edx
01da18d4  mov      rcx, rsi
01da18d7  call     0x1d0dfc0 ; Void Enemy.PawnEnemy::Initialize()
01da18dc  mov      rax, qword ptr [rsi + 0xb8]
01da18e3  test     rax, rax
01da18e6  je       0x1da1c86
01da18ec  mov      byte ptr [rax + 0x292], 1
01da18f3  mov      edx, dword ptr [rsi + 0x278]
01da18f9  mov      rcx, qword ptr [rip + 0x25d35a8] ; [4374ea8] TypeInfo#32139
01da1900  call     0x4dfe00 ; ?
01da1905  mov      qword ptr [rsi + 0x280], rax
01da190c  lea      rcx, [rsi + 0x280]
01da1913  mov      rdx, rax
01da1916  call     0x4dfd80 ; ?
01da191b  mov      rbx, qword ptr [rip + 0x261556e] ; [43b6e90] Type#53940
01da1922  mov      rcx, qword ptr [rip + 0x28d6627] ; [4677f50] bss
01da1929  cmp      dword ptr [rcx + 0xe4], r15d
01da1930  jne      0x1da1937
01da1932  call     0x4e0d90 ; il2cpp_class_init
01da1937  xor      edx, edx
01da1939  mov      rcx, rbx
01da193c  call     0x2051bf0 ; Type Type::GetTypeFromHandle(RuntimeTypeHandle)
01da1941  mov      rbx, rax
01da1944  mov      rcx, qword ptr [rip + 0x28d65bd] ; [4677f08] bss
01da194b  cmp      dword ptr [rcx + 0xe4], r15d
01da1952  jne      0x1da1959
01da1954  call     0x4e0d90 ; il2cpp_class_init
01da1959  xor      edx, edx
01da195b  mov      rcx, rbx
01da195e  call     0x2064b50 ; Array Enum::GetValues(Type)
01da1963  test     rax, rax
01da1966  je       0x1da1c86
01da196c  xor      edx, edx
01da196e  mov      rcx, rax
01da1971  call     0x203ede0 ; Collections.IEnumerator Array::GetEnumerator()
01da1976  mov      qword ptr [rsp + 0xb0], rax
01da197e  mov      qword ptr [rsp + 0x28], r15
01da1983  lea      r13, [rsp + 0xb0]
01da198b  mov      qword ptr [rsp + 0x30], r13
01da1990  lea      r12, [rsp + 0xb8]
01da1998  mov      qword ptr [rsp + 0x38], r12
01da199d  nop      dword ptr [rax]
01da19a0  mov      r8, qword ptr [rsp + 0xb0]
01da19a8  test     r8, r8
01da19ab  je       0x1da1cdb
01da19b1  xor      ecx, ecx
01da19b3  mov      rdx, qword ptr [rip + 0x262bfa6] ; [43cd960] TypeInfo#39412
01da19ba  call     0x22b0 ; ?
01da19bf  test     al, al
01da19c1  je       0x1da1b77
01da19c7  mov      rbx, qword ptr [rsp + 0xb0]
01da19cf  test     rbx, rbx
01da19d2  je       0x1da1cd6
01da19d8  mov      r9, qword ptr [rip + 0x262bf81] ; [43cd960] TypeInfo#39412
01da19df  mov      r10, qword ptr [rbx]
01da19e2  movzx    eax, r15w
01da19e6  movzx    edx, word ptr [r10 + 0x12e]
01da19ee  cmp      r15w, dx
01da19f2  jae      0x1da1a18
01da19f4  mov      r8, qword ptr [r10 + 0xb0]
01da19fb  nop      dword ptr [rax + rax]
01da1a00  movzx    ecx, ax
01da1a03  add      rcx, rcx
01da1a06  cmp      qword ptr [r8 + rcx*8], r9
01da1a0a  je       0x1da1a91
01da1a10  inc      ax
01da1a13  cmp      ax, dx
01da1a16  jb       0x1da1a00
01da1a18  mov      r8d, 1
01da1a1e  mov      rdx, r9
01da1a21  mov      rcx, rbx
01da1a24  call     0x4ddae0 ; ?
01da1a29  mov      rdx, rax
01da1a2c  mov      rax, qword ptr [rdx]
01da1a2f  mov      rdx, qword ptr [rdx + 8]
01da1a33  mov      rcx, rbx
01da1a36  call     rax
01da1a38  mov      r8, qword ptr [rip + 0x25e8ed9] ; [438a918] TypeInfo#53940
01da1a3f  test     rax, rax
01da1a42  je       0x1da1cd1
01da1a48  mov      rdx, qword ptr [rax]
01da1a4b  mov      rcx, qword ptr [r8 + 0x40]
01da1a4f  cmp      qword ptr [rdx + 0x40], rcx
01da1a53  mov      rcx, rax
01da1a56  jne      0x1da1cc9
01da1a5c  call     0x4dff60 ; ?
01da1a61  movsxd   rbx, dword ptr [rax]
01da1a64  lea      eax, [rbx - 0xc]
01da1a67  test     eax, eax
01da1a69  js       0x1da1aea
01da1a6b  mov      rdi, qword ptr [rsi + 0x280]
01da1a72  mov      r14, qword ptr [rsi + 0x298]
01da1a79  test     r14, r14
01da1a7c  je       0x1da1cab
01da1a82  lea      eax, [rbx - 0xc]
01da1a85  cmp      eax, dword ptr [r14 + 0x18]
01da1a89  jae      0x1da1c8c
01da1a8f  jmp      0x1da1ab4
01da1a91  movzx    ecx, ax
01da1a94  add      rcx, rcx
01da1a97  mov      ecx, dword ptr [r8 + rcx*8 + 8]
01da1a9c  inc      ecx
01da1a9e  movsxd   rdx, ecx
01da1aa1  shl      rdx, 4
01da1aa5  add      rdx, 0x138
01da1aac  add      rdx, r10
01da1aaf  jmp      0x1da1a2c
01da1ab4  mov      r14, qword ptr [r14 + rbx*8 - 0x40]
01da1ab9  test     rdi, rdi
01da1abc  je       0x1da1ca6
01da1ac2  test     r14, r14
01da1ac5  je       0x1da1adf
01da1ac7  mov      rdx, qword ptr [rdi]
01da1aca  mov      rdx, qword ptr [rdx + 0x40]
01da1ace  mov      rcx, r14
01da1ad1  call     0x4dfda0 ; ?
01da1ad6  test     rax, rax
01da1ad9  je       0x1da1c92
01da1adf  cmp      ebx, dword ptr [rdi + 0x18]
01da1ae2  jae      0x1da1ca1
01da1ae8  jmp      0x1da1b5d
01da1aea  mov      rdi, qword ptr [rsi + 0x168]
01da1af1  mov      rax, qword ptr [rip + 0x25e8e20] ; [438a918] TypeInfo#53940
01da1af8  mov      qword ptr [rsp + 0x40], rax
01da1afd  mov      qword ptr [rsp + 0x48], 0xffffffffffffffff
01da1b06  mov      dword ptr [rsp + 0x50], ebx
01da1b0a  xor      edx, edx
01da1b0c  lea      rcx, [rsp + 0x40]
01da1b11  call     0x2067ba0 ; String Enum::ToString()
01da1b16  xor      r8d, r8d
01da1b19  mov      rdx, rax
01da1b1c  mov      rcx, rdi
01da1b1f  call     0x1de9050 ; Transform KANAI.Kernel.Extensions.Extensions::FindAlls(Transform,String)
01da1b24  mov      r14, rax
01da1b27  mov      rdi, qword ptr [rsi + 0x280]
01da1b2e  test     rdi, rdi
01da1b31  je       0x1da1cc4
01da1b37  test     rax, rax
01da1b3a  je       0x1da1b54
01da1b3c  mov      rdx, qword ptr [rdi]
01da1b3f  mov      rdx, qword ptr [rdx + 0x40]
01da1b43  mov      rcx, rax
01da1b46  call     0x4dfda0 ; ?
01da1b4b  test     rax, rax
01da1b4e  je       0x1da1cb0
01da1b54  cmp      ebx, dword ptr [rdi + 0x18]
01da1b57  jae      0x1da1cbf
01da1b5d  mov      qword ptr [rdi + rbx*8 + 0x20], r14
01da1b62  lea      rax, [rdi + 0x20]
01da1b66  lea      rcx, [rax + rbx*8]
01da1b6a  mov      rdx, r14
01da1b6d  call     0x4dfd80 ; ?
01da1b72  jmp      0x1da19a0
01da1b77  mov      rdx, qword ptr [rip + 0x262ae12] ; [43cc990] TypeInfo#39371
01da1b7e  mov      rcx, qword ptr [r13]
01da1b82  call     0x4dfda0 ; ?
01da1b87  mov      qword ptr [r12], rax
01da1b8b  test     rax, rax
01da1b8e  je       0x1da1ba1
01da1b90  xor      ecx, ecx
01da1b92  mov      r8, rax
01da1b95  mov      rdx, qword ptr [rip + 0x262adf4] ; [43cc990] TypeInfo#39371
01da1b9c  call     0x22b0 ; ?
01da1ba1  jmp      0x1da1bc3
01da1ba3  lea      rcx, [rsp + 0x30]
01da1ba8  call     0x71b4f0 ; ?
01da1bad  mov      rcx, qword ptr [rsp + 0x28]
01da1bb2  test     rcx, rcx
01da1bb5  jne      0x1da1ce1
01da1bbb  mov      rsi, qword ptr [rsp + 0xa0]
01da1bc3  mov      rdx, qword ptr [rsi + 0x288]
01da1bca  test     rdx, rdx
01da1bcd  je       0x1da1c86
01da1bd3  mov      edx, dword ptr [rdx + 0x18]
01da1bd6  mov      dword ptr [rsi + 0x2d8], edx
01da1bdc  mov      rcx, qword ptr [rip + 0x25ced2d] ; [4370910] TypeInfo#72329
01da1be3  call     0x4dfe00 ; ?
01da1be8  mov      qword ptr [rsi + 0x2e0], rax
01da1bef  lea      rcx, [rsi + 0x2e0]
01da1bf6  mov      rdx, rax
01da1bf9  call     0x4dfd80 ; ?
01da1bfe  mov      edx, dword ptr [rsi + 0x2d8]
01da1c04  mov      rcx, qword ptr [rip + 0x25ced05] ; [4370910] TypeInfo#72329
01da1c0b  call     0x4dfe00 ; ?
01da1c10  mov      qword ptr [rsi + 0x2e8], rax
01da1c17  lea      rcx, [rsi + 0x2e8]
01da1c1e  mov      rdx, rax
01da1c21  call     0x4dfd80 ; ?
01da1c26  mov      edx, dword ptr [rsi + 0x2d8]
01da1c2c  mov      rcx, qword ptr [rip + 0x25cecdd] ; [4370910] TypeInfo#72329
01da1c33  call     0x4dfe00 ; ?
01da1c38  mov      qword ptr [rsi + 0x2f0], rax
01da1c3f  lea      rcx, [rsi + 0x2f0]
01da1c46  mov      rdx, rax
01da1c49  call     0x4dfd80 ; ?
01da1c4e  mov      edx, dword ptr [rsi + 0x2d8]
01da1c54  mov      rcx, qword ptr [rip + 0x25cecb5] ; [4370910] TypeInfo#72329
01da1c5b  call     0x4dfe00 ; ?
01da1c60  mov      qword ptr [rsi + 0x2f8], rax
01da1c67  lea      rcx, [rsi + 0x2f8]
01da1c6e  mov      rdx, rax
01da1c71  call     0x4dfd80 ; ?
01da1c76  add      rsp, 0x60
01da1c7a  pop      r15
01da1c7c  pop      r14
01da1c7e  pop      r13
01da1c80  pop      r12
01da1c82  pop      rdi
01da1c83  pop      rsi
01da1c84  pop      rbx
01da1c85  ret      
01da1c86  call     0x4e0d00 ; ThrowNullRef
01da1c8b  nop      
01da1c8c  call     0x4e0cf0 ; ?
01da1c91  nop      
01da1c92  call     0x4e0670 ; ?
01da1c97  xor      edx, edx
01da1c99  mov      rcx, rax
01da1c9c  call     0x4e0cc0 ; ?
01da1ca1  call     0x4e0cf0 ; ?
01da1ca6  call     0x4e0d00 ; ThrowNullRef
01da1cab  call     0x4e0d00 ; ThrowNullRef
01da1cb0  call     0x4e0670 ; ?
01da1cb5  xor      edx, edx
01da1cb7  mov      rcx, rax
01da1cba  call     0x4e0cc0 ; ?
01da1cbf  call     0x4e0cf0 ; ?
01da1cc4  call     0x4e0d00 ; ThrowNullRef
01da1cc9  mov      rdx, r8
01da1ccc  call     0x4dfdc0 ; ?
01da1cd1  call     0x4e0d00 ; ThrowNullRef
01da1cd6  call     0x4e0d00 ; ThrowNullRef
01da1cdb  call     0x4e0d00 ; ThrowNullRef
01da1ce0  nop      
01da1ce1  call     0x4dc9e0 ; ?
01da1ce6  int3     
01da1ce7  int3     
01da1ce8  int3     
01da1ce9  int3     
01da1cea  int3     
01da1ceb  int3     
01da1cec  int3     
01da1ced  int3     
01da1cee  int3     
01da1cef  int3     

### Void Enemy.Ene_Bos07::ReStart(Boolean)  RVA=0x1DA5FC0 len=0x140
01da5fc0  mov      qword ptr [rsp + 8], rbx
01da5fc5  push     rdi
01da5fc6  sub      rsp, 0x20
01da5fca  xor      r8d, r8d
01da5fcd  mov      rbx, rcx
01da5fd0  call     0x1dba390 ; Void Enemy.Ene_BosBase::ReStart(Boolean)
01da5fd5  xor      edi, edi
01da5fd7  cmp      dword ptr [rbx + 0x270], edi
01da5fdd  je       0x1da5feb
01da5fdf  mov      dword ptr [rbx + 0x270], edi
01da5fe5  mov      dword ptr [rbx + 0x1ec], edi
01da5feb  mov      rax, qword ptr [rbx + 0xb8]
01da5ff2  test     rax, rax
01da5ff5  je       0x1da60f9
01da5ffb  xor      edx, edx
01da5ffd  mov      byte ptr [rax + 0x1d4], dil
01da6004  mov      rcx, rbx
01da6007  call     0x1d0d1b0 ; Void Enemy.PawnEnemy::CreateToken()
01da600c  mov      rax, qword ptr [rbx + 0xb8]
01da6013  test     rax, rax
01da6016  je       0x1da60f9
01da601c  mov      byte ptr [rax + 0x191], 1
01da6023  mov      dword ptr [rbx + 0x302], edi
01da6029  mov      qword ptr [rbx + 0x308], rdi
01da6030  mov      dword ptr [rbx + 0x310], edi
01da6036  mov      word ptr [rbx + 0x314], di
01da603d  mov      qword ptr [rbx + 0x318], rdi
01da6044  mov      qword ptr [rbx + 0x320], rdi
01da604b  mov      qword ptr [rbx + 0x328], rdi
01da6052  mov      qword ptr [rbx + 0x330], rdi
01da6059  mov      qword ptr [rbx + 0x338], rdi
01da6060  cmp      byte ptr [rip + 0x28b63f6], dil ; [465c45d] bss
01da6067  jne      0x1da607c
01da6069  lea      rcx, [rip + 0x261b668] ; [43c16d8] TypeInfo#48704
01da6070  call     0x4e0a50 ; il2cpp_init_metadata
01da6075  mov      byte ptr [rip + 0x28b63e1], 1 ; [465c45d] bss
01da607c  mov      rax, qword ptr [rip + 0x261b655] ; [43c16d8] TypeInfo#48704
01da6083  xor      r8d, r8d
01da6086  mov      edx, 3
01da608b  mov      rcx, qword ptr [rax + 0xb8]
01da6092  movsd    xmm0, qword ptr [rcx]
01da6096  mov      eax, dword ptr [rcx + 8]
01da6099  mov      rcx, rbx
01da609c  movsd    qword ptr [rbx + 0x340], xmm0
01da60a4  mov      dword ptr [rbx + 0x348], eax
01da60aa  call     0x1d0da10 ; Enemy.EnePartsGroup Enemy.PawnEnemy::GetParts(Int32)
01da60af  test     rax, rax
01da60b2  je       0x1da60f9
01da60b4  xor      r9d, r9d
01da60b7  mov      r8b, 1
01da60ba  mov      edx, 0x10
01da60bf  mov      rcx, rax
01da60c2  call     0x1d61c30 ; Void Enemy.EnePartsGroup::ChangeCollisionsAttribute(Enemy.EnemyCollisionAttribute,Boolean)
01da60c7  xor      r8d, r8d
01da60ca  mov      edx, 4
01da60cf  mov      rcx, rbx
01da60d2  call     0x1d0da10 ; Enemy.EnePartsGroup Enemy.PawnEnemy::GetParts(Int32)
01da60d7  test     rax, rax
01da60da  je       0x1da60f9
01da60dc  xor      r9d, r9d
01da60df  mov      r8b, 1
01da60e2  mov      edx, 0x10
01da60e7  mov      rcx, rax
01da60ea  mov      rbx, qword ptr [rsp + 0x30]
01da60ef  add      rsp, 0x20
01da60f3  pop      rdi
01da60f4  jmp      0x1d61c30 ; Void Enemy.EnePartsGroup::ChangeCollisionsAttribute(Enemy.EnemyCollisionAttribute,Boolean)
01da60f9  call     0x4e0d00 ; ThrowNullRef
01da60fe  int3     
01da60ff  int3     

### Void Enemy.Ene_Bos07::GetStart()  RVA=0x1D7E4B0 len=0x30
01d7e4b0  push     rbx
01d7e4b2  sub      rsp, 0x20
01d7e4b6  xor      edx, edx
01d7e4b8  mov      rbx, rcx
01d7e4bb  call     0x1d0db40 ; Void Enemy.PawnEnemy::GetStart()
01d7e4c0  xor      r8d, r8d
01d7e4c3  mov      edx, 1
01d7e4c8  mov      rcx, rbx
01d7e4cb  add      rsp, 0x20
01d7e4cf  pop      rbx
01d7e4d0  jmp      0x1ccf580 ; Void InGameCollisionBase::SetObjectFlag(InGameObject/InGameObjectFlag)
01d7e4d5  int3     
01d7e4d6  int3     
01d7e4d7  int3     
01d7e4d8  int3     
01d7e4d9  int3     
01d7e4da  int3     
01d7e4db  int3     
01d7e4dc  int3     
01d7e4dd  int3     
01d7e4de  int3     
01d7e4df  int3     

### Void Enemy.Ene_Bos07::ToDestroid()  RVA=0x1DA6710 len=0xC0
01da6710  push     rbx
01da6712  sub      rsp, 0x20
01da6716  cmp      byte ptr [rip + 0x28bd0ed], 0 ; [466380a] bss
01da671d  mov      rbx, rcx
01da6720  jne      0x1da6735
01da6722  lea      rcx, [rip + 0x2606b77] ; [43ad2a0] TypeInfo#46759
01da6729  call     0x4e0a50 ; il2cpp_init_metadata
01da672e  mov      byte ptr [rip + 0x28bd0d5], 1 ; [466380a] bss
01da6735  xor      edx, edx
01da6737  mov      rcx, rbx
01da673a  call     0x1dbb280 ; Boolean Enemy.Ene_BosBase::get_IsTrophy()
01da673f  test     al, al
01da6741  je       0x1da6764
01da6743  mov      rcx, qword ptr [rip + 0x2606b56] ; [43ad2a0] TypeInfo#46759
01da674a  cmp      dword ptr [rcx + 0xe4], 0
01da6751  jne      0x1da6758
01da6753  call     0x4e0d90 ; il2cpp_class_init
01da6758  xor      edx, edx
01da675a  mov      ecx, 6
01da675f  call     0x2717e50 ; Void TXEKernel.TXEResident::SetTrophy(TXEKernel.TrophyManager/ID)
01da6764  xor      edx, edx
01da6766  mov      rcx, rbx
01da6769  call     0x1dba790 ; Void Enemy.Ene_BosBase::StopBossTimer()
01da676e  mov      rcx, qword ptr [rbx + 0xb8]
01da6775  test     rcx, rcx
01da6778  je       0x1da67c1
01da677a  xor      edx, edx
01da677c  call     0x1cd9830 ; Void InGameEnemyMoveBase::DeleteRouteToken()
01da6781  xor      edx, edx
01da6783  mov      rcx, rbx
01da6786  call     0x1d0f520 ; Void Enemy.PawnEnemy::ReleaseToken()
01da678b  cmp      dword ptr [rbx + 0x270], 0x64
01da6792  je       0x1da67a8
01da6794  mov      dword ptr [rbx + 0x270], 0x64
01da679e  mov      dword ptr [rbx + 0x1ec], 0
01da67a8  mov      rax, qword ptr [rbx + 0xb8]
01da67af  test     rax, rax
01da67b2  je       0x1da67c1
01da67b4  mov      byte ptr [rax + 0x1d4], 0
01da67bb  add      rsp, 0x20
01da67bf  pop      rbx
01da67c0  ret      
01da67c1  call     0x4e0d00 ; ThrowNullRef
01da67c6  int3     
01da67c7  int3     
01da67c8  int3     
01da67c9  int3     
01da67ca  int3     
01da67cb  int3     
01da67cc  int3     
01da67cd  int3     
01da67ce  int3     
01da67cf  int3     

### Single Enemy.Ene_Bos07::AddDamageParts(Single,Int32,Int32,Boolean)  RVA=0x1DA07E0 len=0x130
01da07e0  mov      qword ptr [rsp + 8], rbx
01da07e5  mov      qword ptr [rsp + 0x10], rbp
01da07ea  mov      qword ptr [rsp + 0x18], rsi
01da07ef  push     rdi
01da07f0  sub      rsp, 0x50
01da07f4  mov      edi, r8d
01da07f7  movaps   xmmword ptr [rsp + 0x30], xmm7
01da07fc  mov      edx, edi
01da07fe  xor      r8d, r8d
01da0801  mov      ebp, r9d
01da0804  movaps   xmm7, xmm1
01da0807  mov      rbx, rcx
01da080a  call     0x1d0da10 ; Enemy.EnePartsGroup Enemy.PawnEnemy::GetParts(Int32)
01da080f  mov      rsi, rax
01da0812  test     rax, rax
01da0815  je       0x1da08fe
01da081b  movaps   xmmword ptr [rsp + 0x40], xmm6
01da0820  cmp      byte ptr [rax + 0x9a], 0
01da0827  xorps    xmm6, xmm6
01da082a  jne      0x1da08c9
01da0830  movzx    ecx, byte ptr [rsp + 0x80]
01da0838  mov      r9d, ebp
01da083b  mov      qword ptr [rsp + 0x28], 0
01da0844  mov      r8d, edi
01da0847  mov      byte ptr [rsp + 0x20], cl
01da084b  movaps   xmm1, xmm7
01da084e  mov      rcx, rbx
01da0851  call     0x1d0c670 ; Single Enemy.PawnEnemy::AddDamageParts(Single,Int32,Int32,Boolean)
01da0856  movaps   xmm0, xmm7
01da0859  mulss    xmm0, dword ptr [rip + 0x174035b] ; [34e0bbc] f=0.009999999776482582 d=5.3737179290461957e-17 v4=(0.01, 0.017453, 0.05, 0.5)
01da0861  cmp      edi, 1
01da0864  jne      0x1da089a
01da0866  addss    xmm0, dword ptr [rbx + 0x308]
01da086e  comiss   xmm6, xmm0
01da0871  ja       0x1da088d
01da0873  movss    xmm1, dword ptr [rip + 0x1740351] ; [34e0bcc] f=1.0 d=50.12387841939926 v4=(1.0, 3.141593, 4.0, 10.0)
01da087b  comiss   xmm0, xmm1
01da087e  jbe      0x1da0890
01da0880  movaps   xmm0, xmm1
01da0883  movss    dword ptr [rbx + 0x308], xmm0
01da088b  jmp      0x1da08c9
01da088d  xorps    xmm0, xmm0
01da0890  movss    dword ptr [rbx + 0x308], xmm0
01da0898  jmp      0x1da08c9
01da089a  cmp      edi, 2
01da089d  jne      0x1da08c9
01da089f  addss    xmm0, dword ptr [rbx + 0x30c]
01da08a7  comiss   xmm6, xmm0
01da08aa  ja       0x1da08be
01da08ac  movss    xmm1, dword ptr [rip + 0x1740318] ; [34e0bcc] f=1.0 d=50.12387841939926 v4=(1.0, 3.141593, 4.0, 10.0)
01da08b4  comiss   xmm0, xmm1
01da08b7  jbe      0x1da08c1
01da08b9  movaps   xmm0, xmm1
01da08bc  jmp      0x1da08c1
01da08be  xorps    xmm0, xmm0
01da08c1  movss    dword ptr [rbx + 0x30c], xmm0
01da08c9  xor      edx, edx
01da08cb  mov      rcx, rsi
01da08ce  call     0x1d63440 ; Boolean Enemy.EnePartsGroup::get_WithOwnerDamage()
01da08d3  test     al, al
01da08d5  je       0x1da08f9
01da08d7  movaps   xmm0, xmm7
01da08da  movaps   xmm6, xmmword ptr [rsp + 0x40]
01da08df  mov      rbx, qword ptr [rsp + 0x60]
01da08e4  mov      rbp, qword ptr [rsp + 0x68]
01da08e9  mov      rsi, qword ptr [rsp + 0x70]
01da08ee  movaps   xmm7, xmmword ptr [rsp + 0x30]
01da08f3  add      rsp, 0x50
01da08f7  pop      rdi
01da08f8  ret      
01da08f9  xorps    xmm0, xmm0
01da08fc  jmp      0x1da08da
01da08fe  movaps   xmm0, xmm7
01da0901  jmp      0x1da08df
01da0903  int3     
01da0904  int3     
01da0905  int3     
01da0906  int3     
01da0907  int3     
01da0908  int3     
01da0909  int3     
01da090a  int3     
01da090b  int3     
01da090c  int3     
01da090d  int3     
01da090e  int3     
01da090f  int3     

### Void Enemy.Ene_Bos07::OnPartsBreak(Int32)  RVA=0x1DA2A30 len=0x40
01da2a30  sub      rsp, 0x38
01da2a34  cmp      edx, 1
01da2a37  je       0x1da2a3e
01da2a39  cmp      edx, 2
01da2a3c  jne      0x1da2a64
01da2a3e  movss    xmm3, dword ptr [rip + 0x173e192] ; [34e0bd8] f=10.0 d=134217760.5625 v4=(10.0, 20.0, 57.29578, 100.0)
01da2a46  movss    xmm2, dword ptr [rip + 0x1749fbe] ; [34eca0c] f=2.0 d=5.304989477e-315 v4=(2.0, 0.0, 2.0, 6.283185)
01da2a4e  movss    xmm1, dword ptr [rip + 0x173e172] ; [34e0bc8] f=0.5 d=0.007812501833541319 v4=(0.5, 1.0, 3.141593, 4.0)
01da2a56  mov      qword ptr [rsp + 0x20], 0
01da2a5f  call     0x1d0cad0 ; Void Enemy.PawnEnemy::AddShake(Single,Single,Single)
01da2a64  add      rsp, 0x38
01da2a68  ret      
01da2a69  int3     
01da2a6a  int3     
01da2a6b  int3     
01da2a6c  int3     
01da2a6d  int3     
01da2a6e  int3     
01da2a6f  int3     

### Void Enemy.Ene_Bos07::StateExec(Single)  RVA=0x1DA65A0 len=0x170
01da65a0  push     rbx
01da65a2  sub      rsp, 0x30
01da65a6  movaps   xmmword ptr [rsp + 0x20], xmm6
01da65ab  xor      edx, edx
01da65ad  movaps   xmm6, xmm1
01da65b0  mov      rbx, rcx
01da65b3  call     0x1da1cf0 ; Boolean Enemy.Ene_Bos07::IsArmBrokenOrDifficultyUp()
01da65b8  test     al, al
01da65ba  je       0x1da6602
01da65bc  cmp      dword ptr [rbx + 0x270], 4
01da65c3  je       0x1da65d9
01da65c5  mov      dword ptr [rbx + 0x270], 4
01da65cf  mov      dword ptr [rbx + 0x1ec], 0
01da65d9  mov      rax, qword ptr [rbx + 0xb8]
01da65e0  test     rax, rax
01da65e3  je       0x1da66ec
01da65e9  mov      byte ptr [rax + 0x1d4], 0
01da65f0  mov      word ptr [rbx + 0x302], 0x101
01da65f9  mov      word ptr [rbx + 0x314], 0
01da6602  movsxd   rdx, dword ptr [rbx + 0x270]
01da6609  cmp      edx, 6
01da660c  ja       0x1da66ce
01da6612  lea      r8, [rip - 0x1da6619]
01da6619  mov      ecx, dword ptr [r8 + rdx*4 + 0x1da66f4] ; JT 1da6626,1da663e,1da6656,1da666e,1da6686,1da669e,1da66b6,83485340,3d8020ec,28bd0ed,d98b4800,8d481375
01da6621  add      rcx, r8
01da6624  jmp      rcx
01da6626  xor      r8d, r8d
01da6629  movaps   xmm1, xmm6
01da662c  mov      rcx, rbx
01da662f  movaps   xmm6, xmmword ptr [rsp + 0x20]
01da6634  add      rsp, 0x30
01da6638  pop      rbx
01da6639  jmp      0x1da59a0 ; Void Enemy.Ene_Bos07::PatternMoveEntryWait(Single)
01da663e  xor      r8d, r8d
01da6641  movaps   xmm1, xmm6
01da6644  mov      rcx, rbx
01da6647  movaps   xmm6, xmmword ptr [rsp + 0x20]
01da664c  add      rsp, 0x30
01da6650  pop      rbx
01da6651  jmp      0x1da2a70 ; Void Enemy.Ene_Bos07::PatternMove2(Single)
01da6656  xor      r8d, r8d
01da6659  movaps   xmm1, xmm6
01da665c  mov      rcx, rbx
01da665f  movaps   xmm6, xmmword ptr [rsp + 0x20]
01da6664  add      rsp, 0x30
01da6668  pop      rbx
01da6669  jmp      0x1da3140 ; Void Enemy.Ene_Bos07::PatternMove3(Single)
01da666e  xor      r8d, r8d
01da6671  movaps   xmm1, xmm6
01da6674  mov      rcx, rbx
01da6677  movaps   xmm6, xmmword ptr [rsp + 0x20]
01da667c  add      rsp, 0x30
01da6680  pop      rbx
01da6681  jmp      0x1da3d30 ; Void Enemy.Ene_Bos07::PatternMove4(Single)
01da6686  xor      r8d, r8d
01da6689  movaps   xmm1, xmm6
01da668c  mov      rcx, rbx
01da668f  movaps   xmm6, xmmword ptr [rsp + 0x20]
01da6694  add      rsp, 0x30
01da6698  pop      rbx
01da6699  jmp      0x1da4650 ; Void Enemy.Ene_Bos07::PatternMove5(Single)
01da669e  xor      r8d, r8d
01da66a1  movaps   xmm1, xmm6
01da66a4  mov      rcx, rbx
01da66a7  movaps   xmm6, xmmword ptr [rsp + 0x20]
01da66ac  add      rsp, 0x30
01da66b0  pop      rbx
01da66b1  jmp      0x1da4be0 ; Void Enemy.Ene_Bos07::PatternMove6(Single)
01da66b6  xor      r8d, r8d
01da66b9  movaps   xmm1, xmm6
01da66bc  mov      rcx, rbx
01da66bf  movaps   xmm6, xmmword ptr [rsp + 0x20]
01da66c4  add      rsp, 0x30
01da66c8  pop      rbx
01da66c9  jmp      0x1da5100 ; Void Enemy.Ene_Bos07::PatternMove7(Single)
01da66ce  cmp      edx, 0x64
01da66d1  jne      0x1da66e1
01da66d3  xor      r8d, r8d
01da66d6  movaps   xmm1, xmm6
01da66d9  mov      rcx, rbx
01da66dc  call     0x1da53c0 ; Void Enemy.Ene_Bos07::PatternMoveDestruction(Single)
01da66e1  movaps   xmm6, xmmword ptr [rsp + 0x20]
01da66e6  add      rsp, 0x30
01da66ea  pop      rbx
01da66eb  ret      
01da66ec  call     0x4e0d00 ; ThrowNullRef
01da66f1  int3     
01da66f2  nop      
01da66f4  fiadd    dword ptr es:[rcx]
01da66f8  fiadd    dword ptr ds:[rcx]
01da66fc  push     rsi
01da66fd  fiadd    dword ptr [rcx]
01da6700  outsb    dx, byte ptr [rsi]
01da6701  fiadd    dword ptr [rcx]
01da6704  xchg     byte ptr [rsi - 0x26], ah
01da6707  add      dword ptr [rsi - 0x49fe259a], ebx
01da670d  fiadd    dword ptr [rcx]

### Boolean Enemy.Ene_Bos07::IsLegBrokenOrDifficultyUp()  RVA=0x1DA1F10 len=0x90
01da1f10  push     rbx
01da1f12  sub      rsp, 0x20
01da1f16  cmp      byte ptr [rcx + 0x302], 0
01da1f1d  mov      rbx, rcx
01da1f20  je       0x1da1f2a
01da1f22  xor      al, al
01da1f24  add      rsp, 0x20
01da1f28  pop      rbx
01da1f29  ret      
01da1f2a  xor      r8d, r8d
01da1f2d  mov      edx, 1
01da1f32  call     0x1d0da10 ; Enemy.EnePartsGroup Enemy.PawnEnemy::GetParts(Int32)
01da1f37  test     rax, rax
01da1f3a  je       0x1da1f94
01da1f3c  cmp      byte ptr [rax + 0x9a], 0
01da1f43  je       0x1da1f63
01da1f45  xor      r8d, r8d
01da1f48  mov      edx, 2
01da1f4d  mov      rcx, rbx
01da1f50  call     0x1d0da10 ; Enemy.EnePartsGroup Enemy.PawnEnemy::GetParts(Int32)
01da1f55  test     rax, rax
01da1f58  je       0x1da1f94
01da1f5a  cmp      byte ptr [rax + 0x9a], 0
01da1f61  jne      0x1da1f77
01da1f63  xor      r8d, r8d
01da1f66  mov      edx, 3
01da1f6b  mov      rcx, rbx
01da1f6e  call     0x1db9fd0 ; Boolean Enemy.Ene_BosBase::IsOverHP(Enemy.Ene_BosBase/HitPState)
01da1f73  test     al, al
01da1f75  je       0x1da1f7f
01da1f77  mov      al, 1
01da1f79  add      rsp, 0x20
01da1f7d  pop      rbx
01da1f7e  ret      
01da1f7f  xor      r8d, r8d
01da1f82  mov      edx, 9
01da1f87  mov      rcx, rbx
01da1f8a  add      rsp, 0x20
01da1f8e  pop      rbx
01da1f8f  jmp      0x1db9fe0 ; Boolean Enemy.Ene_BosBase::IsOverStep(Enemy.Ene_BosBase/TimeSteps)
01da1f94  call     0x4e0d00 ; ThrowNullRef
01da1f99  int3     
01da1f9a  int3     
01da1f9b  int3     
01da1f9c  int3     
01da1f9d  int3     
01da1f9e  int3     
01da1f9f  int3     

### Boolean Enemy.Ene_Bos07::IsArmBrokenOrDifficultyUp()  RVA=0x1DA1CF0 len=0x90
01da1cf0  push     rbx
01da1cf2  sub      rsp, 0x20
01da1cf6  cmp      byte ptr [rcx + 0x303], 0
01da1cfd  mov      rbx, rcx
01da1d00  je       0x1da1d0a
01da1d02  xor      al, al
01da1d04  add      rsp, 0x20
01da1d08  pop      rbx
01da1d09  ret      
01da1d0a  xor      r8d, r8d
01da1d0d  mov      edx, 3
01da1d12  call     0x1d0da10 ; Enemy.EnePartsGroup Enemy.PawnEnemy::GetParts(Int32)
01da1d17  test     rax, rax
01da1d1a  je       0x1da1d74
01da1d1c  cmp      byte ptr [rax + 0x9a], 0
01da1d23  je       0x1da1d43
01da1d25  xor      r8d, r8d
01da1d28  mov      edx, 4
01da1d2d  mov      rcx, rbx
01da1d30  call     0x1d0da10 ; Enemy.EnePartsGroup Enemy.PawnEnemy::GetParts(Int32)
01da1d35  test     rax, rax
01da1d38  je       0x1da1d74
01da1d3a  cmp      byte ptr [rax + 0x9a], 0
01da1d41  jne      0x1da1d57
01da1d43  xor      r8d, r8d
01da1d46  mov      edx, 5
01da1d4b  mov      rcx, rbx
01da1d4e  call     0x1db9fd0 ; Boolean Enemy.Ene_BosBase::IsOverHP(Enemy.Ene_BosBase/HitPState)
01da1d53  test     al, al
01da1d55  je       0x1da1d5f
01da1d57  mov      al, 1
01da1d59  add      rsp, 0x20
01da1d5d  pop      rbx
01da1d5e  ret      
01da1d5f  xor      r8d, r8d
01da1d62  mov      edx, 0xf
01da1d67  mov      rcx, rbx
01da1d6a  add      rsp, 0x20
01da1d6e  pop      rbx
01da1d6f  jmp      0x1db9fe0 ; Boolean Enemy.Ene_BosBase::IsOverStep(Enemy.Ene_BosBase/TimeSteps)
01da1d74  call     0x4e0d00 ; ThrowNullRef
01da1d79  int3     
01da1d7a  int3     
01da1d7b  int3     
01da1d7c  int3     
01da1d7d  int3     
01da1d7e  int3     
01da1d7f  int3     

### Void Enemy.Ene_Bos07::CheckNextState()  RVA=0x1DA0D30 len=0x270
01da0d30  push     rbx
01da0d32  sub      rsp, 0x20
01da0d36  cmp      dword ptr [rcx + 0x270], 0x64
01da0d3d  mov      rbx, rcx
01da0d40  je       0x1da0e04
01da0d46  xor      edx, edx
01da0d48  call     0x1da1cf0 ; Boolean Enemy.Ene_Bos07::IsArmBrokenOrDifficultyUp()
01da0d4d  test     al, al
01da0d4f  jne      0x1da0f2c
01da0d55  cmp      byte ptr [rbx + 0x302], al
01da0d5b  je       0x1da0d68
01da0d5d  mov      ecx, dword ptr [rbx + 0x270]
01da0d63  jmp      0x1da0e24
01da0d68  xor      r8d, r8d
01da0d6b  mov      edx, 1
01da0d70  mov      rcx, rbx
01da0d73  call     0x1d0da10 ; Enemy.EnePartsGroup Enemy.PawnEnemy::GetParts(Int32)
01da0d78  test     rax, rax
01da0d7b  je       0x1da0f72
01da0d81  cmp      byte ptr [rax + 0x9a], 0
01da0d88  je       0x1da0dac
01da0d8a  xor      r8d, r8d
01da0d8d  mov      edx, 2
01da0d92  mov      rcx, rbx
01da0d95  call     0x1d0da10 ; Enemy.EnePartsGroup Enemy.PawnEnemy::GetParts(Int32)
01da0d9a  test     rax, rax
01da0d9d  je       0x1da0f72
01da0da3  cmp      byte ptr [rax + 0x9a], 0
01da0daa  jne      0x1da0dc0
01da0dac  xor      r8d, r8d
01da0daf  mov      edx, 3
01da0db4  mov      rcx, rbx
01da0db7  call     0x1db9fd0 ; Boolean Enemy.Ene_BosBase::IsOverHP(Enemy.Ene_BosBase/HitPState)
01da0dbc  test     al, al
01da0dbe  je       0x1da0e0a
01da0dc0  mov      ecx, dword ptr [rbx + 0x270]
01da0dc6  cmp      ecx, 6
01da0dc9  je       0x1da0ddd
01da0dcb  xor      eax, eax
01da0dcd  mov      dword ptr [rbx + 0x270], 6
01da0dd7  mov      dword ptr [rbx + 0x1ec], eax
01da0ddd  mov      rax, qword ptr [rbx + 0xb8]
01da0de4  test     rax, rax
01da0de7  je       0x1da0f72
01da0ded  mov      byte ptr [rax + 0x1d4], 0
01da0df4  mov      byte ptr [rbx + 0x302], 1
01da0dfb  mov      word ptr [rbx + 0x314], 0
01da0e04  add      rsp, 0x20
01da0e08  pop      rbx
01da0e09  ret      
01da0e0a  xor      r8d, r8d
01da0e0d  mov      edx, 9
01da0e12  mov      rcx, rbx
01da0e15  call     0x1db9fe0 ; Boolean Enemy.Ene_BosBase::IsOverStep(Enemy.Ene_BosBase/TimeSteps)
01da0e1a  mov      ecx, dword ptr [rbx + 0x270]
01da0e20  test     al, al
01da0e22  jne      0x1da0dc6
01da0e24  cmp      ecx, 6
01da0e27  ja       0x1da0efc
01da0e2d  movsxd   rax, ecx
01da0e30  lea      rdx, [rip - 0x1da0e37]
01da0e37  mov      ecx, dword ptr [rdx + rax*4 + 0x1da0f78] ; JT 1da0e43,1da0e61,1da0e43,1da0ece,1da0ee5,1da0efc,1da0ece,cccccccc,cccccccc,cccccccc,53c48b48,b0ec8148
01da0e3e  add      rcx, rdx
01da0e41  jmp      rcx
01da0e43  cmp      dword ptr [rbx + 0x270], 1
01da0e4a  je       0x1da0f13
01da0e50  mov      dword ptr [rbx + 0x270], 1
01da0e5a  xor      eax, eax
01da0e5c  jmp      0x1da0f0d
01da0e61  cmp      dword ptr [rbx + 0x270], 2
01da0e68  je       0x1da0f13
01da0e6e  xor      eax, eax
01da0e70  mov      dword ptr [rbx + 0x270], 2
01da0e7a  xor      r8d, r8d
01da0e7d  mov      dword ptr [rbx + 0x1ec], eax
01da0e83  mov      edx, 1
01da0e88  mov      rcx, rbx
01da0e8b  call     0x1d0da10 ; Enemy.EnePartsGroup Enemy.PawnEnemy::GetParts(Int32)
01da0e90  test     rax, rax
01da0e93  je       0x1da0f72
01da0e99  movzx    eax, byte ptr [rax + 0x9a]
01da0ea0  xor      r8d, r8d
01da0ea3  mov      edx, 2
01da0ea8  mov      byte ptr [rbx + 0x304], al
01da0eae  mov      rcx, rbx
01da0eb1  call     0x1d0da10 ; Enemy.EnePartsGroup Enemy.PawnEnemy::GetParts(Int32)
01da0eb6  test     rax, rax
01da0eb9  je       0x1da0f72
01da0ebf  movzx    eax, byte ptr [rax + 0x9a]
01da0ec6  mov      byte ptr [rbx + 0x305], al
01da0ecc  jmp      0x1da0f13
01da0ece  cmp      dword ptr [rbx + 0x270], 3
01da0ed5  je       0x1da0f13
01da0ed7  mov      dword ptr [rbx + 0x270], 3
01da0ee1  xor      eax, eax
01da0ee3  jmp      0x1da0f0d
01da0ee5  cmp      dword ptr [rbx + 0x270], 5
01da0eec  je       0x1da0f13
01da0eee  mov      dword ptr [rbx + 0x270], 5
01da0ef8  xor      eax, eax
01da0efa  jmp      0x1da0f0d
01da0efc  cmp      dword ptr [rbx + 0x270], 0
01da0f03  je       0x1da0f13
01da0f05  xor      eax, eax
01da0f07  mov      dword ptr [rbx + 0x270], eax
01da0f0d  mov      dword ptr [rbx + 0x1ec], eax
01da0f13  mov      rax, qword ptr [rbx + 0xb8]
01da0f1a  test     rax, rax
01da0f1d  je       0x1da0f72
01da0f1f  mov      byte ptr [rax + 0x1d4], 0
01da0f26  add      rsp, 0x20
01da0f2a  pop      rbx
01da0f2b  ret      
01da0f2c  cmp      dword ptr [rbx + 0x270], 4
01da0f33  je       0x1da0f47
01da0f35  xor      eax, eax
01da0f37  mov      dword ptr [rbx + 0x270], 4
01da0f41  mov      dword ptr [rbx + 0x1ec], eax
01da0f47  mov      rax, qword ptr [rbx + 0xb8]
01da0f4e  test     rax, rax
01da0f51  je       0x1da0f72
01da0f53  mov      byte ptr [rax + 0x1d4], 0
01da0f5a  mov      word ptr [rbx + 0x302], 0x101
01da0f63  mov      word ptr [rbx + 0x314], 0
01da0f6c  add      rsp, 0x20
01da0f70  pop      rbx
01da0f71  ret      
01da0f72  call     0x4e0d00 ; ThrowNullRef
01da0f77  int3     
01da0f7a  fiadd    dword ptr [rcx]
01da0f7e  fiadd    dword ptr [rcx]
01da0f82  fiadd    dword ptr [rcx]
01da0f86  fiadd    dword ptr [rcx]
01da0f88  in       eax, 0xe
01da0f8a  fiadd    dword ptr [rcx]
01da0f8c  cld      
01da0f8e  fiadd    dword ptr [rcx]
01da0f92  fiadd    dword ptr [rcx]
01da0f94  int3     
01da0f95  int3     
01da0f96  int3     
01da0f97  int3     
01da0f98  int3     
01da0f99  int3     
01da0f9a  int3     
01da0f9b  int3     
01da0f9c  int3     
01da0f9d  int3     
01da0f9e  int3     
01da0f9f  int3     

### Void Enemy.Ene_Bos07::SetState(Enemy.Ene_Bos07/Boss07State)  RVA=0x1DA61B0 len=0x90
01da61b0  push     rbx
01da61b2  sub      rsp, 0x20
01da61b6  mov      rbx, rcx
01da61b9  cmp      edx, dword ptr [rcx + 0x270]
01da61bf  je       0x1da6217
01da61c1  mov      dword ptr [rcx + 0x270], edx
01da61c7  mov      dword ptr [rcx + 0x1ec], 0
01da61d1  cmp      edx, 2
01da61d4  jne      0x1da6217
01da61d6  xor      r8d, r8d
01da61d9  mov      edx, 1
01da61de  call     0x1d0da10 ; Enemy.EnePartsGroup Enemy.PawnEnemy::GetParts(Int32)
01da61e3  test     rax, rax
01da61e6  je       0x1da6230
01da61e8  movzx    eax, byte ptr [rax + 0x9a]
01da61ef  xor      r8d, r8d
01da61f2  mov      edx, 2
01da61f7  mov      byte ptr [rbx + 0x304], al
01da61fd  mov      rcx, rbx
01da6200  call     0x1d0da10 ; Enemy.EnePartsGroup Enemy.PawnEnemy::GetParts(Int32)
01da6205  test     rax, rax
01da6208  je       0x1da6230
01da620a  movzx    eax, byte ptr [rax + 0x9a]
01da6211  mov      byte ptr [rbx + 0x305], al
01da6217  mov      rax, qword ptr [rbx + 0xb8]
01da621e  test     rax, rax
01da6221  je       0x1da6230
01da6223  mov      byte ptr [rax + 0x1d4], 0
01da622a  add      rsp, 0x20
01da622e  pop      rbx
01da622f  ret      
01da6230  call     0x4e0d00 ; ThrowNullRef
01da6235  int3     
01da6236  int3     
01da6237  int3     
01da6238  int3     
01da6239  int3     
01da623a  int3     
01da623b  int3     
01da623c  int3     
01da623d  int3     
01da623e  int3     
01da623f  int3     

### Void Enemy.Ene_Bos07::SetLegBroken()  RVA=0x1DA6160 len=0x50
01da6160  sub      rsp, 0x28
01da6164  cmp      dword ptr [rcx + 0x270], 6
01da616b  je       0x1da6181
01da616d  mov      dword ptr [rcx + 0x270], 6
01da6177  mov      dword ptr [rcx + 0x1ec], 0
01da6181  mov      rax, qword ptr [rcx + 0xb8]
01da6188  test     rax, rax
01da618b  je       0x1da61a9
01da618d  mov      byte ptr [rax + 0x1d4], 0
01da6194  mov      byte ptr [rcx + 0x302], 1
01da619b  mov      word ptr [rcx + 0x314], 0
01da61a4  add      rsp, 0x28
01da61a8  ret      
01da61a9  call     0x4e0d00 ; ThrowNullRef
01da61ae  int3     
01da61af  int3     

### Void Enemy.Ene_Bos07::SetArmBroken()  RVA=0x1DA6100 len=0x60
01da6100  sub      rsp, 0x28
01da6104  cmp      dword ptr [rcx + 0x270], 4
01da610b  je       0x1da6121
01da610d  mov      dword ptr [rcx + 0x270], 4
01da6117  mov      dword ptr [rcx + 0x1ec], 0
01da6121  mov      rax, qword ptr [rcx + 0xb8]
01da6128  test     rax, rax
01da612b  je       0x1da614b
01da612d  mov      byte ptr [rax + 0x1d4], 0
01da6134  mov      word ptr [rcx + 0x302], 0x101
01da613d  mov      word ptr [rcx + 0x314], 0
01da6146  add      rsp, 0x28
01da614a  ret      
01da614b  call     0x4e0d00 ; ThrowNullRef
01da6150  int3     
01da6151  int3     
01da6152  int3     
01da6153  int3     
01da6154  int3     
01da6155  int3     
01da6156  int3     
01da6157  int3     
01da6158  int3     
01da6159  int3     
01da615a  int3     
01da615b  int3     
01da615c  int3     
01da615d  int3     
01da615e  int3     
01da615f  int3     

### Boolean Enemy.Ene_Bos07::IsLeftLegBroken()  RVA=0x1DA1EE0 len=0x30
01da1ee0  sub      rsp, 0x28
01da1ee4  xor      r8d, r8d
01da1ee7  mov      edx, 1
01da1eec  call     0x1d0da10 ; Enemy.EnePartsGroup Enemy.PawnEnemy::GetParts(Int32)
01da1ef1  test     rax, rax
01da1ef4  je       0x1da1f02
01da1ef6  movzx    eax, byte ptr [rax + 0x9a]
01da1efd  add      rsp, 0x28
01da1f01  ret      
01da1f02  call     0x4e0d00 ; ThrowNullRef
01da1f07  int3     
01da1f08  int3     
01da1f09  int3     
01da1f0a  int3     
01da1f0b  int3     
01da1f0c  int3     
01da1f0d  int3     
01da1f0e  int3     
01da1f0f  int3     

### Boolean Enemy.Ene_Bos07::IsRightLegBroken()  RVA=0x1DA1FA0 len=0x30
01da1fa0  sub      rsp, 0x28
01da1fa4  xor      r8d, r8d
01da1fa7  mov      edx, 2
01da1fac  call     0x1d0da10 ; Enemy.EnePartsGroup Enemy.PawnEnemy::GetParts(Int32)
01da1fb1  test     rax, rax
01da1fb4  je       0x1da1fc2
01da1fb6  movzx    eax, byte ptr [rax + 0x9a]
01da1fbd  add      rsp, 0x28
01da1fc1  ret      
01da1fc2  call     0x4e0d00 ; ThrowNullRef
01da1fc7  int3     
01da1fc8  int3     
01da1fc9  int3     
01da1fca  int3     
01da1fcb  int3     
01da1fcc  int3     
01da1fcd  int3     
01da1fce  int3     
01da1fcf  int3     

### Boolean Enemy.Ene_Bos07::IsEitherLegBroken()  RVA=0x1DA1E40 len=0x60
01da1e40  push     rbx
01da1e42  sub      rsp, 0x20
01da1e46  xor      r8d, r8d
01da1e49  mov      edx, 1
01da1e4e  mov      rbx, rcx
01da1e51  call     0x1d0da10 ; Enemy.EnePartsGroup Enemy.PawnEnemy::GetParts(Int32)
01da1e56  test     rax, rax
01da1e59  je       0x1da1e8e
01da1e5b  cmp      byte ptr [rax + 0x9a], 0
01da1e62  je       0x1da1e6c
01da1e64  mov      al, 1
01da1e66  add      rsp, 0x20
01da1e6a  pop      rbx
01da1e6b  ret      
01da1e6c  xor      r8d, r8d
01da1e6f  mov      edx, 2
01da1e74  mov      rcx, rbx
01da1e77  call     0x1d0da10 ; Enemy.EnePartsGroup Enemy.PawnEnemy::GetParts(Int32)
01da1e7c  test     rax, rax
01da1e7f  je       0x1da1e8e
01da1e81  movzx    eax, byte ptr [rax + 0x9a]
01da1e88  add      rsp, 0x20
01da1e8c  pop      rbx
01da1e8d  ret      
01da1e8e  call     0x4e0d00 ; ThrowNullRef
01da1e93  int3     
01da1e94  int3     
01da1e95  int3     
01da1e96  int3     
01da1e97  int3     
01da1e98  int3     
01da1e99  int3     
01da1e9a  int3     
01da1e9b  int3     
01da1e9c  int3     
01da1e9d  int3     
01da1e9e  int3     
01da1e9f  int3     

### Boolean Enemy.Ene_Bos07::IsBothLegBroken()  RVA=0x1DA1DE0 len=0x60
01da1de0  push     rbx
01da1de2  sub      rsp, 0x20
01da1de6  xor      r8d, r8d
01da1de9  mov      edx, 1
01da1dee  mov      rbx, rcx
01da1df1  call     0x1d0da10 ; Enemy.EnePartsGroup Enemy.PawnEnemy::GetParts(Int32)
01da1df6  test     rax, rax
01da1df9  je       0x1da1e2e
01da1dfb  cmp      byte ptr [rax + 0x9a], 0
01da1e02  jne      0x1da1e0c
01da1e04  xor      al, al
01da1e06  add      rsp, 0x20
01da1e0a  pop      rbx
01da1e0b  ret      
01da1e0c  xor      r8d, r8d
01da1e0f  mov      edx, 2
01da1e14  mov      rcx, rbx
01da1e17  call     0x1d0da10 ; Enemy.EnePartsGroup Enemy.PawnEnemy::GetParts(Int32)
01da1e1c  test     rax, rax
01da1e1f  je       0x1da1e2e
01da1e21  movzx    eax, byte ptr [rax + 0x9a]
01da1e28  add      rsp, 0x20
01da1e2c  pop      rbx
01da1e2d  ret      
01da1e2e  call     0x4e0d00 ; ThrowNullRef
01da1e33  int3     
01da1e34  int3     
01da1e35  int3     
01da1e36  int3     
01da1e37  int3     
01da1e38  int3     
01da1e39  int3     
01da1e3a  int3     
01da1e3b  int3     
01da1e3c  int3     
01da1e3d  int3     
01da1e3e  int3     
01da1e3f  int3     

### Boolean Enemy.Ene_Bos07::IsArmBroken()  RVA=0x1DA1D80 len=0x60
01da1d80  push     rbx
01da1d82  sub      rsp, 0x20
01da1d86  xor      r8d, r8d
01da1d89  mov      edx, 3
01da1d8e  mov      rbx, rcx
01da1d91  call     0x1d0da10 ; Enemy.EnePartsGroup Enemy.PawnEnemy::GetParts(Int32)
01da1d96  test     rax, rax
01da1d99  je       0x1da1dce
01da1d9b  cmp      byte ptr [rax + 0x9a], 0
01da1da2  jne      0x1da1dac
01da1da4  xor      al, al
01da1da6  add      rsp, 0x20
01da1daa  pop      rbx
01da1dab  ret      
01da1dac  xor      r8d, r8d
01da1daf  mov      edx, 4
01da1db4  mov      rcx, rbx
01da1db7  call     0x1d0da10 ; Enemy.EnePartsGroup Enemy.PawnEnemy::GetParts(Int32)
01da1dbc  test     rax, rax
01da1dbf  je       0x1da1dce
01da1dc1  movzx    eax, byte ptr [rax + 0x9a]
01da1dc8  add      rsp, 0x20
01da1dcc  pop      rbx
01da1dcd  ret      
01da1dce  call     0x4e0d00 ; ThrowNullRef
01da1dd3  int3     
01da1dd4  int3     
01da1dd5  int3     
01da1dd6  int3     
01da1dd7  int3     
01da1dd8  int3     
01da1dd9  int3     
01da1dda  int3     
01da1ddb  int3     
01da1ddc  int3     
01da1ddd  int3     
01da1dde  int3     
01da1ddf  int3     

### Boolean Enemy.Ene_Bos07::IsFireOK()  RVA=0x1DA1EA0 len=0x40
01da1ea0  sub      rsp, 0x28
01da1ea4  mov      rax, qword ptr [rcx + 0xb8]
01da1eab  test     rax, rax
01da1eae  je       0x1da1ecf
01da1eb0  cmp      byte ptr [rax + 0x1d4], 0
01da1eb7  je       0x1da1ec0
01da1eb9  xor      al, al
01da1ebb  add      rsp, 0x28
01da1ebf  ret      
01da1ec0  cmp      dword ptr [rcx + 0x270], 0x64
01da1ec7  setne    al
01da1eca  add      rsp, 0x28
01da1ece  ret      
01da1ecf  call     0x4e0d00 ; ThrowNullRef
01da1ed4  int3     
01da1ed5  int3     
01da1ed6  int3     
01da1ed7  int3     
01da1ed8  int3     
01da1ed9  int3     
01da1eda  int3     
01da1edb  int3     
01da1edc  int3     
01da1edd  int3     
01da1ede  int3     
01da1edf  int3     

### Void Enemy.Ene_Bos07::FaceCoverRotate(Single)  RVA=0x1DA0FA0 len=0x1E0
01da0fa0  mov      rax, rsp
01da0fa3  push     rbx
01da0fa4  sub      rsp, 0xb0
01da0fab  mov      rbx, qword ptr [rcx + 0x2b8]
01da0fb2  movaps   xmmword ptr [rax - 0x18], xmm6
01da0fb6  movaps   xmm6, xmm1
01da0fb9  test     rbx, rbx
01da0fbc  je       0x1da1178
01da0fc2  movaps   xmmword ptr [rax - 0x28], xmm7
01da0fc6  lea      rcx, [rsp + 0x20]
01da0fcb  movaps   xmmword ptr [rax - 0x38], xmm8
01da0fd0  xor      r8d, r8d
01da0fd3  movaps   xmmword ptr [rax - 0x48], xmm9
01da0fd8  mov      rdx, rbx
01da0fdb  movaps   xmmword ptr [rax - 0x58], xmm10
01da0fe0  movaps   xmmword ptr [rax - 0x68], xmm11
01da0fe5  movaps   xmmword ptr [rax - 0x78], xmm12
01da0fea  call     0x30937f0 ; Quaternion Transform::get_localRotation()
01da0fef  mulss    xmm6, dword ptr [rip + 0x173fbc9] ; [34e0bc0] f=0.01745329238474369 d=2.0463635523047694e-13 v4=(0.017453, 0.05, 0.5, 1.0)
01da0ff7  lea      rdx, [rsp + 0x20]
01da0ffc  xor      r8d, r8d
01da0fff  lea      rcx, [rsp + 0x30]
01da1004  movups   xmm11, xmmword ptr [rax]
01da1008  mov      qword ptr [rsp + 0x20], 0
01da1011  movss    dword ptr [rsp + 0x28], xmm6
01da1017  call     0x304d890 ; Quaternion Quaternion::Internal_FromEulerRad(Vector3&)
01da101c  movaps   xmm12, xmm11
01da1020  movaps   xmm10, xmm11
01da1024  shufps   xmm10, xmm11, 0xff
01da1029  movaps   xmm7, xmm11
01da102d  movaps   xmm0, xmm10
01da1031  shufps   xmm7, xmm11, 0x55
01da1036  movups   xmm9, xmmword ptr [rax]
01da103a  xor      r8d, r8d
01da103d  movaps   xmm5, xmm11
01da1041  movaps   xmm4, xmm7
01da1044  mulss    xmm0, xmm9
01da1049  movaps   xmm8, xmm9
01da104d  shufps   xmm5, xmm11, 0xaa
01da1052  movaps   xmm6, xmm9
01da1056  shufps   xmm8, xmm9, 0xff
01da105b  movaps   xmm1, xmm5
01da105e  mulss    xmm12, xmm8
01da1063  movaps   xmm2, xmm5
01da1066  shufps   xmm6, xmm9, 0xaa
01da106b  movaps   xmm3, xmm9
01da106f  shufps   xmm3, xmm9, 0x55
01da1074  addss    xmm12, xmm0
01da1079  mulss    xmm4, xmm8
01da107e  movaps   xmm0, xmm7
01da1081  mulss    xmm1, xmm9
01da1086  mulss    xmm0, xmm6
01da108a  mulss    xmm2, xmm8
01da108f  addss    xmm12, xmm0
01da1094  movaps   xmm0, xmm5
01da1097  mulss    xmm0, xmm3
01da109b  mulss    xmm5, xmm6
01da109f  subss    xmm12, xmm0
01da10a4  movaps   xmm0, xmm10
01da10a8  mulss    xmm0, xmm3
01da10ac  addss    xmm4, xmm0
01da10b0  shufps   xmm12, xmm12, 0xe1
01da10b5  movaps   xmm0, xmm11
01da10b9  mulss    xmm0, xmm6
01da10bd  addss    xmm4, xmm1
01da10c1  movaps   xmm1, xmm11
01da10c5  mulss    xmm11, xmm9
01da10ca  mulss    xmm1, xmm3
01da10ce  subss    xmm4, xmm0
01da10d2  movaps   xmm0, xmm10
01da10d6  mulss    xmm0, xmm6
01da10da  mulss    xmm10, xmm8
01da10df  movss    xmm12, xmm4
01da10e4  addss    xmm2, xmm0
01da10e8  shufps   xmm12, xmm12, 0xc6
01da10ed  movaps   xmm0, xmm7
01da10f0  subss    xmm10, xmm11
01da10f5  mulss    xmm7, xmm3
01da10f9  mulss    xmm0, xmm9
01da10fe  addss    xmm2, xmm1
01da1102  subss    xmm10, xmm7
01da1107  subss    xmm2, xmm0
01da110b  subss    xmm10, xmm5
01da1110  movss    xmm12, xmm2
01da1115  shufps   xmm12, xmm12, 0x27
01da111a  movss    xmm12, xmm10
01da111f  shufps   xmm12, xmm12, 0x39
01da1124  movups   xmmword ptr [rsp + 0x20], xmm12
01da112a  movdqa   xmmword ptr [rsp + 0x20], xmm12
01da1131  lea      rdx, [rsp + 0x20]
01da1136  mov      rcx, rbx
01da1139  call     0x3094650 ; Void Transform::set_localRotation(Quaternion)
01da113e  movaps   xmm12, xmmword ptr [rsp + 0x40]
01da1144  movaps   xmm11, xmmword ptr [rsp + 0x50]
01da114a  movaps   xmm10, xmmword ptr [rsp + 0x60]
01da1150  movaps   xmm9, xmmword ptr [rsp + 0x70]
01da1156  movaps   xmm8, xmmword ptr [rsp + 0x80]
01da115f  movaps   xmm7, xmmword ptr [rsp + 0x90]
01da1167  movaps   xmm6, xmmword ptr [rsp + 0xa0]
01da116f  add      rsp, 0xb0
01da1176  pop      rbx
01da1177  ret      
01da1178  call     0x4e0d00 ; ThrowNullRef
01da117d  int3     
01da117e  int3     
01da117f  int3     

### String[] Enemy.Ene_Bos07::GetBossBT()  RVA=0x1DA1180 len=0x50
01da1180  sub      rsp, 0x28
01da1184  cmp      byte ptr [rip + 0x28c2680], 0 ; [466380b] bss
01da118b  jne      0x1da11a0
01da118d  lea      rcx, [rip + 0x26109e4] ; [43b1b78] TypeInfo#37312
01da1194  call     0x4e0a50 ; il2cpp_init_metadata
01da1199  mov      byte ptr [rip + 0x28c266b], 1 ; [466380b] bss
01da11a0  mov      rax, qword ptr [rip + 0x26109d1] ; [43b1b78] TypeInfo#37312
01da11a7  cmp      dword ptr [rax + 0xe4], 0
01da11ae  jne      0x1da11bf
01da11b0  mov      rcx, rax
01da11b3  call     0x4e0d90 ; il2cpp_class_init
01da11b8  mov      rax, qword ptr [rip + 0x26109b9] ; [43b1b78] TypeInfo#37312
01da11bf  mov      rax, qword ptr [rax + 0xb8]
01da11c6  mov      rax, qword ptr [rax]
01da11c9  add      rsp, 0x28
01da11cd  ret      
01da11ce  int3     
01da11cf  int3     

### Transform Enemy.Ene_Bos07::GetMuzzle(Enemy.Ene_Bos07/Boss07MZ)  RVA=0x1DA11D0 len=0x30
01da11d0  sub      rsp, 0x28
01da11d4  mov      r8, qword ptr [rcx + 0x280]
01da11db  test     r8, r8
01da11de  je       0x1da11f3
01da11e0  cmp      edx, dword ptr [r8 + 0x18]
01da11e4  jae      0x1da11f9
01da11e6  movsxd   rax, edx
01da11e9  mov      rax, qword ptr [r8 + rax*8 + 0x20]
01da11ee  add      rsp, 0x28
01da11f2  ret      
01da11f3  call     0x4e0d00 ; ThrowNullRef
01da11f8  int3     
01da11f9  call     0x4e0cf0 ; ?
01da11fe  int3     
01da11ff  int3     

### Void Enemy.Ene_Bos07::SetupLegPattern(Enemy.Ene_Bos07/LegPattern,Enemy.Ene_Bos07/LegPattern)  RVA=0x1DA6240 len=0x360
01da6240  mov      qword ptr [rsp + 0x20], rsi
01da6245  push     rdi
01da6246  push     r12
01da6248  push     r15
01da624a  sub      rsp, 0xc0
01da6251  cmp      byte ptr [rip + 0x28bd5b4], 0 ; [466380c] bss
01da6258  mov      rsi, rcx
01da625b  movsxd   r15, r8d
01da625e  movsxd   r12, edx
01da6261  jne      0x1da6276
01da6263  lea      rcx, [rip + 0x260b90e] ; [43b1b78] TypeInfo#37312
01da626a  call     0x4e0a50 ; il2cpp_init_metadata
01da626f  mov      byte ptr [rip + 0x28bd596], 1 ; [466380c] bss
01da6276  cmp      r12d, -1
01da627a  setne    al
01da627d  cmp      r15d, -1
01da6281  mov      byte ptr [rsi + 0x300], al
01da6287  setne    al
01da628a  xor      edi, edi
01da628c  mov      byte ptr [rsi + 0x301], al
01da6292  cmp      dword ptr [rsi + 0x2d8], edi
01da6298  jle      0x1da6578
01da629e  mov      qword ptr [rsp + 0xe0], rbx
01da62a6  mov      ebx, edi
01da62a8  movaps   xmmword ptr [rsp + 0xb0], xmm6
01da62b0  movss    xmm6, dword ptr [rip + 0x173a908] ; [34e0bc0] f=0.01745329238474369 d=2.0463635523047694e-13 v4=(0.017453, 0.05, 0.5, 1.0)
01da62b8  movaps   xmmword ptr [rsp + 0xa0], xmm7
01da62c0  movss    xmm7, dword ptr [rip + 0x173a948] ; [34e0c10] f=-0.0 d=-1.0609978955e-314 v4=(-0.0, -0.0, -0.0, -0.0)
01da62c8  mov      qword ptr [rsp + 0xe8], rbp
01da62d0  mov      qword ptr [rsp + 0xf0], r14
01da62d8  nop      dword ptr [rax + rax]
01da62e0  cmp      byte ptr [rsi + 0x300], 0
01da62e7  je       0x1da640f
01da62ed  mov      rax, qword ptr [rip + 0x260b884] ; [43b1b78] TypeInfo#37312
01da62f4  cmp      dword ptr [rax + 0xe4], 0
01da62fb  jne      0x1da630c
01da62fd  mov      rcx, rax
01da6300  call     0x4e0d90 ; il2cpp_class_init
01da6305  mov      rax, qword ptr [rip + 0x260b86c] ; [43b1b78] TypeInfo#37312
01da630c  mov      rax, qword ptr [rax + 0xb8]
01da6313  mov      rdx, qword ptr [rax + 8]
01da6317  test     rdx, rdx
01da631a  je       0x1da658d
01da6320  cmp      r12d, dword ptr [rdx + 0x18]
01da6324  jae      0x1da6593
01da632a  mov      rax, qword ptr [rsi + 0x288]
01da6331  lea      rcx, [r12 + r12*2]
01da6335  movsd    xmm0, qword ptr [rdx + rcx*4 + 0x20]
01da633b  mov      r14d, dword ptr [rdx + rcx*4 + 0x28]
01da6340  mov      rbp, qword ptr [rsi + 0x2e0]
01da6347  movsd    qword ptr [rsp + 0x40], xmm0
01da634d  test     rax, rax
01da6350  je       0x1da658d
01da6356  cmp      edi, dword ptr [rax + 0x18]
01da6359  jae      0x1da6593
01da635f  mov      rdx, qword ptr [rax + rbx*8 + 0x20]
01da6364  test     rdx, rdx
01da6367  je       0x1da658d
01da636d  xor      r8d, r8d
01da6370  lea      rcx, [rsp + 0x60]
01da6375  call     0x30937f0 ; Quaternion Transform::get_localRotation()
01da637a  test     rbp, rbp
01da637d  je       0x1da658d
01da6383  cmp      edi, dword ptr [rbp + 0x18]
01da6386  jae      0x1da6593
01da638c  movups   xmm0, xmmword ptr [rax]
01da638f  lea      rcx, [rbx + 2]
01da6393  add      rcx, rcx
01da6396  movups   xmmword ptr [rbp + rcx*8], xmm0
01da639b  mov      rbp, qword ptr [rsi + 0x2e8]
01da63a2  test     rbx, rbx
01da63a5  jne      0x1da63af
01da63a7  movss    xmm0, dword ptr [rsp + 0x40]
01da63ad  jmp      0x1da63c2
01da63af  cmp      rbx, 1
01da63b3  jne      0x1da63bd
01da63b5  movss    xmm0, dword ptr [rsp + 0x44]
01da63bb  jmp      0x1da63c2
01da63bd  movd     xmm0, r14d
01da63c2  mulss    xmm0, xmm6
01da63c6  lea      rdx, [rsp + 0x20]
01da63cb  xor      r8d, r8d
01da63ce  mov      dword ptr [rsp + 0x20], 0
01da63d6  lea      rcx, [rsp + 0x70]
01da63db  mov      dword ptr [rsp + 0x28], 0
01da63e3  movss    dword ptr [rsp + 0x24], xmm0
01da63e9  call     0x304d890 ; Quaternion Quaternion::Internal_FromEulerRad(Vector3&)
01da63ee  test     rbp, rbp
01da63f1  je       0x1da658d
01da63f7  cmp      edi, dword ptr [rbp + 0x18]
01da63fa  jae      0x1da6593
01da6400  movups   xmm0, xmmword ptr [rax]
01da6403  lea      rcx, [rbx + 2]
01da6407  add      rcx, rcx
01da640a  movups   xmmword ptr [rbp + rcx*8], xmm0
01da640f  cmp      byte ptr [rsi + 0x301], 0
01da6416  je       0x1da653f
01da641c  mov      rax, qword ptr [rip + 0x260b755] ; [43b1b78] TypeInfo#37312
01da6423  cmp      dword ptr [rax + 0xe4], 0
01da642a  jne      0x1da643b
01da642c  mov      rcx, rax
01da642f  call     0x4e0d90 ; il2cpp_class_init
01da6434  mov      rax, qword ptr [rip + 0x260b73d] ; [43b1b78] TypeInfo#37312
01da643b  mov      rax, qword ptr [rax + 0xb8]
01da6442  mov      rdx, qword ptr [rax + 8]
01da6446  test     rdx, rdx
01da6449  je       0x1da658d
01da644f  cmp      r15d, dword ptr [rdx + 0x18]
01da6453  jae      0x1da6593
01da6459  mov      rax, qword ptr [rsi + 0x290]
01da6460  lea      rcx, [r15 + r15*2]
01da6464  movsd    xmm0, qword ptr [rdx + rcx*4 + 0x20]
01da646a  mov      r14d, dword ptr [rdx + rcx*4 + 0x28]
01da646f  mov      rbp, qword ptr [rsi + 0x2f0]
01da6476  movsd    qword ptr [rsp + 0x50], xmm0
01da647c  test     rax, rax
01da647f  je       0x1da658d
01da6485  cmp      edi, dword ptr [rax + 0x18]
01da6488  jae      0x1da6593
01da648e  mov      rdx, qword ptr [rax + rbx*8 + 0x20]
01da6493  test     rdx, rdx
01da6496  je       0x1da658d
01da649c  xor      r8d, r8d
01da649f  lea      rcx, [rsp + 0x80]
01da64a7  call     0x30937f0 ; Quaternion Transform::get_localRotation()
01da64ac  test     rbp, rbp
01da64af  je       0x1da658d
01da64b5  cmp      edi, dword ptr [rbp + 0x18]
01da64b8  jae      0x1da6593
01da64be  movups   xmm0, xmmword ptr [rax]
01da64c1  lea      rcx, [rbx + 2]
01da64c5  add      rcx, rcx
01da64c8  movups   xmmword ptr [rbp + rcx*8], xmm0
01da64cd  mov      rbp, qword ptr [rsi + 0x2f8]
01da64d4  test     rbx, rbx
01da64d7  jne      0x1da64e1
01da64d9  movss    xmm0, dword ptr [rsp + 0x50]
01da64df  jmp      0x1da64f4
01da64e1  cmp      rbx, 1
01da64e5  jne      0x1da64ef
01da64e7  movss    xmm0, dword ptr [rsp + 0x54]
01da64ed  jmp      0x1da64f4
01da64ef  movd     xmm0, r14d
01da64f4  xorps    xmm0, xmm7
01da64f7  mov      dword ptr [rsp + 0x30], 0
01da64ff  mulss    xmm0, xmm6
01da6503  lea      rdx, [rsp + 0x30]
01da6508  xor      r8d, r8d
01da650b  mov      dword ptr [rsp + 0x38], 0
01da6513  lea      rcx, [rsp + 0x90]
01da651b  movss    dword ptr [rsp + 0x34], xmm0
01da6521  call     0x304d890 ; Quaternion Quaternion::Internal_FromEulerRad(Vector3&)
01da6526  test     rbp, rbp
01da6529  je       0x1da658d
01da652b  cmp      edi, dword ptr [rbp + 0x18]
01da652e  jae      0x1da6593
01da6530  movups   xmm0, xmmword ptr [rax]
01da6533  lea      rcx, [rbx + 2]
01da6537  add      rcx, rcx
01da653a  movups   xmmword ptr [rbp + rcx*8], xmm0
01da653f  inc      edi
01da6541  inc      rbx
01da6544  cmp      edi, dword ptr [rsi + 0x2d8]
01da654a  jl       0x1da62e0
01da6550  mov      r14, qword ptr [rsp + 0xf0]
01da6558  mov      rbp, qword ptr [rsp + 0xe8]
01da6560  movaps   xmm6, xmmword ptr [rsp + 0xb0]
01da6568  mov      rbx, qword ptr [rsp + 0xe0]
01da6570  movaps   xmm7, xmmword ptr [rsp + 0xa0]
01da6578  mov      rsi, qword ptr [rsp + 0xf8]
01da6580  add      rsp, 0xc0
01da6587  pop      r15
01da6589  pop      r12
01da658b  pop      rdi
01da658c  ret      
01da658d  call     0x4e0d00 ; ThrowNullRef
01da6592  int3     
01da6593  call     0x4e0cf0 ; ?
01da6598  int3     
01da6599  int3     
01da659a  int3     
01da659b  int3     
01da659c  int3     
01da659d  int3     
01da659e  int3     
01da659f  int3     

### Void Enemy.Ene_Bos07::ProgressLegPattern(Single)  RVA=0x1DA5F60 len=0x60
01da5f60  push     rbx
01da5f62  sub      rsp, 0x50
01da5f66  movaps   xmmword ptr [rsp + 0x40], xmm6
01da5f6b  xor      edx, edx
01da5f6d  movaps   xmmword ptr [rsp + 0x30], xmm7
01da5f72  movaps   xmm0, xmm1
01da5f75  movaps   xmm7, xmm1
01da5f78  mov      rbx, rcx
01da5f7b  call     0x1de8840 ; Single KANAI.Kernel.EasingUtility::InSine01(Single)
01da5f80  movaps   xmm6, xmm0
01da5f83  xor      edx, edx
01da5f85  movaps   xmm0, xmm7
01da5f88  call     0x1de8b90 ; Single KANAI.Kernel.EasingUtility::OutQuart01(Single)
01da5f8d  movaps   xmm3, xmm0
01da5f90  mov      qword ptr [rsp + 0x20], 0
01da5f99  movaps   xmm2, xmm7
01da5f9c  movaps   xmm1, xmm6
01da5f9f  mov      rcx, rbx
01da5fa2  call     0x1da5c80 ; Void Enemy.Ene_Bos07::ProgressLegPatternSeparately(Single,Single,Single)
01da5fa7  movaps   xmm6, xmmword ptr [rsp + 0x40]
01da5fac  movaps   xmm7, xmmword ptr [rsp + 0x30]
01da5fb1  add      rsp, 0x50
01da5fb5  pop      rbx
01da5fb6  ret      
01da5fb7  int3     
01da5fb8  int3     
01da5fb9  int3     
01da5fba  int3     
01da5fbb  int3     
01da5fbc  int3     
01da5fbd  int3     
01da5fbe  int3     
01da5fbf  int3     

### Void Enemy.Ene_Bos07::ProgressLegPatternSeparately(Single,Single,Single)  RVA=0x1DA5C80 len=0x2E0
01da5c80  mov      rax, rsp
01da5c83  push     rsi
01da5c84  push     rdi
01da5c85  sub      rsp, 0xb8
01da5c8c  cmp      byte ptr [rip + 0x28bdb7a], 0 ; [466380d] bss
01da5c93  mov      rdi, rcx
01da5c96  movaps   xmmword ptr [rax - 0x38], xmm6
01da5c9a  movaps   xmm6, xmm2
01da5c9d  movaps   xmmword ptr [rax - 0x48], xmm7
01da5ca1  movaps   xmm7, xmm1
01da5ca4  movaps   xmmword ptr [rax - 0x58], xmm8
01da5ca9  movaps   xmm8, xmm3
01da5cad  jne      0x1da5cc2
01da5caf  lea      rcx, [rip + 0x25cc6f2] ; [43723a8] TypeInfo#31993
01da5cb6  call     0x4e0a50 ; il2cpp_init_metadata
01da5cbb  mov      byte ptr [rip + 0x28bdb4b], 1 ; [466380d] bss
01da5cc2  mov      rcx, qword ptr [rip + 0x25cc6df] ; [43723a8] TypeInfo#31993
01da5cc9  mov      edx, 3
01da5cce  mov      qword ptr [rsp + 0xd0], rbx
01da5cd6  mov      qword ptr [rsp + 0xd8], rbp
01da5cde  mov      qword ptr [rsp + 0xe0], r12
01da5ce6  mov      qword ptr [rsp + 0xb0], r13
01da5cee  mov      qword ptr [rsp + 0xa8], r14
01da5cf6  mov      qword ptr [rsp + 0xa0], r15
01da5cfe  call     0x4dfe00 ; ?
01da5d03  mov      rsi, rax
01da5d06  test     rax, rax
01da5d09  je       0x1da5f49
01da5d0f  cmp      dword ptr [rax + 0x18], 0
01da5d13  jbe      0x1da5f4f
01da5d19  movss    dword ptr [rax + 0x20], xmm7
01da5d1e  cmp      dword ptr [rax + 0x18], 1
01da5d22  jbe      0x1da5f4f
01da5d28  movss    dword ptr [rax + 0x24], xmm6
01da5d2d  cmp      dword ptr [rax + 0x18], 2
01da5d31  jbe      0x1da5f4f
01da5d37  xor      r13d, r13d
01da5d3a  movss    dword ptr [rax + 0x28], xmm8
01da5d40  mov      ebx, r13d
01da5d43  cmp      dword ptr [rdi + 0x2d8], r13d
01da5d4a  jle      0x1da5ede
01da5d50  mov      ebp, 0x20
01da5d55  lea      r15, [rax + 0x20]
01da5d59  mov      r14d, ebp
01da5d5c  nop      dword ptr [rax]
01da5d60  cmp      ebx, dword ptr [rsi + 0x18]
01da5d63  jae      0x1da5f4f
01da5d69  movss    xmm6, dword ptr [r15]
01da5d6e  cmp      byte ptr [rdi + 0x300], r13b
01da5d75  je       0x1da5e19
01da5d7b  mov      rax, qword ptr [rdi + 0x288]
01da5d82  test     rax, rax
01da5d85  je       0x1da5f49
01da5d8b  cmp      ebx, dword ptr [rax + 0x18]
01da5d8e  jae      0x1da5f4f
01da5d94  mov      rcx, qword ptr [rdi + 0x2e0]
01da5d9b  mov      r12, qword ptr [r14 + rax]
01da5d9f  test     rcx, rcx
01da5da2  je       0x1da5f49
01da5da8  cmp      ebx, dword ptr [rcx + 0x18]
01da5dab  jae      0x1da5f4f
01da5db1  mov      rax, qword ptr [rdi + 0x2e8]
01da5db8  test     rax, rax
01da5dbb  je       0x1da5f49
01da5dc1  cmp      ebx, dword ptr [rax + 0x18]
01da5dc4  jae      0x1da5f4f
01da5dca  movups   xmm1, xmmword ptr [rcx + rbp]
01da5dce  lea      r8, [rsp + 0x30]
01da5dd3  mov      qword ptr [rsp + 0x20], r13
01da5dd8  movups   xmm0, xmmword ptr [rax + rbp]
01da5ddc  lea      rdx, [rsp + 0x40]
01da5de1  movaps   xmm3, xmm6
01da5de4  movaps   xmmword ptr [rsp + 0x40], xmm1
01da5de9  lea      rcx, [rsp + 0x50]
01da5dee  movaps   xmmword ptr [rsp + 0x30], xmm0
01da5df3  call     0x304ddc0 ; Quaternion Quaternion::Internal_Slerp(Quaternion&,Quaternion&,Single)
01da5df8  test     r12, r12
01da5dfb  je       0x1da5f49
01da5e01  movups   xmm0, xmmword ptr [rax]
01da5e04  xor      r8d, r8d
01da5e07  lea      rdx, [rsp + 0x40]
01da5e0c  mov      rcx, r12
01da5e0f  movaps   xmmword ptr [rsp + 0x40], xmm0
01da5e14  call     0x3094650 ; Void Transform::set_localRotation(Quaternion)
01da5e19  cmp      byte ptr [rdi + 0x301], r13b
01da5e20  je       0x1da5ec4
01da5e26  mov      rax, qword ptr [rdi + 0x290]
01da5e2d  test     rax, rax
01da5e30  je       0x1da5f49
01da5e36  cmp      ebx, dword ptr [rax + 0x18]
01da5e39  jae      0x1da5f4f
01da5e3f  mov      rcx, qword ptr [rdi + 0x2f0]
01da5e46  mov      r12, qword ptr [r14 + rax]
01da5e4a  test     rcx, rcx
01da5e4d  je       0x1da5f49
01da5e53  cmp      ebx, dword ptr [rcx + 0x18]
01da5e56  jae      0x1da5f4f
01da5e5c  mov      rax, qword ptr [rdi + 0x2f8]
01da5e63  test     rax, rax
01da5e66  je       0x1da5f49
01da5e6c  cmp      ebx, dword ptr [rax + 0x18]
01da5e6f  jae      0x1da5f4f
01da5e75  movups   xmm1, xmmword ptr [rcx + rbp]
01da5e79  lea      r8, [rsp + 0x40]
01da5e7e  mov      qword ptr [rsp + 0x20], r13
01da5e83  movups   xmm0, xmmword ptr [rax + rbp]
01da5e87  lea      rdx, [rsp + 0x30]
01da5e8c  movaps   xmm3, xmm6
01da5e8f  movaps   xmmword ptr [rsp + 0x30], xmm1
01da5e94  lea      rcx, [rsp + 0x60]
01da5e99  movaps   xmmword ptr [rsp + 0x40], xmm0
01da5e9e  call     0x304ddc0 ; Quaternion Quaternion::Internal_Slerp(Quaternion&,Quaternion&,Single)
01da5ea3  test     r12, r12
01da5ea6  je       0x1da5f49
01da5eac  movups   xmm0, xmmword ptr [rax]
01da5eaf  xor      r8d, r8d
01da5eb2  lea      rdx, [rsp + 0x40]
01da5eb7  mov      rcx, r12
01da5eba  movaps   xmmword ptr [rsp + 0x40], xmm0
01da5ebf  call     0x3094650 ; Void Transform::set_localRotation(Quaternion)
01da5ec4  inc      ebx
01da5ec6  add      r15, 4
01da5eca  add      r14, 8
01da5ece  add      rbp, 0x10
01da5ed2  cmp      ebx, dword ptr [rdi + 0x2d8]
01da5ed8  jl       0x1da5d60
01da5ede  cmp      dword ptr [rsi + 0x18], r13d
01da5ee2  jbe      0x1da5f4f
01da5ee4  movss    xmm0, dword ptr [rsi + 0x20]
01da5ee9  comiss   xmm0, dword ptr [rip + 0x173acdc] ; [34e0bcc] f=1.0 d=50.12387841939926 v4=(1.0, 3.141593, 4.0, 10.0)
01da5ef0  jb       0x1da5ef9
01da5ef2  mov      qword ptr [rdi + 0x308], r13
01da5ef9  mov      r15, qword ptr [rsp + 0xa0]
01da5f01  mov      r14, qword ptr [rsp + 0xa8]
01da5f09  mov      r13, qword ptr [rsp + 0xb0]
01da5f11  mov      r12, qword ptr [rsp + 0xe0]
01da5f19  mov      rbp, qword ptr [rsp + 0xd8]
01da5f21  mov      rbx, qword ptr [rsp + 0xd0]
01da5f29  movaps   xmm6, xmmword ptr [rsp + 0x90]
01da5f31  movaps   xmm7, xmmword ptr [rsp + 0x80]
01da5f39  movaps   xmm8, xmmword ptr [rsp + 0x70]
01da5f3f  add      rsp, 0xb8
01da5f46  pop      rdi
01da5f47  pop      rsi
01da5f48  ret      
01da5f49  call     0x4e0d00 ; ThrowNullRef
01da5f4e  int3     
01da5f4f  call     0x4e0cf0 ; ?
01da5f54  int3     
01da5f55  int3     
01da5f56  int3     
01da5f57  int3     
01da5f58  int3     
01da5f59  int3     
01da5f5a  int3     
01da5f5b  int3     
01da5f5c  int3     
01da5f5d  int3     
01da5f5e  int3     
01da5f5f  int3     

### Void Enemy.Ene_Bos07::PatternMoveEntryWait(Single)  RVA=0x1DA59A0 len=0x2E0
01da59a0  push     rbx
01da59a2  sub      rsp, 0x50
01da59a6  cmp      byte ptr [rip + 0x28bde61], 0 ; [466380e] bss
01da59ad  mov      rbx, rcx
01da59b0  movaps   xmmword ptr [rsp + 0x40], xmm6
01da59b5  movaps   xmm6, xmm1
01da59b8  jne      0x1da59d9
01da59ba  lea      rcx, [rip + 0x260c1b7] ; [43b1b78] TypeInfo#37312
01da59c1  call     0x4e0a50 ; il2cpp_init_metadata
01da59c6  lea      rcx, [rip + 0x25fc99b] ; [43a2368] TypeInfo#45781
01da59cd  call     0x4e0a50 ; il2cpp_init_metadata
01da59d2  mov      byte ptr [rip + 0x28bde35], 1 ; [466380e] bss
01da59d9  mov      ecx, dword ptr [rbx + 0x1ec]
01da59df  test     ecx, ecx
01da59e1  je       0x1da5c35
01da59e7  sub      ecx, 1
01da59ea  je       0x1da5bc1
01da59f0  sub      ecx, 1
01da59f3  je       0x1da5abe
01da59f9  cmp      ecx, 1
01da59fc  jne      0x1da5bb6
01da5a02  xor      edx, edx
01da5a04  mov      rcx, rbx
01da5a07  call     0x1db9a20 ; Single Enemy.Ene_BosBase::GetDirectionRate()
01da5a0c  movss    xmm1, dword ptr [rip + 0x173b1b8] ; [34e0bcc] f=1.0 d=50.12387841939926 v4=(1.0, 3.141593, 4.0, 10.0)
01da5a14  comiss   xmm1, xmm0
01da5a17  jbe      0x1da5a4c
01da5a19  cmp      byte ptr [rbx + 0x1b7], 0
01da5a20  jne      0x1da5a4c
01da5a22  cmp      byte ptr [rbx + 0x1b5], 0
01da5a29  je       0x1da5a35
01da5a2b  movss    xmm1, dword ptr [rip + 0x184d429] ; [35f2e5c] f=480.0 d=-2.0463635835560273e-13 v4=(480.0, -0.05, -0.12, -4.5)
01da5a33  jmp      0x1da5a3d
01da5a35  movss    xmm1, dword ptr [rip + 0x184d443] ; [35f2e80] f=-480.0 d=1.9720004315949918e-24 v4=(-480.0, 0.002, 0.005, 0.08)
01da5a3d  mulss    xmm1, xmm6
01da5a41  xor      r8d, r8d
01da5a44  mov      rcx, rbx
01da5a47  call     0x1da0fa0 ; Void Enemy.Ene_Bos07::FaceCoverRotate(Single)
01da5a4c  movss    xmm1, dword ptr [rbx + 0x274]
01da5a54  xorps    xmm0, xmm0
01da5a57  subss    xmm1, xmm6
01da5a5b  comiss   xmm0, xmm1
01da5a5e  movss    dword ptr [rbx + 0x274], xmm1
01da5a66  jb       0x1da5bb6
01da5a6c  mov      rcx, qword ptr [rip + 0x25fc8f5] ; [43a2368] TypeInfo#45781
01da5a73  cmp      dword ptr [rcx + 0xe4], 0
01da5a7a  jne      0x1da5a81
01da5a7c  call     0x4e0d90 ; il2cpp_class_init
01da5a81  xor      edx, edx
01da5a83  mov      ecx, 0x56
01da5a88  call     0x2723de0 ; Void TXEKernel.Sound.SoundUtility::PlayQue(TXEKernel.Sound.SoundUtility/ID)
01da5a8d  xor      r8d, r8d
01da5a90  mov      edx, 0x22
01da5a95  mov      rcx, rbx
01da5a98  call     0x1ccf500 ; Void InGameCollisionBase::ResetObjectFlag(InGameObject/InGameObjectFlag)
01da5a9d  xor      r8d, r8d
01da5aa0  mov      dl, 1
01da5aa2  mov      rcx, rbx
01da5aa5  call     0x1dba430 ; Void Enemy.Ene_BosBase::ResetBossTimer(Boolean)
01da5aaa  xor      edx, edx
01da5aac  mov      rcx, rbx
01da5aaf  movaps   xmm6, xmmword ptr [rsp + 0x40]
01da5ab4  add      rsp, 0x50
01da5ab8  pop      rbx
01da5ab9  jmp      0x1da0d30 ; Void Enemy.Ene_Bos07::CheckNextState()
01da5abe  mov      rax, qword ptr [rbx + 0xb8]
01da5ac5  mov      qword ptr [rsp + 0x60], rsi
01da5aca  mov      qword ptr [rsp + 0x68], rdi
01da5acf  test     rax, rax
01da5ad2  je       0x1da5c75
01da5ad8  cmp      byte ptr [rax + 0x2b8], 0
01da5adf  je       0x1da5bac
01da5ae5  xor      r8d, r8d
01da5ae8  mov      dl, 1
01da5aea  mov      rcx, rax
01da5aed  call     0x1d1d5a0 ; Void InGameObjectBase::StopAnime(Boolean)
01da5af2  cmp      byte ptr [rip + 0x28b6964], 0 ; [465c45d] bss
01da5af9  mov      rdi, qword ptr [rbx + 0x168]
01da5b00  jne      0x1da5b15
01da5b02  lea      rcx, [rip + 0x261bbcf] ; [43c16d8] TypeInfo#48704
01da5b09  call     0x4e0a50 ; il2cpp_init_metadata
01da5b0e  mov      byte ptr [rip + 0x28b6948], 1 ; [465c45d] bss
01da5b15  mov      rax, qword ptr [rip + 0x261bbbc] ; [43c16d8] TypeInfo#48704
01da5b1c  lea      rdx, [rsp + 0x20]
01da5b21  xor      r8d, r8d
01da5b24  mov      dword ptr [rsp + 0x20], 0
01da5b2c  mov      qword ptr [rsp + 0x24], 0x40490fdb
01da5b35  mov      rcx, qword ptr [rax + 0xb8]
01da5b3c  movsd    xmm6, qword ptr [rcx]
01da5b40  mov      esi, dword ptr [rcx + 8]
01da5b43  lea      rcx, [rsp + 0x30]
01da5b48  call     0x304d890 ; Quaternion Quaternion::Internal_FromEulerRad(Vector3&)
01da5b4d  test     rdi, rdi
01da5b50  je       0x1da5c75
01da5b56  movups   xmm0, xmmword ptr [rax]
01da5b59  xor      r9d, r9d
01da5b5c  lea      r8, [rsp + 0x30]
01da5b61  lea      rdx, [rsp + 0x20]
01da5b66  movsd    qword ptr [rsp + 0x20], xmm6
01da5b6c  mov      rcx, rdi
01da5b6f  movaps   xmmword ptr [rsp + 0x30], xmm0
01da5b74  mov      dword ptr [rsp + 0x28], esi
01da5b78  call     0x30913c0 ; Void Transform::SetLocalPositionAndRotation(Vector3,Quaternion)
01da5b7d  movss    xmm2, dword ptr [rip + 0x173b047] ; [34e0bcc] f=1.0 d=50.12387841939926 v4=(1.0, 3.141593, 4.0, 10.0)
01da5b85  xor      r9d, r9d
01da5b88  movss    xmm1, dword ptr [rip + 0x173b038] ; [34e0bc8] f=0.5 d=0.007812501833541319 v4=(0.5, 1.0, 3.141593, 4.0)
01da5b90  mov      rcx, rbx
01da5b93  call     0x1dba4d0 ; Void Enemy.Ene_BosBase::SetDirectionTime(Single,Single)
01da5b98  mov      dword ptr [rbx + 0x274], 0x3f800000
01da5ba2  mov      dword ptr [rbx + 0x1ec], 3
01da5bac  mov      rsi, qword ptr [rsp + 0x60]
01da5bb1  mov      rdi, qword ptr [rsp + 0x68]
01da5bb6  movaps   xmm6, xmmword ptr [rsp + 0x40]
01da5bbb  add      rsp, 0x50
01da5bbf  pop      rbx
01da5bc0  ret      
01da5bc1  addss    xmm6, dword ptr [rbx + 0x274]
01da5bc9  movss    dword ptr [rbx + 0x274], xmm6
01da5bd1  mov      rax, qword ptr [rip + 0x260bfa0] ; [43b1b78] TypeInfo#37312
01da5bd8  cmp      dword ptr [rax + 0xe4], 0
01da5bdf  jne      0x1da5bf0
01da5be1  mov      rcx, rax
01da5be4  call     0x4e0d90 ; il2cpp_class_init
01da5be9  mov      rax, qword ptr [rip + 0x260bf88] ; [43b1b78] TypeInfo#37312
01da5bf0  mov      rax, qword ptr [rax + 0xb8]
01da5bf7  comiss   xmm6, dword ptr [rax + 0xc4]
01da5bfe  jb       0x1da5bb6
01da5c00  xor      r8d, r8d
01da5c03  mov      edx, 1
01da5c08  mov      rcx, rbx
01da5c0b  call     0x1ccf500 ; Void InGameCollisionBase::ResetObjectFlag(InGameObject/InGameObjectFlag)
01da5c10  xor      r8d, r8d
01da5c13  mov      edx, 0x22
01da5c18  mov      rcx, rbx
01da5c1b  call     0x1ccf580 ; Void InGameCollisionBase::SetObjectFlag(InGameObject/InGameObjectFlag)
01da5c20  mov      dword ptr [rbx + 0x1ec], 2
01da5c2a  movaps   xmm6, xmmword ptr [rsp + 0x40]
01da5c2f  add      rsp, 0x50
01da5c33  pop      rbx
01da5c34  ret      
01da5c35  mov      rcx, qword ptr [rip + 0x25fc72c] ; [43a2368] TypeInfo#45781
01da5c3c  cmp      dword ptr [rcx + 0xe4], 0
01da5c43  jne      0x1da5c4a
01da5c45  call     0x4e0d90 ; il2cpp_class_init
01da5c4a  xor      edx, edx
01da5c4c  mov      ecx, 0x55
01da5c51  call     0x2723de0 ; Void TXEKernel.Sound.SoundUtility::PlayQue(TXEKernel.Sound.SoundUtility/ID)
01da5c56  movaps   xmm6, xmmword ptr [rsp + 0x40]
01da5c5b  mov      dword ptr [rbx + 0x274], 0
01da5c65  mov      dword ptr [rbx + 0x1ec], 1
01da5c6f  add      rsp, 0x50
01da5c73  pop      rbx
01da5c74  ret      
01da5c75  call     0x4e0d00 ; ThrowNullRef
01da5c7a  int3     
01da5c7b  int3     
01da5c7c  int3     
01da5c7d  int3     
01da5c7e  int3     
01da5c7f  int3     

### Void Enemy.Ene_Bos07::PatternMove2(Single)  RVA=0x1DA2A70 len=0x6D0
01da2a70  push     rbx
01da2a72  sub      rsp, 0x70
01da2a76  cmp      byte ptr [rip + 0x28c0d92], 0 ; [466380f] bss
01da2a7d  mov      rbx, rcx
01da2a80  movaps   xmmword ptr [rsp + 0x60], xmm6
01da2a85  movaps   xmm6, xmm1
01da2a88  jne      0x1da2a9d
01da2a8a  lea      rcx, [rip + 0x260f0e7] ; [43b1b78] TypeInfo#37312
01da2a91  call     0x4e0a50 ; il2cpp_init_metadata
01da2a96  mov      byte ptr [rip + 0x28c0d72], 1 ; [466380f] bss
01da2a9d  mov      qword ptr [rsp + 0x80], rbp
01da2aa5  xor      edx, edx
01da2aa7  movaps   xmmword ptr [rsp + 0x50], xmm7
01da2aac  mov      rcx, rbx
01da2aaf  movaps   xmmword ptr [rsp + 0x40], xmm8
01da2ab5  call     0x1da1f10 ; Boolean Enemy.Ene_Bos07::IsLegBrokenOrDifficultyUp()
01da2aba  test     al, al
01da2abc  jne      0x1da30d4
01da2ac2  movss    xmm0, dword ptr [rbx + 0x274]
01da2aca  mov      eax, dword ptr [rbx + 0x1ec]
01da2ad0  subss    xmm0, xmm6
01da2ad4  movss    dword ptr [rbx + 0x274], xmm0
01da2adc  test     eax, eax
01da2ade  jne      0x1da2b9d
01da2ae4  mov      edx, 1
01da2ae9  xor      r9d, r9d
01da2aec  mov      r8d, edx
01da2aef  mov      rcx, rbx
01da2af2  call     0x1da6240 ; Void Enemy.Ene_Bos07::SetupLegPattern(Enemy.Ene_Bos07/LegPattern,Enemy.Ene_Bos07/LegPattern)
01da2af7  mov      rax, qword ptr [rip + 0x260f07a] ; [43b1b78] TypeInfo#37312
01da2afe  cmp      dword ptr [rax + 0xe4], 0
01da2b05  jne      0x1da2b16
01da2b07  mov      rcx, rax
01da2b0a  call     0x4e0d90 ; il2cpp_class_init
01da2b0f  mov      rax, qword ptr [rip + 0x260f062] ; [43b1b78] TypeInfo#37312
01da2b16  mov      rax, qword ptr [rax + 0xb8]
01da2b1d  xor      r9d, r9d
01da2b20  movss    xmm2, dword ptr [rip + 0x173e0a4] ; [34e0bcc] f=1.0 d=50.12387841939926 v4=(1.0, 3.141593, 4.0, 10.0)
01da2b28  mov      rcx, rbx
01da2b2b  movss    xmm1, dword ptr [rax + 0xe0]
01da2b33  call     0x1dba4d0 ; Void Enemy.Ene_BosBase::SetDirectionTime(Single,Single)
01da2b38  mov      rdx, qword ptr [rbx + 0x50]
01da2b3c  xor      eax, eax
01da2b3e  mov      dword ptr [rbx + 0x1ec], 1
01da2b48  mov      dword ptr [rbx + 0x310], eax
01da2b4e  mov      dword ptr [rbx + 0x274], eax
01da2b54  test     rdx, rdx
01da2b57  je       0x1da3117
01da2b5d  xor      r8d, r8d
01da2b60  lea      rcx, [rsp + 0x20]
01da2b65  call     0x3093700 ; Vector3 Transform::get_localPosition()
01da2b6a  movsd    xmm0, qword ptr [rax]
01da2b6e  mov      ecx, dword ptr [rax + 8]
01da2b71  movsd    qword ptr [rbx + 0x340], xmm0
01da2b79  mov      dword ptr [rbx + 0x348], ecx
01da2b7f  movaps   xmm8, xmmword ptr [rsp + 0x40]
01da2b85  movaps   xmm7, xmmword ptr [rsp + 0x50]
01da2b8a  mov      rbp, qword ptr [rsp + 0x80]
01da2b92  movaps   xmm6, xmmword ptr [rsp + 0x60]
01da2b97  add      rsp, 0x70
01da2b9b  pop      rbx
01da2b9c  ret      
01da2b9d  cmp      eax, 1
01da2ba0  jne      0x1da2d30
01da2ba6  mov      qword ptr [rsp + 0x88], rsi
01da2bae  mov      qword ptr [rsp + 0x90], rdi
01da2bb6  movaps   xmmword ptr [rsp + 0x30], xmm9
01da2bbc  xor      edx, edx
01da2bbe  mov      rcx, rbx
01da2bc1  call     0x1db9a20 ; Single Enemy.Ene_BosBase::GetDirectionRate()
01da2bc6  xor      r8d, r8d
01da2bc9  movaps   xmm1, xmm0
01da2bcc  mov      rcx, rbx
01da2bcf  movaps   xmm9, xmm0
01da2bd3  call     0x1da5f60 ; Void Enemy.Ene_Bos07::ProgressLegPattern(Single)
01da2bd8  comiss   xmm9, dword ptr [rip + 0x173dfec] ; [34e0bcc] f=1.0 d=50.12387841939926 v4=(1.0, 3.141593, 4.0, 10.0)
01da2be0  jb       0x1da2c5b
01da2be2  mov      rax, qword ptr [rip + 0x260ef8f] ; [43b1b78] TypeInfo#37312
01da2be9  cmp      dword ptr [rax + 0xe4], 0
01da2bf0  jne      0x1da2c01
01da2bf2  mov      rcx, rax
01da2bf5  call     0x4e0d90 ; il2cpp_class_init
01da2bfa  mov      rax, qword ptr [rip + 0x260ef77] ; [43b1b78] TypeInfo#37312
01da2c01  mov      rax, qword ptr [rax + 0xb8]
01da2c08  xor      r8d, r8d
01da2c0b  mov      rcx, rbx
01da2c0e  movss    xmm1, dword ptr [rax + 0xe4]
01da2c16  call     0x1dba580 ; Void Enemy.Ene_BosBase::SetRepeatTime(Single)
01da2c1b  mov      rax, qword ptr [rip + 0x260ef56] ; [43b1b78] TypeInfo#37312
01da2c22  movsd    xmm0, qword ptr [rbx + 0x228]
01da2c2a  mov      rcx, qword ptr [rax + 0xb8]
01da2c31  mov      eax, dword ptr [rcx + 0xe8]
01da2c37  mov      dword ptr [rbx + 0x274], eax
01da2c3d  mov      eax, dword ptr [rbx + 0x230]
01da2c43  movsd    qword ptr [rbx + 0x340], xmm0
01da2c4b  mov      dword ptr [rbx + 0x348], eax
01da2c51  mov      dword ptr [rbx + 0x1ec], 0xa
01da2c5b  movsd    xmm8, qword ptr [rbx + 0x340]
01da2c64  xor      edx, edx
01da2c66  mov      esi, dword ptr [rbx + 0x348]
01da2c6c  movaps   xmm0, xmm9
01da2c70  mov      rbp, qword ptr [rbx + 0x50]
01da2c74  movaps   xmm7, xmm8
01da2c78  movsd    xmm6, qword ptr [rbx + 0x228]
01da2c80  mov      edi, esi
01da2c82  mov      ebx, dword ptr [rbx + 0x230]
01da2c88  call     0x1de86f0 ; Single KANAI.Kernel.EasingUtility::InOutSine01(Single)
01da2c8d  movaps   xmm9, xmmword ptr [rsp + 0x30]
01da2c93  movaps   xmm2, xmm0
01da2c96  mov      rdi, qword ptr [rsp + 0x90]
01da2c9e  movaps   xmm1, xmm7
01da2ca1  shufps   xmm1, xmm1, 0x55
01da2ca5  movaps   xmm0, xmm8
01da2ca9  shufps   xmm0, xmm0, 0x55
01da2cad  movaps   xmm3, xmm6
01da2cb0  shufps   xmm3, xmm3, 0x55
01da2cb4  movaps   xmm4, xmm6
01da2cb7  movsd    qword ptr [rsp + 0x20], xmm6
01da2cbd  subss    xmm3, xmm1
01da2cc1  movd     xmm1, ebx
01da2cc5  subss    xmm4, xmm7
01da2cc9  movsd    qword ptr [rsp + 0x20], xmm7
01da2ccf  movsd    qword ptr [rsp + 0x20], xmm8
01da2cd6  mulss    xmm3, xmm2
01da2cda  mulss    xmm4, xmm2
01da2cde  addss    xmm3, xmm0
01da2ce2  movd     xmm0, esi
01da2ce6  subss    xmm1, xmm0
01da2cea  movd     xmm0, esi
01da2cee  mov      rsi, qword ptr [rsp + 0x88]
01da2cf6  addss    xmm4, xmm8
01da2cfb  mulss    xmm1, xmm2
01da2cff  addss    xmm1, xmm0
01da2d03  test     rbp, rbp
01da2d06  je       0x1da3117
01da2d0c  unpcklps xmm4, xmm3
01da2d0f  lea      rdx, [rsp + 0x20]
01da2d14  xor      r8d, r8d
01da2d17  movsd    qword ptr [rsp + 0x20], xmm4
01da2d1d  mov      rcx, rbp
01da2d20  movss    dword ptr [rsp + 0x28], xmm1
01da2d26  call     0x3094570 ; Void Transform::set_localPosition(Vector3)
01da2d2b  jmp      0x1da2b7f
01da2d30  cmp      eax, 0xa
01da2d33  jne      0x1da2b7f
01da2d39  xor      r8d, r8d
01da2d3c  movaps   xmm1, xmm6
01da2d3f  mov      rcx, rbx
01da2d42  call     0x1da1560 ; Void Enemy.Ene_Bos07::HomingLeg(Single)
01da2d47  mov      rcx, qword ptr [rip + 0x260ee2a] ; [43b1b78] TypeInfo#37312
01da2d4e  movss    xmm6, dword ptr [rbx + 0x274]
01da2d56  cmp      dword ptr [rcx + 0xe4], 0
01da2d5d  jne      0x1da2d64
01da2d5f  call     0x4e0d90 ; il2cpp_class_init
01da2d64  mov      rcx, qword ptr [rip + 0x260ee0d] ; [43b1b78] TypeInfo#37312
01da2d6b  movss    xmm7, dword ptr [rip + 0x173de59] ; [34e0bcc] f=1.0 d=50.12387841939926 v4=(1.0, 3.141593, 4.0, 10.0)
01da2d73  mov      rax, qword ptr [rcx + 0xb8]
01da2d7a  movss    xmm0, dword ptr [rax + 0xe8]
01da2d82  subss    xmm0, xmm7
01da2d86  comiss   xmm0, xmm6
01da2d89  jbe      0x1da2dec
01da2d8b  cmp      dword ptr [rcx + 0xe4], 0
01da2d92  movss    xmm6, dword ptr [rbx + 0x310]
01da2d9a  jne      0x1da2da1
01da2d9c  call     0x4e0d90 ; il2cpp_class_init
01da2da1  mov      rax, qword ptr [rip + 0x260edd0] ; [43b1b78] TypeInfo#37312
01da2da8  mov      rcx, qword ptr [rax + 0xb8]
01da2daf  movd     xmm0, dword ptr [rcx + 0xec]
01da2db7  cvtdq2ps xmm0, xmm0
01da2dba  comiss   xmm0, xmm6
01da2dbd  jbe      0x1da2dec
01da2dbf  cmp      byte ptr [rbx + 0x1dc], 0
01da2dc6  je       0x1da2dec
01da2dc8  xor      r9d, r9d
01da2dcb  xor      r8d, r8d
01da2dce  mov      dl, 1
01da2dd0  mov      rcx, rbx
01da2dd3  call     0x1da0910 ; Void Enemy.Ene_Bos07::BCFire(Boolean,Boolean)
01da2dd8  movss    xmm0, dword ptr [rbx + 0x310]
01da2de0  addss    xmm0, xmm7
01da2de4  movss    dword ptr [rbx + 0x310], xmm0
01da2dec  xorps    xmm8, xmm8
01da2df0  comiss   xmm8, dword ptr [rbx + 0x274]
01da2df8  jb       0x1da302e
01da2dfe  cmp      dword ptr [rbx + 0x270], 0x64
01da2e05  je       0x1da302e
01da2e0b  xor      edx, edx
01da2e0d  mov      rcx, rbx
01da2e10  call     0x1da1cf0 ; Boolean Enemy.Ene_Bos07::IsArmBrokenOrDifficultyUp()
01da2e15  test     al, al
01da2e17  jne      0x1da2fea
01da2e1d  cmp      byte ptr [rbx + 0x302], al
01da2e23  je       0x1da2e30
01da2e25  mov      ecx, dword ptr [rbx + 0x270]
01da2e2b  jmp      0x1da2ee2
01da2e30  xor      r8d, r8d
01da2e33  mov      edx, 1
01da2e38  mov      rcx, rbx
01da2e3b  call     0x1d0da10 ; Enemy.EnePartsGroup Enemy.PawnEnemy::GetParts(Int32)
01da2e40  test     rax, rax
01da2e43  je       0x1da3117
01da2e49  cmp      byte ptr [rax + 0x9a], 0
01da2e50  je       0x1da2e74
01da2e52  xor      r8d, r8d
01da2e55  mov      edx, 2
01da2e5a  mov      rcx, rbx
01da2e5d  call     0x1d0da10 ; Enemy.EnePartsGroup Enemy.PawnEnemy::GetParts(Int32)
01da2e62  test     rax, rax
01da2e65  je       0x1da3117
01da2e6b  cmp      byte ptr [rax + 0x9a], 0
01da2e72  jne      0x1da2e88
01da2e74  xor      r8d, r8d
01da2e77  mov      edx, 3
01da2e7c  mov      rcx, rbx
01da2e7f  call     0x1db9fd0 ; Boolean Enemy.Ene_BosBase::IsOverHP(Enemy.Ene_BosBase/HitPState)
01da2e84  test     al, al
01da2e86  je       0x1da2ec8
01da2e88  mov      ecx, dword ptr [rbx + 0x270]
01da2e8e  cmp      ecx, 6
01da2e91  je       0x1da2ea5
01da2e93  xor      eax, eax
01da2e95  mov      dword ptr [rbx + 0x270], 6
01da2e9f  mov      dword ptr [rbx + 0x1ec], eax
01da2ea5  mov      rax, qword ptr [rbx + 0xb8]
01da2eac  test     rax, rax
01da2eaf  je       0x1da3117
01da2eb5  mov      byte ptr [rax + 0x1d4], 0
01da2ebc  mov      byte ptr [rbx + 0x302], 1
01da2ec3  jmp      0x1da3025
01da2ec8  xor      r8d, r8d
01da2ecb  mov      edx, 9
01da2ed0  mov      rcx, rbx
01da2ed3  call     0x1db9fe0 ; Boolean Enemy.Ene_BosBase::IsOverStep(Enemy.Ene_BosBase/TimeSteps)
01da2ed8  mov      ecx, dword ptr [rbx + 0x270]
01da2ede  test     al, al
01da2ee0  jne      0x1da2e8e
01da2ee2  cmp      ecx, 6
01da2ee5  ja       0x1da2fba
01da2eeb  movsxd   rax, ecx
01da2eee  lea      rdx, [rip - 0x1da2ef5]
01da2ef5  mov      ecx, dword ptr [rdx + rax*4 + 0x1da3120] ; JT 1da2f01,1da2f1f,1da2f01,1da2f8c,1da2fa3,1da2fba,1da2f8c,cccccccc,81485340,c0ec,c33d8000,28c06
01da2efc  add      rcx, rdx
01da2eff  jmp      rcx
01da2f01  cmp      dword ptr [rbx + 0x270], 1
01da2f08  je       0x1da2fd1
01da2f0e  mov      dword ptr [rbx + 0x270], 1
01da2f18  xor      eax, eax
01da2f1a  jmp      0x1da2fcb
01da2f1f  cmp      dword ptr [rbx + 0x270], 2
01da2f26  je       0x1da2fd1
01da2f2c  xor      eax, eax
01da2f2e  mov      dword ptr [rbx + 0x270], 2
01da2f38  xor      r8d, r8d
01da2f3b  mov      dword ptr [rbx + 0x1ec], eax
01da2f41  mov      edx, 1
01da2f46  mov      rcx, rbx
01da2f49  call     0x1d0da10 ; Enemy.EnePartsGroup Enemy.PawnEnemy::GetParts(Int32)
01da2f4e  test     rax, rax
01da2f51  je       0x1da3117
01da2f57  movzx    eax, byte ptr [rax + 0x9a]
01da2f5e  xor      r8d, r8d
01da2f61  mov      edx, 2
01da2f66  mov      byte ptr [rbx + 0x304], al
01da2f6c  mov      rcx, rbx
01da2f6f  call     0x1d0da10 ; Enemy.EnePartsGroup Enemy.PawnEnemy::GetParts(Int32)
01da2f74  test     rax, rax
01da2f77  je       0x1da3117
01da2f7d  movzx    eax, byte ptr [rax + 0x9a]
01da2f84  mov      byte ptr [rbx + 0x305], al
01da2f8a  jmp      0x1da2fd1
01da2f8c  cmp      dword ptr [rbx + 0x270], 3
01da2f93  je       0x1da2fd1
01da2f95  mov      dword ptr [rbx + 0x270], 3
01da2f9f  xor      eax, eax
01da2fa1  jmp      0x1da2fcb
01da2fa3  cmp      dword ptr [rbx + 0x270], 5
01da2faa  je       0x1da2fd1
01da2fac  mov      dword ptr [rbx + 0x270], 5
01da2fb6  xor      eax, eax
01da2fb8  jmp      0x1da2fcb
01da2fba  cmp      dword ptr [rbx + 0x270], 0
01da2fc1  je       0x1da2fd1
01da2fc3  xor      eax, eax
01da2fc5  mov      dword ptr [rbx + 0x270], eax
01da2fcb  mov      dword ptr [rbx + 0x1ec], eax
01da2fd1  mov      rax, qword ptr [rbx + 0xb8]
01da2fd8  test     rax, rax
01da2fdb  je       0x1da3117
01da2fe1  mov      byte ptr [rax + 0x1d4], 0
01da2fe8  jmp      0x1da302e
01da2fea  cmp      dword ptr [rbx + 0x270], 4
01da2ff1  je       0x1da3005
01da2ff3  xor      eax, eax
01da2ff5  mov      dword ptr [rbx + 0x270], 4
01da2fff  mov      dword ptr [rbx + 0x1ec], eax
01da3005  mov      rax, qword ptr [rbx + 0xb8]
01da300c  test     rax, rax
01da300f  je       0x1da3117
01da3015  mov      byte ptr [rax + 0x1d4], 0
01da301c  mov      word ptr [rbx + 0x302], 0x101
01da3025  mov      word ptr [rbx + 0x314], 0
01da302e  mov      rcx, qword ptr [rip + 0x260eb43] ; [43b1b78] TypeInfo#37312
01da3035  movss    xmm6, dword ptr [rbx + 0x274]
01da303d  cmp      dword ptr [rcx + 0xe4], 0
01da3044  jne      0x1da304b
01da3046  call     0x4e0d90 ; il2cpp_class_init
01da304b  mov      rax, qword ptr [rip + 0x260eb26] ; [43b1b78] TypeInfo#37312
01da3052  mov      rcx, qword ptr [rax + 0xb8]
01da3059  divss    xmm6, dword ptr [rcx + 0xe8]
01da3061  comiss   xmm8, xmm6
01da3065  ja       0x1da3071
01da3067  comiss   xmm6, xmm7
01da306a  jbe      0x1da3074
01da306c  movaps   xmm6, xmm7
01da306f  jmp      0x1da3074
01da3071  xorps    xmm6, xmm6
01da3074  xor      edx, edx
01da3076  movaps   xmm0, xmm6
01da3079  call     0x1de8650 ; Single KANAI.Kernel.EasingUtility::InOutQuad01(Single)
01da307e  cmp      byte ptr [rip + 0x28b93d8], 0 ; [465c45d] bss
01da3085  movaps   xmm6, xmm0
01da3088  jne      0x1da309d
01da308a  lea      rcx, [rip + 0x261e647] ; [43c16d8] TypeInfo#48704
01da3091  call     0x4e0a50 ; il2cpp_init_metadata
01da3096  mov      byte ptr [rip + 0x28b93c0], 1 ; [465c45d] bss
01da309d  mov      rax, qword ptr [rip + 0x261e634] ; [43c16d8] TypeInfo#48704
01da30a4  lea      r8, [rsp + 0x20]
01da30a9  xor      r9d, r9d
01da30ac  mov      rcx, rbx
01da30af  mov      rax, qword ptr [rax + 0xb8]
01da30b6  movsd    xmm1, qword ptr [rax]
01da30ba  mov      eax, dword ptr [rax + 8]
01da30bd  movsd    qword ptr [rsp + 0x20], xmm1
01da30c3  movaps   xmm1, xmm6
01da30c6  mov      dword ptr [rsp + 0x28], eax
01da30ca  call     0x1da0bf0 ; Void Enemy.Ene_Bos07::BCMove(Single,Vector3)
01da30cf  jmp      0x1da2b7f
01da30d4  cmp      dword ptr [rbx + 0x270], 6
01da30db  je       0x1da30ef
01da30dd  xor      eax, eax
01da30df  mov      dword ptr [rbx + 0x270], 6
01da30e9  mov      dword ptr [rbx + 0x1ec], eax
01da30ef  mov      rax, qword ptr [rbx + 0xb8]
01da30f6  test     rax, rax
01da30f9  je       0x1da3117
01da30fb  mov      byte ptr [rax + 0x1d4], 0
01da3102  mov      byte ptr [rbx + 0x302], 1
01da3109  mov      word ptr [rbx + 0x314], 0
01da3112  jmp      0x1da2b7f
01da3117  call     0x4e0d00 ; ThrowNullRef
01da311c  int3     
01da311d  nop      dword ptr [rax]
01da3120  add      dword ptr [rdi], ebp
01da3122  fiadd    dword ptr [rcx]
01da3126  fiadd    dword ptr [rcx]
01da3128  add      dword ptr [rdi], ebp
01da312a  fiadd    dword ptr [rcx]
01da312c  mov      word ptr [rdi], gs
01da312e  fiadd    dword ptr [rcx]
01da3130  movabs   dword ptr [0x8c01da2fba01da2f], eax
01da313a  fiadd    dword ptr [rcx]
01da313c  int3     
01da313d  int3     
01da313e  int3     
01da313f  int3     

### Void Enemy.Ene_Bos07::BCFire(Boolean,Boolean)  RVA=0x1DA0910 len=0x2E0
01da0910  mov      qword ptr [rsp + 0x10], rbx
01da0915  mov      qword ptr [rsp + 0x18], rsi
01da091a  mov      qword ptr [rsp + 0x20], rdi
01da091f  push     r14
01da0921  sub      rsp, 0x80
01da0928  cmp      byte ptr [rip + 0x28c2ee1], 0 ; [4663810] bss
01da092f  movzx    esi, r8b
01da0933  movaps   xmmword ptr [rsp + 0x70], xmm6
01da0938  movzx    edi, dl
01da093b  mov      rbx, rcx
01da093e  jne      0x1da096b
01da0940  lea      rcx, [rip + 0x25f4b89] ; [43954d0] STR 'leg60'
01da0947  call     0x4e0a50 ; il2cpp_init_metadata
01da094c  lea      rcx, [rip + 0x25f4abd] ; [4395410] STR 'leg40'
01da0953  call     0x4e0a50 ; il2cpp_init_metadata
01da0958  lea      rcx, [rip + 0x25f4ce9] ; [4395648] STR 'legsub'
01da095f  call     0x4e0a50 ; il2cpp_init_metadata
01da0964  mov      byte ptr [rip + 0x28c2ea5], 1 ; [4663810] bss
01da096b  xor      r14d, r14d
01da096e  mov      qword ptr [rsp + 0x90], rbp
01da0976  xorps    xmm6, xmm6
01da0979  test     dil, dil
01da097c  je       0x1da0a20
01da0982  xor      r8d, r8d
01da0985  xor      edx, edx
01da0987  mov      rcx, rbx
01da098a  call     0x1db9840 ; Enemy.BulletTemplate Enemy.Ene_BosBase::GetBT(Int32)
01da098f  mov      rbp, qword ptr [rbx + 0xb8]
01da0996  xor      edx, edx
01da0998  mov      rcx, rbx
01da099b  mov      rdi, rax
01da099e  call     0x1d11bc0 ; Threading.CancellationToken Enemy.PawnEnemy::get_CToken()
01da09a3  test     rbp, rbp
01da09a6  je       0x1da0bd5
01da09ac  mov      rdx, qword ptr [rip + 0x25f4a5d] ; [4395410] STR 'leg40'
01da09b3  mov      r9b, 1
01da09b6  mov      qword ptr [rsp + 0x38], r14
01da09bb  mov      r8, rdi
01da09be  movss    dword ptr [rsp + 0x30], xmm6
01da09c4  mov      rcx, rbp
01da09c7  mov      qword ptr [rsp + 0x28], rdx
01da09cc  mov      rdx, rax
01da09cf  mov      byte ptr [rsp + 0x20], 1
01da09d4  call     0x1cd9150 ; Void InGameEnemyMoveBase::BulletFireByMuzzlePack(Threading.CancellationToken,Enemy.BulletTemplate,Boolean,Boolean,String,Single)
01da09d9  mov      rbp, qword ptr [rbx + 0xb8]
01da09e0  xor      edx, edx
01da09e2  mov      rcx, rbx
01da09e5  call     0x1d11bc0 ; Threading.CancellationToken Enemy.PawnEnemy::get_CToken()
01da09ea  test     rbp, rbp
01da09ed  je       0x1da0bd5
01da09f3  mov      rdx, qword ptr [rip + 0x25f4ad6] ; [43954d0] STR 'leg60'
01da09fa  mov      r9b, 1
01da09fd  mov      qword ptr [rsp + 0x38], r14
01da0a02  mov      r8, rdi
01da0a05  movss    dword ptr [rsp + 0x30], xmm6
01da0a0b  mov      rcx, rbp
01da0a0e  mov      qword ptr [rsp + 0x28], rdx
01da0a13  mov      rdx, rax
01da0a16  mov      byte ptr [rsp + 0x20], 1
01da0a1b  call     0x1cd9150 ; Void InGameEnemyMoveBase::BulletFireByMuzzlePack(Threading.CancellationToken,Enemy.BulletTemplate,Boolean,Boolean,String,Single)
01da0a20  test     sil, sil
01da0a23  je       0x1da0a88
01da0a25  xor      r8d, r8d
01da0a28  mov      rcx, rbx
01da0a2b  cmp      byte ptr [rbx + 0x302], r14b
01da0a32  jne      0x1da0aaf
01da0a34  mov      edx, 1
01da0a39  call     0x1db9840 ; Enemy.BulletTemplate Enemy.Ene_BosBase::GetBT(Int32)
01da0a3e  mov      rdi, qword ptr [rbx + 0xb8]
01da0a45  xor      edx, edx
01da0a47  mov      rcx, rbx
01da0a4a  mov      rsi, rax
01da0a4d  call     0x1d11bc0 ; Threading.CancellationToken Enemy.PawnEnemy::get_CToken()
01da0a52  test     rdi, rdi
01da0a55  je       0x1da0bd5
01da0a5b  mov      rdx, qword ptr [rip + 0x25f4be6] ; [4395648] STR 'legsub'
01da0a62  xor      r9d, r9d
01da0a65  mov      qword ptr [rsp + 0x38], r14
01da0a6a  mov      r8, rsi
01da0a6d  movss    dword ptr [rsp + 0x30], xmm6
01da0a73  mov      rcx, rdi
01da0a76  mov      qword ptr [rsp + 0x28], rdx
01da0a7b  mov      rdx, rax
01da0a7e  mov      byte ptr [rsp + 0x20], r14b
01da0a83  call     0x1cd9150 ; Void InGameEnemyMoveBase::BulletFireByMuzzlePack(Threading.CancellationToken,Enemy.BulletTemplate,Boolean,Boolean,String,Single)
01da0a88  mov      rbp, qword ptr [rsp + 0x90]
01da0a90  lea      r11, [rsp + 0x80]
01da0a98  mov      rbx, qword ptr [r11 + 0x18]
01da0a9c  mov      rsi, qword ptr [r11 + 0x20]
01da0aa0  mov      rdi, qword ptr [r11 + 0x28]
01da0aa4  movaps   xmm6, xmmword ptr [rsp + 0x70]
01da0aa9  mov      rsp, r11
01da0aac  pop      r14
01da0aae  ret      
01da0aaf  mov      edx, 5
01da0ab4  call     0x1db9840 ; Enemy.BulletTemplate Enemy.Ene_BosBase::GetBT(Int32)
01da0ab9  mov      rdi, qword ptr [rbx + 0xb8]
01da0ac0  xor      edx, edx
01da0ac2  mov      rcx, rbx
01da0ac5  mov      rsi, rax
01da0ac8  call     0x1d11bc0 ; Threading.CancellationToken Enemy.PawnEnemy::get_CToken()
01da0acd  mov      rcx, qword ptr [rbx + 0x280]
01da0ad4  test     rcx, rcx
01da0ad7  je       0x1da0bd5
01da0add  cmp      dword ptr [rcx + 0x18], 2
01da0ae1  jbe      0x1da0bdb
01da0ae7  test     rdi, rdi
01da0aea  je       0x1da0bd5
01da0af0  mov      rcx, qword ptr [rcx + 0x30]
01da0af4  mov      r9, rsi
01da0af7  movss    xmm0, dword ptr [rip + 0x18521e1] ; [35f2ce0] f=60.0 d=281475046375424.0 v4=(60.0, 120.0, 300.0, 720.0)
01da0aff  mov      r8, rax
01da0b02  mov      qword ptr [rsp + 0x58], r14
01da0b07  mov      rdx, rdi
01da0b0a  mov      qword ptr [rsp + 0x50], r14
01da0b0f  mov      dword ptr [rsp + 0x48], r14d
01da0b14  movss    dword ptr [rsp + 0x40], xmm0
01da0b1a  mov      qword ptr [rsp + 0x38], r14
01da0b1f  mov      qword ptr [rsp + 0x30], rcx
01da0b24  lea      rcx, [rsp + 0x60]
01da0b29  mov      byte ptr [rsp + 0x28], r14b
01da0b2e  mov      byte ptr [rsp + 0x20], r14b
01da0b33  call     0x1cd8fe0 ; Cysharp.Threading.Tasks.UniTask InGameEnemyMoveBase::BulletFireAsync(Threading.CancellationToken,Enemy.BulletTemplate,Boolean,Boolean,Transform,Transform,Single,Int32,Action`1<InGameBulletInterface>)
01da0b38  xor      edx, edx
01da0b3a  lea      rcx, [rsp + 0x60]
01da0b3f  movups   xmm0, xmmword ptr [rax]
01da0b42  movaps   xmmword ptr [rsp + 0x60], xmm0
01da0b47  call     0x2742890 ; Void Cysharp.Threading.Tasks.UniTaskExtensions::Forget(Cysharp.Threading.Tasks.UniTask)
01da0b4c  mov      rdi, qword ptr [rbx + 0xb8]
01da0b53  xor      edx, edx
01da0b55  mov      rcx, rbx
01da0b58  call     0x1d11bc0 ; Threading.CancellationToken Enemy.PawnEnemy::get_CToken()
01da0b5d  mov      rcx, qword ptr [rbx + 0x280]
01da0b64  test     rcx, rcx
01da0b67  je       0x1da0bd5
01da0b69  cmp      dword ptr [rcx + 0x18], 3
01da0b6d  jbe      0x1da0bdb
01da0b6f  mov      rdx, qword ptr [rcx + 0x38]
01da0b73  test     rdi, rdi
01da0b76  je       0x1da0bd5
01da0b78  movss    xmm0, dword ptr [rip + 0x1852270] ; [35f2df0] f=-60.0 d=-3848292290048.0 v4=(-60.0, -70.0, -80.0, 0.025)
01da0b80  lea      rcx, [rsp + 0x60]
01da0b85  mov      qword ptr [rsp + 0x58], r14
01da0b8a  mov      r9, rsi
01da0b8d  mov      qword ptr [rsp + 0x50], r14
01da0b92  mov      r8, rax
01da0b95  mov      dword ptr [rsp + 0x48], r14d
01da0b9a  movss    dword ptr [rsp + 0x40], xmm0
01da0ba0  mov      qword ptr [rsp + 0x38], r14
01da0ba5  mov      qword ptr [rsp + 0x30], rdx
01da0baa  mov      rdx, rdi
01da0bad  mov      byte ptr [rsp + 0x28], r14b
01da0bb2  mov      byte ptr [rsp + 0x20], r14b
01da0bb7  call     0x1cd8fe0 ; Cysharp.Threading.Tasks.UniTask InGameEnemyMoveBase::BulletFireAsync(Threading.CancellationToken,Enemy.BulletTemplate,Boolean,Boolean,Transform,Transform,Single,Int32,Action`1<InGameBulletInterface>)
01da0bbc  xor      edx, edx
01da0bbe  lea      rcx, [rsp + 0x60]
01da0bc3  movups   xmm0, xmmword ptr [rax]
01da0bc6  movaps   xmmword ptr [rsp + 0x60], xmm0
01da0bcb  call     0x2742890 ; Void Cysharp.Threading.Tasks.UniTaskExtensions::Forget(Cysharp.Threading.Tasks.UniTask)
01da0bd0  jmp      0x1da0a88
01da0bd5  call     0x4e0d00 ; ThrowNullRef
01da0bda  int3     
01da0bdb  call     0x4e0cf0 ; ?
01da0be0  int3     
01da0be1  int3     
01da0be2  int3     
01da0be3  int3     
01da0be4  int3     
01da0be5  int3     
01da0be6  int3     
01da0be7  int3     
01da0be8  int3     
01da0be9  int3     
01da0bea  int3     
01da0beb  int3     
01da0bec  int3     
01da0bed  int3     
01da0bee  int3     
01da0bef  int3     

### Void Enemy.Ene_Bos07::BCMove(Single,Vector3)  RVA=0x1DA0BF0 len=0x140
01da0bf0  mov      qword ptr [rsp + 8], rbx
01da0bf5  push     rdi
01da0bf6  sub      rsp, 0x60
01da0bfa  cmp      byte ptr [rip + 0x28bb85c], 0 ; [465c45d] bss
01da0c01  mov      rdi, r8
01da0c04  movaps   xmmword ptr [rsp + 0x50], xmm7
01da0c09  mov      rbx, rcx
01da0c0c  movaps   xmmword ptr [rsp + 0x40], xmm8
01da0c12  movaps   xmm8, xmm1
01da0c16  jne      0x1da0c2b
01da0c18  lea      rcx, [rip + 0x2620ab9] ; [43c16d8] TypeInfo#48704
01da0c1f  call     0x4e0a50 ; il2cpp_init_metadata
01da0c24  mov      byte ptr [rip + 0x28bb832], 1 ; [465c45d] bss
01da0c2b  mov      rax, qword ptr [rip + 0x2620aa6] ; [43c16d8] TypeInfo#48704
01da0c32  mov      rax, qword ptr [rax + 0xb8]
01da0c39  movsd    xmm0, qword ptr [rax]
01da0c3d  mov      eax, dword ptr [rax + 8]
01da0c40  movsd    qword ptr [rsp + 0x20], xmm0
01da0c46  movaps   xmm0, xmm8
01da0c4a  mulss    xmm0, dword ptr [rip + 0x173ff7e] ; [34e0bd0] f=3.1415927410125732 d=512.0001226146663 v4=(3.141593, 4.0, 10.0, 20.0)
01da0c52  mov      dword ptr [rsp + 0x28], eax
01da0c56  addss    xmm0, xmm0
01da0c5a  call     0x578040 ; sinf
01da0c5f  mulss    xmm8, dword ptr [rip + 0x173ff68] ; [34e0bd0] f=3.1415927410125732 d=512.0001226146663 v4=(3.141593, 4.0, 10.0, 20.0)
01da0c68  movaps   xmm7, xmm0
01da0c6b  mulss    xmm7, dword ptr [rip + 0x1851f41] ; [35f2bb4] f=30.0 d=34359746808.0 v4=(30.0, 40.0, 50.0, 99.900002)
01da0c73  addss    xmm8, xmm8
01da0c78  movaps   xmm0, xmm8
01da0c7c  call     0x576bf0 ; cosf
01da0c81  cmp      byte ptr [rbx + 0x2dc], 0
01da0c88  movaps   xmm3, xmm0
01da0c8b  mulss    xmm3, dword ptr [rip + 0x17401d5] ; [34e0e68] f=5.0 d=7.673846671558197e+21 v4=(5.0, 1000.0, 10.0, 10.0)
01da0c93  subss    xmm3, dword ptr [rip + 0x17401cd] ; [34e0e68] f=5.0 d=7.673846671558197e+21 v4=(5.0, 1000.0, 10.0, 10.0)
01da0c9b  je       0x1da0ca5
01da0c9d  mulss    xmm7, dword ptr [rip + 0x173ff4f] ; [34e0bf4] f=-1.0 d=1.58735232e-314 v4=(-1.0, 0.0, 0.0, 1.0)
01da0ca5  movsd    xmm1, qword ptr [rbx + 0x228]
01da0cad  movsd    xmm4, qword ptr [rdi]
01da0cb1  movaps   xmm0, xmm1
01da0cb4  movss    xmm2, dword ptr [rdi + 4]
01da0cb9  addss    xmm4, xmm1
01da0cbd  movss    xmm1, dword ptr [rdi + 8]
01da0cc2  addss    xmm1, dword ptr [rbx + 0x230]
01da0cca  mov      rcx, qword ptr [rbx + 0x50]
01da0cce  shufps   xmm0, xmm0, 0x55
01da0cd2  addss    xmm2, xmm0
01da0cd6  addss    xmm4, xmm7
01da0cda  addss    xmm1, xmm3
01da0cde  addss    xmm2, dword ptr [rsp + 0x24]
01da0ce4  test     rcx, rcx
01da0ce7  je       0x1da0d1b
01da0ce9  unpcklps xmm4, xmm2
01da0cec  lea      rdx, [rsp + 0x20]
01da0cf1  xor      r8d, r8d
01da0cf4  movsd    qword ptr [rsp + 0x20], xmm4
01da0cfa  movss    dword ptr [rsp + 0x28], xmm1
01da0d00  call     0x3094570 ; Void Transform::set_localPosition(Vector3)
01da0d05  mov      rbx, qword ptr [rsp + 0x70]
01da0d0a  movaps   xmm7, xmmword ptr [rsp + 0x50]
01da0d0f  movaps   xmm8, xmmword ptr [rsp + 0x40]
01da0d15  add      rsp, 0x60
01da0d19  pop      rdi
01da0d1a  ret      
01da0d1b  call     0x4e0d00 ; ThrowNullRef
01da0d20  int3     
01da0d21  int3     
01da0d22  int3     
01da0d23  int3     
01da0d24  int3     
01da0d25  int3     
01da0d26  int3     
01da0d27  int3     
01da0d28  int3     
01da0d29  int3     
01da0d2a  int3     
01da0d2b  int3     
01da0d2c  int3     
01da0d2d  int3     
01da0d2e  int3     
01da0d2f  int3     

### Void Enemy.Ene_Bos07::HomingLeg(Single)  RVA=0x1DA1560 len=0x2F0
01da1560  mov      qword ptr [rsp + 0x10], rbx
01da1565  mov      qword ptr [rsp + 0x18], rbp
01da156a  push     rdi
01da156b  sub      rsp, 0xa0
01da1572  cmp      byte ptr [rip + 0x28c2298], 0 ; [4663811] bss
01da1579  mov      rbx, rcx
01da157c  movaps   xmmword ptr [rsp + 0x80], xmm7
01da1584  movaps   xmm7, xmm1
01da1587  jne      0x1da159c
01da1589  lea      rcx, [rip + 0x2616a70] ; [43b8000] MethodRef#202981
01da1590  call     0x4e0a50 ; il2cpp_init_metadata
01da1595  mov      byte ptr [rip + 0x28c2275], 1 ; [4663811] bss
01da159c  xorps    xmm0, xmm0
01da159f  mov      qword ptr [rsp + 0x68], rbx
01da15a4  xor      ebp, ebp
01da15a6  lea      rcx, [rsp + 0x68]
01da15ab  mov      rdx, rbx
01da15ae  mov      qword ptr [rsp + 0x60], rbp
01da15b3  movdqu   xmmword ptr [rsp + 0x70], xmm0
01da15b9  call     0x4dfd80 ; ?
01da15be  mov      rax, qword ptr [rip + 0x2616a3b] ; [43b8000] MethodRef#202981
01da15c5  mov      rax, qword ptr [rax + 0x20]
01da15c9  test     byte ptr [rax + 0x135], 1
01da15d0  jne      0x1da15da
01da15d2  mov      rcx, rax
01da15d5  call     0x4de1e0 ; ?
01da15da  mov      rax, qword ptr [rax + 0xc0]
01da15e1  mov      rax, qword ptr [rax + 0x10]
01da15e5  test     byte ptr [rax + 0x135], 1
01da15ec  jne      0x1da15f6
01da15ee  mov      rcx, rax
01da15f1  call     0x4de1e0 ; ?
01da15f6  mov      rax, qword ptr [rax + 0xb8]
01da15fd  lea      rcx, [rsp + 0x60]
01da1602  mov      qword ptr [rsp + 0xb0], rsi
01da160a  movaps   xmmword ptr [rsp + 0x90], xmm6
01da1612  mov      rdx, qword ptr [rax]
01da1615  mov      qword ptr [rsp + 0x60], rdx
01da161a  call     0x4dfd80 ; ?
01da161f  mov      rdx, qword ptr [rbx + 0x50]
01da1623  mov      rdi, qword ptr [rsp + 0x60]
01da1628  test     rdx, rdx
01da162b  je       0x1da1838
01da1631  xor      r8d, r8d
01da1634  lea      rcx, [rsp + 0x50]
01da1639  call     0x3093ba0 ; Vector3 Transform::get_position()
01da163e  mov      rdx, qword ptr [rbx]
01da1641  mov      rcx, rbx
01da1644  movsd    xmm6, qword ptr [rax]
01da1648  mov      esi, dword ptr [rax + 8]
01da164b  mov      rax, qword ptr [rdx + 0x238]
01da1652  mov      rdx, qword ptr [rdx + 0x240]
01da1659  call     rax
01da165b  test     rdi, rdi
01da165e  je       0x1da1838
01da1664  xor      r9d, r9d
01da1667  movsd    qword ptr [rsp + 0x50], xmm6
01da166d  movzx    r8d, al
01da1671  mov      dword ptr [rsp + 0x58], esi
01da1675  lea      rdx, [rsp + 0x50]
01da167a  mov      qword ptr [rsp + 0x20], rbp
01da167f  mov      rcx, rdi
01da1682  call     0x1ce6470 ; Vector2 InGameManager::GetScreenPosition(Vector3,Boolean,Boolean)
01da1687  movq     xmm6, rax
01da168c  mov      rax, qword ptr [rip + 0x261696d] ; [43b8000] MethodRef#202981
01da1693  mov      rax, qword ptr [rax + 0x20]
01da1697  test     byte ptr [rax + 0x135], 1
01da169e  jne      0x1da16a8
01da16a0  mov      rcx, rax
01da16a3  call     0x4de1e0 ; ?
01da16a8  mov      rax, qword ptr [rax + 0xc0]
01da16af  mov      rax, qword ptr [rax + 0x10]
01da16b3  test     byte ptr [rax + 0x135], 1
01da16ba  jne      0x1da16c4
01da16bc  mov      rcx, rax
01da16bf  call     0x4de1e0 ; ?
01da16c4  mov      rax, qword ptr [rax + 0xb8]
01da16cb  mov      rcx, qword ptr [rax]
01da16ce  test     rcx, rcx
01da16d1  je       0x1da1838
01da16d7  xor      r8d, r8d
01da16da  movq     rdx, xmm6
01da16df  call     0x1ce4cb0 ; Int32 InGameManager::GetNearestPlayerIndex(Vector2)
01da16e4  mov      rdx, qword ptr [rsp + 0x60]
01da16e9  test     rdx, rdx
01da16ec  je       0x1da1838
01da16f2  xor      r9d, r9d
01da16f5  lea      rcx, [rsp + 0x50]
01da16fa  mov      r8d, eax
01da16fd  call     0x1ce5c90 ; Vector3 InGameManager::GetPlayerSkyPosition(Int32)
01da1702  xor      r8d, r8d
01da1705  mov      edx, 1
01da170a  mov      rcx, rbx
01da170d  xorps    xmm6, xmm6
01da1710  movsd    xmm0, qword ptr [rax]
01da1714  movsd    qword ptr [rsp + 0x70], xmm0
01da171a  mov      eax, dword ptr [rax + 8]
01da171d  mov      dword ptr [rsp + 0x78], eax
01da1721  mov      dword ptr [rsp + 0x74], ebp
01da1725  call     0x1d0da10 ; Enemy.EnePartsGroup Enemy.PawnEnemy::GetParts(Int32)
01da172a  test     rax, rax
01da172d  je       0x1da1838
01da1733  cmp      byte ptr [rax + 0x9a], bpl
01da173a  jne      0x1da1798
01da173c  mov      r8, qword ptr [rbx + 0x288]
01da1743  test     r8, r8
01da1746  je       0x1da1838
01da174c  cmp      dword ptr [r8 + 0x18], 2
01da1751  jbe      0x1da183e
01da1757  movss    xmm0, dword ptr [rip + 0x1851581] ; [35f2ce0] f=60.0 d=281475046375424.0 v4=(60.0, 120.0, 300.0, 720.0)
01da175f  lea      rax, [rsp + 0x60]
01da1764  mov      r9, qword ptr [r8 + 0x28]
01da1768  movaps   xmm1, xmm7
01da176b  mov      r8, qword ptr [r8 + 0x30]
01da176f  mov      rcx, rbx
01da1772  mov      qword ptr [rsp + 0x48], rbp
01da1777  mov      qword ptr [rsp + 0x40], rax
01da177c  movss    dword ptr [rsp + 0x38], xmm0
01da1782  movss    dword ptr [rsp + 0x30], xmm6
01da1788  mov      byte ptr [rsp + 0x28], 1
01da178d  movss    dword ptr [rsp + 0x20], xmm6
01da1793  call     0x1da6850 ; Void Enemy.Ene_Bos07::<HomingLeg>g__calc|125_0(Single,Transform,Transform,Single,Boolean,Single,Single,Enemy.Ene_Bos07/<>c__DisplayClass125_0&)
01da1798  xor      r8d, r8d
01da179b  mov      edx, 2
01da17a0  mov      rcx, rbx
01da17a3  call     0x1d0da10 ; Enemy.EnePartsGroup Enemy.PawnEnemy::GetParts(Int32)
01da17a8  test     rax, rax
01da17ab  je       0x1da1838
01da17b1  cmp      byte ptr [rax + 0x9a], bpl
01da17b8  jne      0x1da180e
01da17ba  mov      r8, qword ptr [rbx + 0x290]
01da17c1  test     r8, r8
01da17c4  je       0x1da1838
01da17c6  cmp      dword ptr [r8 + 0x18], 2
01da17cb  jbe      0x1da183e
01da17cd  movss    xmm0, dword ptr [rip + 0x185161b] ; [35f2df0] f=-60.0 d=-3848292290048.0 v4=(-60.0, -70.0, -80.0, 0.025)
01da17d5  lea      rax, [rsp + 0x60]
01da17da  mov      r9, qword ptr [r8 + 0x28]
01da17de  movaps   xmm1, xmm7
01da17e1  mov      r8, qword ptr [r8 + 0x30]
01da17e5  mov      rcx, rbx
01da17e8  mov      qword ptr [rsp + 0x48], rbp
01da17ed  mov      qword ptr [rsp + 0x40], rax
01da17f2  movss    dword ptr [rsp + 0x38], xmm6
01da17f8  movss    dword ptr [rsp + 0x30], xmm0
01da17fe  mov      byte ptr [rsp + 0x28], bpl
01da1803  movss    dword ptr [rsp + 0x20], xmm6
01da1809  call     0x1da6850 ; Void Enemy.Ene_Bos07::<HomingLeg>g__calc|125_0(Single,Transform,Transform,Single,Boolean,Single,Single,Enemy.Ene_Bos07/<>c__DisplayClass125_0&)
01da180e  movaps   xmm6, xmmword ptr [rsp + 0x90]
01da1816  lea      r11, [rsp + 0xa0]
01da181e  mov      rbx, qword ptr [r11 + 0x18]
01da1822  mov      rbp, qword ptr [r11 + 0x20]
01da1826  movaps   xmm7, xmmword ptr [r11 - 0x20]
01da182b  mov      rsi, qword ptr [rsp + 0xb0]
01da1833  mov      rsp, r11
01da1836  pop      rdi
01da1837  ret      
01da1838  call     0x4e0d00 ; ThrowNullRef
01da183d  int3     
01da183e  call     0x4e0cf0 ; ?
01da1843  int3     
01da1844  int3     
01da1845  int3     
01da1846  int3     
01da1847  int3     
01da1848  int3     
01da1849  int3     
01da184a  int3     
01da184b  int3     
01da184c  int3     
01da184d  int3     
01da184e  int3     
01da184f  int3     

### Boolean Enemy.Ene_Bos07::GetTangentPoints(Vector3,Vector3,Single,Vector3&,Vector3&)  RVA=0x1DA12E0 len=0x280
01da12e0  mov      rax, rsp
01da12e3  push     rbx
01da12e4  sub      rsp, 0x90
01da12eb  cmp      byte ptr [rip + 0x28c2520], 0 ; [4663812] bss
01da12f2  mov      rbx, rdx
01da12f5  movaps   xmmword ptr [rax - 0x38], xmm8
01da12fa  movaps   xmmword ptr [rax - 0x48], xmm9
01da12ff  movaps   xmmword ptr [rax - 0x58], xmm10
01da1304  movaps   xmm10, xmm3
01da1308  mov      qword ptr [rax + 8], rdi
01da130c  mov      rdi, r8
01da130f  jne      0x1da1324
01da1311  lea      rcx, [rip + 0x2610860] ; [43b1b78] TypeInfo#37312
01da1318  call     0x4e0a50 ; il2cpp_init_metadata
01da131d  mov      byte ptr [rip + 0x28c24ee], 1 ; [4663812] bss
01da1324  movsd    xmm1, qword ptr [rbx]
01da1328  lea      rcx, [rsp + 0x20]
01da132d  movsd    xmm0, qword ptr [rdi]
01da1331  xor      edx, edx
01da1333  movss    xmm9, dword ptr [rdi + 8]
01da1339  movaps   xmm8, xmm0
01da133d  subss    xmm9, dword ptr [rbx + 8]
01da1343  movaps   xmm2, xmm0
01da1346  movsd    qword ptr [rsp + 0x20], xmm0
01da134c  movaps   xmm0, xmm1
01da134f  movsd    qword ptr [rsp + 0x20], xmm1
01da1355  subss    xmm8, xmm1
01da135a  shufps   xmm0, xmm0, 0x55
01da135e  shufps   xmm2, xmm2, 0x55
01da1362  subss    xmm2, xmm0
01da1366  movss    dword ptr [rsp + 0x28], xmm9
01da136d  movaps   xmm1, xmm8
01da1371  unpcklps xmm1, xmm2
01da1374  movsd    qword ptr [rsp + 0x20], xmm1
01da137a  call     0x5d2df0 ; Vector3.Magnitude
01da137f  mov      rdi, qword ptr [rsp + 0xa0]
01da1387  movaps   xmm1, xmm0
01da138a  comiss   xmm10, xmm1
01da138e  jae      0x1da14e9
01da1394  movaps   xmmword ptr [rsp + 0x80], xmm6
01da139c  movaps   xmmword ptr [rsp + 0x70], xmm7
01da13a1  movaps   xmmword ptr [rsp + 0x30], xmm11
01da13a7  movaps   xmm0, xmm10
01da13ab  divss    xmm0, xmm1
01da13af  divss    xmm8, xmm1
01da13b4  divss    xmm9, xmm1
01da13b9  call     0x578460 ; acosf
01da13be  mov      rcx, qword ptr [rip + 0x26107b3] ; [43b1b78] TypeInfo#37312
01da13c5  cmp      dword ptr [rcx + 0xe4], 0
01da13cc  movaps   xmm11, xmm0
01da13d0  jne      0x1da13d7
01da13d2  call     0x4e0d90 ; il2cpp_class_init
01da13d7  movaps   xmm0, xmm11
01da13db  call     0x576bf0 ; cosf
01da13e0  movaps   xmm6, xmm0
01da13e3  movaps   xmm0, xmm11
01da13e7  call     0x578040 ; sinf
01da13ec  movsd    xmm2, qword ptr [rbx]
01da13f0  movaps   xmm1, xmm0
01da13f3  mov      rcx, qword ptr [rsp + 0xc0]
01da13fb  movaps   xmm4, xmm0
01da13fe  xorps    xmm11, xmmword ptr [rip + 0x173f80a] ; [34e0c10] f=-0.0 d=-1.0609978955e-314 v4=(-0.0, -0.0, -0.0, -0.0)
01da1406  movaps   xmm3, xmm6
01da1409  mulss    xmm3, xmm8
01da140e  movaps   xmm0, xmm2
01da1411  mulss    xmm1, xmm9
01da1416  xorps    xmm7, xmm7
01da1419  mulss    xmm4, xmm8
01da141e  subss    xmm3, xmm1
01da1422  shufps   xmm0, xmm0, 0x55
01da1426  mulss    xmm6, xmm9
01da142b  movaps   xmm1, xmm10
01da142f  mulss    xmm1, xmm7
01da1433  addss    xmm4, xmm6
01da1437  mulss    xmm3, xmm10
01da143c  addss    xmm1, xmm0
01da1440  movaps   xmm0, xmm11
01da1444  addss    xmm3, xmm2
01da1448  mulss    xmm4, xmm10
01da144d  addss    xmm4, dword ptr [rbx + 8]
01da1452  unpcklps xmm3, xmm1
01da1455  movsd    qword ptr [rcx], xmm3
01da1459  movss    dword ptr [rcx + 8], xmm4
01da145e  call     0x576bf0 ; cosf
01da1463  movaps   xmm6, xmm0
01da1466  movaps   xmm0, xmm11
01da146a  call     0x578040 ; sinf
01da146f  movsd    xmm2, qword ptr [rbx]
01da1473  movaps   xmm3, xmm6
01da1476  mov      rcx, qword ptr [rsp + 0xc8]
01da147e  movaps   xmm1, xmm0
01da1481  movaps   xmm11, xmmword ptr [rsp + 0x30]
01da1487  movaps   xmm4, xmm0
01da148a  mulss    xmm3, xmm8
01da148f  movaps   xmm0, xmm2
01da1492  mov      al, 1
01da1494  mulss    xmm1, xmm9
01da1499  mulss    xmm4, xmm8
01da149e  subss    xmm3, xmm1
01da14a2  mulss    xmm6, xmm9
01da14a7  movaps   xmm1, xmm10
01da14ab  shufps   xmm0, xmm0, 0x55
01da14af  mulss    xmm1, xmm7
01da14b3  movaps   xmm7, xmmword ptr [rsp + 0x70]
01da14b8  addss    xmm4, xmm6
01da14bc  movaps   xmm6, xmmword ptr [rsp + 0x80]
01da14c4  mulss    xmm3, xmm10
01da14c9  addss    xmm1, xmm0
01da14cd  mulss    xmm4, xmm10
01da14d2  addss    xmm3, xmm2
01da14d6  addss    xmm4, dword ptr [rbx + 8]
01da14db  unpcklps xmm3, xmm1
01da14de  movsd    qword ptr [rcx], xmm3
01da14e2  movss    dword ptr [rcx + 8], xmm4
01da14e7  jmp      0x1da153a
01da14e9  cmp      byte ptr [rip + 0x28baf6d], 0 ; [465c45d] bss
01da14f0  jne      0x1da1505
01da14f2  lea      rcx, [rip + 0x26201df] ; [43c16d8] TypeInfo#48704
01da14f9  call     0x4e0a50 ; il2cpp_init_metadata
01da14fe  mov      byte ptr [rip + 0x28baf58], 1 ; [465c45d] bss
01da1505  mov      rax, qword ptr [rip + 0x26201cc] ; [43c16d8] TypeInfo#48704
01da150c  mov      rcx, qword ptr [rax + 0xb8]
01da1513  mov      rax, qword ptr [rsp + 0xc8]
01da151b  movsd    xmm1, qword ptr [rcx]
01da151f  mov      edx, dword ptr [rcx + 8]
01da1522  movsd    qword ptr [rax], xmm1
01da1526  mov      dword ptr [rax + 8], edx
01da1529  mov      rax, qword ptr [rsp + 0xc0]
01da1531  movsd    qword ptr [rax], xmm1
01da1535  mov      dword ptr [rax + 8], edx
01da1538  xor      al, al
01da153a  movaps   xmm8, xmmword ptr [rsp + 0x60]
01da1540  movaps   xmm9, xmmword ptr [rsp + 0x50]
01da1546  movaps   xmm10, xmmword ptr [rsp + 0x40]
01da154c  add      rsp, 0x90
01da1553  pop      rbx
01da1554  ret      
01da1555  int3     
01da1556  int3     
01da1557  int3     
01da1558  int3     
01da1559  int3     
01da155a  int3     
01da155b  int3     
01da155c  int3     
01da155d  int3     
01da155e  int3     
01da155f  int3     

### Void Enemy.Ene_Bos07::PatternMove3(Single)  RVA=0x1DA3140 len=0xBF0
01da3140  push     rbx
01da3142  sub      rsp, 0xc0
01da3149  cmp      byte ptr [rip + 0x28c06c3], 0 ; [4663813] bss
01da3150  mov      rbx, rcx
01da3153  movaps   xmmword ptr [rsp + 0x40], xmm13
01da3159  movaps   xmm13, xmm1
01da315d  jne      0x1da317e
01da315f  lea      rcx, [rip + 0x260ea12] ; [43b1b78] TypeInfo#37312
01da3166  call     0x4e0a50 ; il2cpp_init_metadata
01da316b  lea      rcx, [rip + 0x25ff1f6] ; [43a2368] TypeInfo#45781
01da3172  call     0x4e0a50 ; il2cpp_init_metadata
01da3177  mov      byte ptr [rip + 0x28c0695], 1 ; [4663813] bss
01da317e  mov      qword ptr [rsp + 0xd8], rsi
01da3186  xor      edx, edx
01da3188  mov      qword ptr [rsp + 0xe0], rdi
01da3190  mov      rcx, rbx
01da3193  mov      qword ptr [rsp + 0xe8], r14
01da319b  movaps   xmmword ptr [rsp + 0xb0], xmm6
01da31a3  movaps   xmmword ptr [rsp + 0xa0], xmm7
01da31ab  movaps   xmmword ptr [rsp + 0x90], xmm8
01da31b4  movaps   xmmword ptr [rsp + 0x80], xmm9
01da31bd  movaps   xmmword ptr [rsp + 0x70], xmm10
01da31c3  movaps   xmmword ptr [rsp + 0x60], xmm11
01da31c9  movaps   xmmword ptr [rsp + 0x50], xmm12
01da31cf  call     0x1da1f10 ; Boolean Enemy.Ene_Bos07::IsLegBrokenOrDifficultyUp()
01da31d4  test     al, al
01da31d6  jne      0x1da3c9c
01da31dc  xor      r8d, r8d
01da31df  mov      edx, 1
01da31e4  mov      rcx, rbx
01da31e7  call     0x1d0da10 ; Enemy.EnePartsGroup Enemy.PawnEnemy::GetParts(Int32)
01da31ec  test     rax, rax
01da31ef  je       0x1da3cdf
01da31f5  movzx    r14d, byte ptr [rax + 0x9a]
01da31fd  xor      r8d, r8d
01da3200  mov      edx, 2
01da3205  mov      rcx, rbx
01da3208  call     0x1d0da10 ; Enemy.EnePartsGroup Enemy.PawnEnemy::GetParts(Int32)
01da320d  test     rax, rax
01da3210  je       0x1da3cdf
01da3216  movzx    ecx, byte ptr [rax + 0x9a]
01da321d  xor      edi, edi
01da321f  test     r14b, r14b
01da3222  jne      0x1da3228
01da3224  mov      esi, edi
01da3226  jmp      0x1da3233
01da3228  cmp      byte ptr [rbx + 0x304], dil
01da322f  sete     sil
01da3233  mov      qword ptr [rsp + 0xd0], rbp
01da323b  test     cl, cl
01da323d  jne      0x1da3243
01da323f  mov      ebp, edi
01da3241  jmp      0x1da324e
01da3243  cmp      byte ptr [rbx + 0x305], 0
01da324a  sete     bpl
01da324e  mov      byte ptr [rbx + 0x304], r14b
01da3255  mov      r14d, dword ptr [rbx + 0x1ec]
01da325c  mov      byte ptr [rbx + 0x305], cl
01da3262  cmp      r14d, 0xe
01da3266  je       0x1da326c
01da3268  mov      eax, edi
01da326a  jmp      0x1da3286
01da326c  xor      edx, edx
01da326e  mov      rcx, rbx
01da3271  call     0x1db9a20 ; Single Enemy.Ene_BosBase::GetDirectionRate()
01da3276  movss    xmm1, dword ptr [rip + 0x184f926] ; [35f2ba4] f=0.6000000238418579 d=8192.00192565918 v4=(0.6, 6.0, 7.0, 15.0)
01da327e  mov      eax, edi
01da3280  comiss   xmm1, xmm0
01da3283  seta     al
01da3286  cmp      dword ptr [rbx + 0x1ec], 0xc
01da328d  jne      0x1da3296
01da328f  mov      ecx, 1
01da3294  jmp      0x1da32a2
01da3296  cmp      dword ptr [rbx + 0x1ec], 0xd
01da329d  mov      ecx, edi
01da329f  sete     cl
01da32a2  movss    xmm9, dword ptr [rip + 0x173d921] ; [34e0bcc] f=1.0 d=50.12387841939926 v4=(1.0, 3.141593, 4.0, 10.0)
01da32ab  or       ecx, eax
01da32ad  test     sil, sil
01da32b0  je       0x1da32c2
01da32b2  cmp      byte ptr [rbx + 0x314], 0
01da32b9  je       0x1da32c2
01da32bb  mov      edx, 1
01da32c0  jmp      0x1da32ce
01da32c2  test     bpl, bpl
01da32c5  je       0x1da3345
01da32c7  movzx    edx, byte ptr [rbx + 0x315]
01da32ce  test     edx, edx
01da32d0  mov      eax, edi
01da32d2  cmovne   eax, ecx
01da32d5  test     eax, eax
01da32d7  je       0x1da3345
01da32d9  cmp      r14d, 0x1e
01da32dd  je       0x1da3345
01da32df  mov      eax, dword ptr [rbx + 0x31c]
01da32e5  mov      edx, 2
01da32ea  mov      r8d, edx
01da32ed  mov      dword ptr [rbx + 0x320], eax
01da32f3  xor      r9d, r9d
01da32f6  mov      rcx, rbx
01da32f9  call     0x1da6240 ; Void Enemy.Ene_Bos07::SetupLegPattern(Enemy.Ene_Bos07/LegPattern,Enemy.Ene_Bos07/LegPattern)
01da32fe  mov      rax, qword ptr [rip + 0x260e873] ; [43b1b78] TypeInfo#37312
01da3305  cmp      dword ptr [rax + 0xe4], 0
01da330c  jne      0x1da331d
01da330e  mov      rcx, rax
01da3311  call     0x4e0d90 ; il2cpp_class_init
01da3316  mov      rax, qword ptr [rip + 0x260e85b] ; [43b1b78] TypeInfo#37312
01da331d  mov      rax, qword ptr [rax + 0xb8]
01da3324  xor      r9d, r9d
01da3327  movaps   xmm2, xmm9
01da332b  mov      rcx, rbx
01da332e  movss    xmm1, dword ptr [rax + 0xf8]
01da3336  call     0x1dba4d0 ; Void Enemy.Ene_BosBase::SetDirectionTime(Single,Single)
01da333b  mov      dword ptr [rbx + 0x1ec], 0x1e
01da3345  mov      edx, dword ptr [rbx + 0x1ec]
01da334b  mov      rbp, qword ptr [rsp + 0xd0]
01da3353  test     edx, edx
01da3355  jne      0x1da3398
01da3357  mov      dword ptr [rbx + 0x310], edi
01da335d  mov      dword ptr [rbx + 0x1ec], 0xa
01da3367  mov      qword ptr [rbx + 0x31c], 0
01da3372  movss    xmm6, dword ptr [rip + 0x1749692] ; [34eca0c] f=2.0 d=5.304989477e-315 v4=(2.0, 0.0, 2.0, 6.283185)
01da337a  movss    xmm0, dword ptr [rbx + 0x310]
01da3382  movaps   xmm1, xmm6
01da3385  call     0x578cb0 ; fmodf
01da338a  xorps    xmm1, xmm1
01da338d  ucomiss  xmm0, xmm1
01da3390  jp       0x1da33bd
01da3392  jne      0x1da33bd
01da3394  mov      al, 1
01da3396  jmp      0x1da33bf
01da3398  lea      eax, [rdx - 0xa]
01da339b  cmp      eax, 0xa
01da339e  ja       0x1da3b1f
01da33a4  lea      eax, [rdx - 0xa]
01da33a7  movsxd   rcx, eax
01da33aa  lea      rsi, [rip - 0x1da33b1]
01da33b1  mov      eax, dword ptr [rsi + rcx*4 + 0x1da3ce8] ; JT 1da3372,1da34fa,1da35b8,1da3699,1da3767,1da3893,1da3b99,1da3b99,1da3b99,1da3b99,1da38c1,1da39ea
01da33b8  add      rax, rsi
01da33bb  jmp      rax
01da33bd  xor      al, al
01da33bf  mov      byte ptr [rbx + 0x314], al
01da33c5  movaps   xmm1, xmm6
01da33c8  movss    xmm0, dword ptr [rbx + 0x310]
01da33d0  call     0x578cb0 ; fmodf
01da33d5  ucomiss  xmm0, xmm9
01da33d9  jp       0x1da33e1
01da33db  jne      0x1da33e1
01da33dd  mov      al, 1
01da33df  jmp      0x1da33e3
01da33e1  xor      al, al
01da33e3  mov      byte ptr [rbx + 0x315], al
01da33e9  cmp      byte ptr [rbx + 0x314], 0
01da33f0  je       0x1da3444
01da33f2  xor      r8d, r8d
01da33f5  mov      edx, 1
01da33fa  mov      rcx, rbx
01da33fd  call     0x1d0da10 ; Enemy.EnePartsGroup Enemy.PawnEnemy::GetParts(Int32)
01da3402  test     rax, rax
01da3405  je       0x1da3cdf
01da340b  cmp      byte ptr [rax + 0x9a], 0
01da3412  je       0x1da3444
01da3414  xor      r8d, r8d
01da3417  mov      byte ptr [rbx + 0x314], 0
01da341e  mov      edx, 2
01da3423  mov      rcx, rbx
01da3426  call     0x1d0da10 ; Enemy.EnePartsGroup Enemy.PawnEnemy::GetParts(Int32)
01da342b  test     rax, rax
01da342e  je       0x1da3cdf
01da3434  cmp      byte ptr [rax + 0x9a], 0
01da343b  sete     al
01da343e  mov      byte ptr [rbx + 0x315], al
01da3444  cmp      byte ptr [rbx + 0x315], 0
01da344b  je       0x1da349f
01da344d  xor      r8d, r8d
01da3450  mov      edx, 2
01da3455  mov      rcx, rbx
01da3458  call     0x1d0da10 ; Enemy.EnePartsGroup Enemy.PawnEnemy::GetParts(Int32)
01da345d  test     rax, rax
01da3460  je       0x1da3cdf
01da3466  cmp      byte ptr [rax + 0x9a], 0
01da346d  je       0x1da349f
01da346f  xor      r8d, r8d
01da3472  mov      edx, 1
01da3477  mov      rcx, rbx
01da347a  call     0x1d0da10 ; Enemy.EnePartsGroup Enemy.PawnEnemy::GetParts(Int32)
01da347f  test     rax, rax
01da3482  je       0x1da3cdf
01da3488  cmp      byte ptr [rax + 0x9a], 0
01da348f  mov      byte ptr [rbx + 0x315], 0
01da3496  sete     al
01da3499  mov      byte ptr [rbx + 0x314], al
01da349f  mov      edx, 2
01da34a4  xor      r9d, r9d
01da34a7  mov      r8d, edx
01da34aa  mov      rcx, rbx
01da34ad  call     0x1da6240 ; Void Enemy.Ene_Bos07::SetupLegPattern(Enemy.Ene_Bos07/LegPattern,Enemy.Ene_Bos07/LegPattern)
01da34b2  mov      rax, qword ptr [rip + 0x260e6bf] ; [43b1b78] TypeInfo#37312
01da34b9  cmp      dword ptr [rax + 0xe4], 0
01da34c0  jne      0x1da34d1
01da34c2  mov      rcx, rax
01da34c5  call     0x4e0d90 ; il2cpp_class_init
01da34ca  mov      rax, qword ptr [rip + 0x260e6a7] ; [43b1b78] TypeInfo#37312
01da34d1  mov      rax, qword ptr [rax + 0xb8]
01da34d8  xor      r9d, r9d
01da34db  movaps   xmm2, xmm9
01da34df  mov      rcx, rbx
01da34e2  movss    xmm1, dword ptr [rax + 0xf8]
01da34ea  call     0x1dba4d0 ; Void Enemy.Ene_BosBase::SetDirectionTime(Single,Single)
01da34ef  inc      dword ptr [rbx + 0x1ec]
01da34f5  jmp      0x1da3b99
01da34fa  xor      edx, edx
01da34fc  mov      rcx, rbx
01da34ff  call     0x1db9a20 ; Single Enemy.Ene_BosBase::GetDirectionRate()
01da3504  xor      edx, edx
01da3506  call     0x1de8650 ; Single KANAI.Kernel.EasingUtility::InOutQuad01(Single)
01da350b  movss    xmm7, dword ptr [rbx + 0x320]
01da3513  xor      edx, edx
01da3515  movaps   xmm6, xmm7
01da3518  movaps   xmm8, xmm0
01da351c  call     0x1de86f0 ; Single KANAI.Kernel.EasingUtility::InOutSine01(Single)
01da3521  xorps    xmm1, xmm1
01da3524  xor      r8d, r8d
01da3527  subss    xmm1, xmm6
01da352b  mov      rcx, rbx
01da352e  mulss    xmm0, xmm1
01da3532  movaps   xmm1, xmm8
01da3536  addss    xmm0, xmm7
01da353a  movss    dword ptr [rbx + 0x31c], xmm0
01da3542  call     0x1da5f60 ; Void Enemy.Ene_Bos07::ProgressLegPattern(Single)
01da3547  comiss   xmm8, xmm9
01da354b  jb       0x1da3b99
01da3551  mov      edx, 3
01da3556  xor      r9d, r9d
01da3559  mov      r8d, edx
01da355c  mov      rcx, rbx
01da355f  call     0x1da6240 ; Void Enemy.Ene_Bos07::SetupLegPattern(Enemy.Ene_Bos07/LegPattern,Enemy.Ene_Bos07/LegPattern)
01da3564  mov      rax, qword ptr [rip + 0x260e60d] ; [43b1b78] TypeInfo#37312
01da356b  cmp      dword ptr [rax + 0xe4], 0
01da3572  jne      0x1da3583
01da3574  mov      rcx, rax
01da3577  call     0x4e0d90 ; il2cpp_class_init
01da357c  mov      rax, qword ptr [rip + 0x260e5f5] ; [43b1b78] TypeInfo#37312
01da3583  mov      rax, qword ptr [rax + 0xb8]
01da358a  xor      r9d, r9d
01da358d  movaps   xmm2, xmm9
01da3591  mov      rcx, rbx
01da3594  movss    xmm1, dword ptr [rax + 0xfc]
01da359c  call     0x1dba4d0 ; Void Enemy.Ene_BosBase::SetDirectionTime(Single,Single)
01da35a1  mov      eax, dword ptr [rbx + 0x31c]
01da35a7  inc      dword ptr [rbx + 0x1ec]
01da35ad  mov      dword ptr [rbx + 0x320], eax
01da35b3  jmp      0x1da3b99
01da35b8  xor      edx, edx
01da35ba  mov      rcx, rbx
01da35bd  call     0x1db9a20 ; Single Enemy.Ene_BosBase::GetDirectionRate()
01da35c2  xor      edx, edx
01da35c4  call     0x1de88f0 ; Single KANAI.Kernel.EasingUtility::OutCubic01(Single)
01da35c9  mov      rax, qword ptr [rip + 0x260e5a8] ; [43b1b78] TypeInfo#37312
01da35d0  movaps   xmm8, xmm0
01da35d4  movss    xmm10, dword ptr [rbx + 0x320]
01da35dd  cmp      dword ptr [rax + 0xe4], 0
01da35e4  jne      0x1da35f5
01da35e6  mov      rcx, rax
01da35e9  call     0x4e0d90 ; il2cpp_class_init
01da35ee  mov      rax, qword ptr [rip + 0x260e583] ; [43b1b78] TypeInfo#37312
01da35f5  mov      rax, qword ptr [rax + 0xb8]
01da35fc  xor      edx, edx
01da35fe  movss    xmm6, dword ptr [rbx + 0x320]
01da3606  movaps   xmm0, xmm8
01da360a  movss    xmm7, dword ptr [rax + 0xd0]
01da3612  call     0x1de86f0 ; Single KANAI.Kernel.EasingUtility::InOutSine01(Single)
01da3617  subss    xmm7, xmm6
01da361b  xor      r8d, r8d
01da361e  movaps   xmm1, xmm8
01da3622  mov      rcx, rbx
01da3625  mulss    xmm0, xmm7
01da3629  addss    xmm0, xmm10
01da362e  movss    dword ptr [rbx + 0x31c], xmm0
01da3636  call     0x1da5f60 ; Void Enemy.Ene_Bos07::ProgressLegPattern(Single)
01da363b  comiss   xmm8, xmm9
01da363f  jb       0x1da3b99
01da3645  mov      rax, qword ptr [rip + 0x260e52c] ; [43b1b78] TypeInfo#37312
01da364c  cmp      dword ptr [rax + 0xe4], 0
01da3653  jne      0x1da3664
01da3655  mov      rcx, rax
01da3658  call     0x4e0d90 ; il2cpp_class_init
01da365d  mov      rax, qword ptr [rip + 0x260e514] ; [43b1b78] TypeInfo#37312
01da3664  mov      rax, qword ptr [rax + 0xb8]
01da366b  xor      r9d, r9d
01da366e  movaps   xmm2, xmm9
01da3672  mov      rcx, rbx
01da3675  movss    xmm1, dword ptr [rax + 0x100]
01da367d  call     0x1dba4d0 ; Void Enemy.Ene_BosBase::SetDirectionTime(Single,Single)
01da3682  mov      eax, dword ptr [rbx + 0x31c]
01da3688  inc      dword ptr [rbx + 0x1ec]
01da368e  mov      dword ptr [rbx + 0x320], eax
01da3694  jmp      0x1da3b99
01da3699  xor      edx, edx
01da369b  mov      rcx, rbx
01da369e  call     0x1db9a20 ; Single Enemy.Ene_BosBase::GetDirectionRate()
01da36a3  comiss   xmm0, xmm9
01da36a7  jb       0x1da3b99
01da36ad  xor      r9d, r9d
01da36b0  mov      rcx, rbx
01da36b3  cmp      byte ptr [rbx + 0x314], r9b
01da36ba  jne      0x1da36e8
01da36bc  mov      edx, 5
01da36c1  mov      r8d, 4
01da36c7  call     0x1da6240 ; Void Enemy.Ene_Bos07::SetupLegPattern(Enemy.Ene_Bos07/LegPattern,Enemy.Ene_Bos07/LegPattern)
01da36cc  mov      rcx, qword ptr [rip + 0x25fec95] ; [43a2368] TypeInfo#45781
01da36d3  cmp      dword ptr [rcx + 0xe4], 0
01da36da  jne      0x1da36e1
01da36dc  call     0x4e0d90 ; il2cpp_class_init
01da36e1  mov      ecx, 0xed
01da36e6  jmp      0x1da3712
01da36e8  mov      edx, 4
01da36ed  mov      r8d, 5
01da36f3  call     0x1da6240 ; Void Enemy.Ene_Bos07::SetupLegPattern(Enemy.Ene_Bos07/LegPattern,Enemy.Ene_Bos07/LegPattern)
01da36f8  mov      rcx, qword ptr [rip + 0x25fec69] ; [43a2368] TypeInfo#45781
01da36ff  cmp      dword ptr [rcx + 0xe4], 0
01da3706  jne      0x1da370d
01da3708  call     0x4e0d90 ; il2cpp_class_init
01da370d  mov      ecx, 0x57
01da3712  xor      edx, edx
01da3714  call     0x2723de0 ; Void TXEKernel.Sound.SoundUtility::PlayQue(TXEKernel.Sound.SoundUtility/ID)
01da3719  mov      rax, qword ptr [rip + 0x260e458] ; [43b1b78] TypeInfo#37312
01da3720  cmp      dword ptr [rax + 0xe4], 0
01da3727  jne      0x1da3738
01da3729  mov      rcx, rax
01da372c  call     0x4e0d90 ; il2cpp_class_init
01da3731  mov      rax, qword ptr [rip + 0x260e440] ; [43b1b78] TypeInfo#37312
01da3738  mov      rax, qword ptr [rax + 0xb8]
01da373f  xor      r9d, r9d
01da3742  movaps   xmm2, xmm9
01da3746  mov      rcx, rbx
01da3749  movss    xmm1, dword ptr [rax + 0x104]
01da3751  call     0x1dba4d0 ; Void Enemy.Ene_BosBase::SetDirectionTime(Single,Single)
01da3756  inc      dword ptr [rbx + 0x1ec]
01da375c  mov      dword ptr [rbx + 0x318], edi
01da3762  jmp      0x1da3b99
01da3767  xor      edx, edx
01da3769  mov      rcx, rbx
01da376c  call     0x1db9a20 ; Single Enemy.Ene_BosBase::GetDirectionRate()
01da3771  mov      rcx, qword ptr [rbx + 0x2d0]
01da3778  movaps   xmm6, xmm0
01da377b  test     rcx, rcx
01da377e  je       0x1da3cdf
01da3784  xor      r8d, r8d
01da3787  movaps   xmm1, xmm0
01da378a  call     0x2fcbe60 ; Single AnimationCurve::Evaluate(Single)
01da378f  mov      rcx, qword ptr [rbx + 0x2d0]
01da3796  movaps   xmm8, xmm0
01da379a  test     rcx, rcx
01da379d  je       0x1da3cdf
01da37a3  xor      r8d, r8d
01da37a6  movaps   xmm1, xmm6
01da37a9  call     0x2fcbe60 ; Single AnimationCurve::Evaluate(Single)
01da37ae  mov      rcx, qword ptr [rbx + 0x2d0]
01da37b5  movaps   xmm7, xmm0
01da37b8  test     rcx, rcx
01da37bb  je       0x1da3cdf
01da37c1  xor      r8d, r8d
01da37c4  movaps   xmm1, xmm6
01da37c7  call     0x2fcbe60 ; Single AnimationCurve::Evaluate(Single)
01da37cc  mov      rcx, qword ptr [rbx + 0x2c8]
01da37d3  movaps   xmm10, xmm0
01da37d7  movss    xmm11, dword ptr [rbx + 0x320]
01da37e0  movaps   xmm12, xmm11
01da37e4  test     rcx, rcx
01da37e7  je       0x1da3cdf
01da37ed  xor      r8d, r8d
01da37f0  movaps   xmm1, xmm6
01da37f3  call     0x2fcbe60 ; Single AnimationCurve::Evaluate(Single)
01da37f8  movaps   xmm1, xmm9
01da37fc  mov      qword ptr [rsp + 0x20], rdi
01da3801  subss    xmm1, xmm12
01da3806  movaps   xmm3, xmm10
01da380a  movaps   xmm2, xmm7
01da380d  mov      rcx, rbx
01da3810  mulss    xmm0, xmm1
01da3814  movaps   xmm1, xmm8
01da3818  addss    xmm0, xmm11
01da381d  movss    dword ptr [rbx + 0x31c], xmm0
01da3825  call     0x1da5c80 ; Void Enemy.Ene_Bos07::ProgressLegPatternSeparately(Single,Single,Single)
01da382a  comiss   xmm6, xmm9
01da382e  jb       0x1da38ad
01da3830  mov      rax, qword ptr [rip + 0x260e341] ; [43b1b78] TypeInfo#37312
01da3837  cmp      dword ptr [rax + 0xe4], 0
01da383e  jne      0x1da384f
01da3840  mov      rcx, rax
01da3843  call     0x4e0d90 ; il2cpp_class_init
01da3848  mov      rax, qword ptr [rip + 0x260e329] ; [43b1b78] TypeInfo#37312
01da384f  mov      rax, qword ptr [rax + 0xb8]
01da3856  xor      r9d, r9d
01da3859  movaps   xmm2, xmm9
01da385d  mov      rcx, rbx
01da3860  movss    xmm1, dword ptr [rax + 0x108]
01da3868  call     0x1dba4d0 ; Void Enemy.Ene_BosBase::SetDirectionTime(Single,Single)
01da386d  mov      eax, dword ptr [rbx + 0x31c]
01da3873  inc      dword ptr [rbx + 0x1ec]
01da3879  mov      dword ptr [rbx + 0x320], eax
01da387f  xor      r8d, r8d
01da3882  movaps   xmm1, xmm13
01da3886  mov      rcx, rbx
01da3889  call     0x1da1fd0 ; Void Enemy.Ene_Bos07::LegOrBatteryFire(Single)
01da388e  jmp      0x1da3b99
01da3893  xor      edx, edx
01da3895  mov      rcx, rbx
01da3898  call     0x1db9a20 ; Single Enemy.Ene_BosBase::GetDirectionRate()
01da389d  comiss   xmm0, xmm9
01da38a1  jb       0x1da38ad
01da38a3  mov      dword ptr [rbx + 0x1ec], 0x14
01da38ad  xor      r8d, r8d
01da38b0  movaps   xmm1, xmm13
01da38b4  mov      rcx, rbx
01da38b7  call     0x1da1fd0 ; Void Enemy.Ene_Bos07::LegOrBatteryFire(Single)
01da38bc  jmp      0x1da3b99
01da38c1  movss    xmm1, dword ptr [rbx + 0x310]
01da38c9  movss    xmm0, dword ptr [rip + 0x173d303] ; [34e0bd4] f=4.0 d=524288.1259765625 v4=(4.0, 10.0, 20.0, 57.29578)
01da38d1  addss    xmm1, xmm9
01da38d6  comiss   xmm0, xmm1
01da38d9  movss    dword ptr [rbx + 0x310], xmm1
01da38e1  ja       0x1da3b13
01da38e7  cmp      dword ptr [rbx + 0x270], 0x64
01da38ee  je       0x1da3b99
01da38f4  xor      edx, edx
01da38f6  mov      rcx, rbx
01da38f9  call     0x1da1cf0 ; Boolean Enemy.Ene_Bos07::IsArmBrokenOrDifficultyUp()
01da38fe  test     al, al
01da3900  jne      0x1da3acc
01da3906  cmp      byte ptr [rbx + 0x302], al
01da390c  je       0x1da3919
01da390e  mov      ecx, dword ptr [rbx + 0x270]
01da3914  jmp      0x1da39d2
01da3919  xor      r8d, r8d
01da391c  mov      edx, 1
01da3921  mov      rcx, rbx
01da3924  call     0x1d0da10 ; Enemy.EnePartsGroup Enemy.PawnEnemy::GetParts(Int32)
01da3929  test     rax, rax
01da392c  je       0x1da3cdf
01da3932  cmp      byte ptr [rax + 0x9a], 0
01da3939  je       0x1da395d
01da393b  xor      r8d, r8d
01da393e  mov      edx, 2
01da3943  mov      rcx, rbx
01da3946  call     0x1d0da10 ; Enemy.EnePartsGroup Enemy.PawnEnemy::GetParts(Int32)
01da394b  test     rax, rax
01da394e  je       0x1da3cdf
01da3954  cmp      byte ptr [rax + 0x9a], 0
01da395b  jne      0x1da3971
01da395d  xor      r8d, r8d
01da3960  mov      edx, 3
01da3965  mov      rcx, rbx
01da3968  call     0x1db9fd0 ; Boolean Enemy.Ene_BosBase::IsOverHP(Enemy.Ene_BosBase/HitPState)
01da396d  test     al, al
01da396f  je       0x1da39b8
01da3971  mov      ecx, dword ptr [rbx + 0x270]
01da3977  cmp      ecx, 6
01da397a  je       0x1da398c
01da397c  mov      dword ptr [rbx + 0x270], 6
01da3986  mov      dword ptr [rbx + 0x1ec], edi
01da398c  mov      rax, qword ptr [rbx + 0xb8]
01da3993  test     rax, rax
01da3996  je       0x1da3cdf
01da399c  mov      byte ptr [rax + 0x1d4], 0
01da39a3  mov      byte ptr [rbx + 0x302], 1
01da39aa  mov      word ptr [rbx + 0x314], 0
01da39b3  jmp      0x1da3b99
01da39b8  xor      r8d, r8d
01da39bb  mov      edx, 9
01da39c0  mov      rcx, rbx
01da39c3  call     0x1db9fe0 ; Boolean Enemy.Ene_BosBase::IsOverStep(Enemy.Ene_BosBase/TimeSteps)
01da39c8  mov      ecx, dword ptr [rbx + 0x270]
01da39ce  test     al, al
01da39d0  jne      0x1da3977
01da39d2  cmp      ecx, 6
01da39d5  ja       0x1da3a9b
01da39db  movsxd   rax, ecx
01da39de  mov      ecx, dword ptr [rsi + rax*4 + 0x1da3d14] ; JT 1da39ea,1da3a06,1da39ea,1da3a71,1da3a86,1da3a9b,1da3a71,245c8948,8d485520,48a9246c,c0ec81,3d800000
01da39e5  add      rcx, rsi
01da39e8  jmp      rcx
01da39ea  cmp      dword ptr [rbx + 0x270], 1
01da39f1  je       0x1da3ab0
01da39f7  mov      dword ptr [rbx + 0x270], 1
01da3a01  jmp      0x1da3aaa
01da3a06  cmp      dword ptr [rbx + 0x270], 2
01da3a0d  je       0x1da3ab0
01da3a13  xor      r8d, r8d
01da3a16  mov      dword ptr [rbx + 0x270], 2
01da3a20  mov      edx, 1
01da3a25  mov      dword ptr [rbx + 0x1ec], edi
01da3a2b  mov      rcx, rbx
01da3a2e  call     0x1d0da10 ; Enemy.EnePartsGroup Enemy.PawnEnemy::GetParts(Int32)
01da3a33  test     rax, rax
01da3a36  je       0x1da3cdf
01da3a3c  movzx    eax, byte ptr [rax + 0x9a]
01da3a43  xor      r8d, r8d
01da3a46  mov      edx, 2
01da3a4b  mov      byte ptr [rbx + 0x304], al
01da3a51  mov      rcx, rbx
01da3a54  call     0x1d0da10 ; Enemy.EnePartsGroup Enemy.PawnEnemy::GetParts(Int32)
01da3a59  test     rax, rax
01da3a5c  je       0x1da3cdf
01da3a62  movzx    eax, byte ptr [rax + 0x9a]
01da3a69  mov      byte ptr [rbx + 0x305], al
01da3a6f  jmp      0x1da3ab0
01da3a71  cmp      dword ptr [rbx + 0x270], 3
01da3a78  je       0x1da3ab0
01da3a7a  mov      dword ptr [rbx + 0x270], 3
01da3a84  jmp      0x1da3aaa
01da3a86  cmp      dword ptr [rbx + 0x270], 5
01da3a8d  je       0x1da3ab0
01da3a8f  mov      dword ptr [rbx + 0x270], 5
01da3a99  jmp      0x1da3aaa
01da3a9b  cmp      dword ptr [rbx + 0x270], 0
01da3aa2  je       0x1da3ab0
01da3aa4  mov      dword ptr [rbx + 0x270], edi
01da3aaa  mov      dword ptr [rbx + 0x1ec], edi
01da3ab0  mov      rax, qword ptr [rbx + 0xb8]
01da3ab7  test     rax, rax
01da3aba  je       0x1da3cdf
01da3ac0  mov      byte ptr [rax + 0x1d4], 0
01da3ac7  jmp      0x1da3b99
01da3acc  cmp      dword ptr [rbx + 0x270], 4
01da3ad3  je       0x1da3ae5
01da3ad5  mov      dword ptr [rbx + 0x270], 4
01da3adf  mov      dword ptr [rbx + 0x1ec], edi
01da3ae5  mov      rax, qword ptr [rbx + 0xb8]
01da3aec  test     rax, rax
01da3aef  je       0x1da3cdf
01da3af5  mov      byte ptr [rax + 0x1d4], 0
01da3afc  mov      word ptr [rbx + 0x302], 0x101
01da3b05  mov      word ptr [rbx + 0x314], 0
01da3b0e  jmp      0x1da3b99
01da3b13  mov      dword ptr [rbx + 0x1ec], 0xa
01da3b1d  jmp      0x1da3b99
01da3b1f  cmp      edx, 0x1e
01da3b22  jne      0x1da3b99
01da3b24  xor      edx, edx
01da3b26  mov      rcx, rbx
01da3b29  call     0x1db9a20 ; Single Enemy.Ene_BosBase::GetDirectionRate()
01da3b2e  xor      edx, edx
01da3b30  movaps   xmm6, xmm0
01da3b33  call     0x1de86f0 ; Single KANAI.Kernel.EasingUtility::InOutSine01(Single)
01da3b38  movss    xmm3, dword ptr [rbx + 0x320]
01da3b40  xorps    xmm1, xmm1
01da3b43  comiss   xmm1, xmm0
01da3b46  ja       0x1da3b59
01da3b48  comiss   xmm0, xmm9
01da3b4c  ja       0x1da3b53
01da3b4e  movaps   xmm2, xmm0
01da3b51  jmp      0x1da3b5c
01da3b53  movaps   xmm2, xmm9
01da3b57  jmp      0x1da3b5c
01da3b59  xorps    xmm2, xmm2
01da3b5c  subss    xmm1, xmm3
01da3b60  xor      r8d, r8d
01da3b63  mov      rcx, rbx
01da3b66  mulss    xmm1, xmm2
01da3b6a  addss    xmm1, xmm3
01da3b6e  movss    dword ptr [rbx + 0x31c], xmm1
01da3b76  movaps   xmm1, xmm0
01da3b79  call     0x1da5f60 ; Void Enemy.Ene_Bos07::ProgressLegPattern(Single)
01da3b7e  comiss   xmm6, xmm9
01da3b82  jb       0x1da3b99
01da3b84  mov      qword ptr [rbx + 0x31c], 0
01da3b8f  mov      dword ptr [rbx + 0x1ec], 0x14
01da3b99  mov      rax, qword ptr [rip + 0x260dfd8] ; [43b1b78] TypeInfo#37312
01da3ba0  cmp      dword ptr [rax + 0xe4], 0
01da3ba7  jne      0x1da3bb8
01da3ba9  mov      rcx, rax
01da3bac  call     0x4e0d90 ; il2cpp_class_init
01da3bb1  mov      rax, qword ptr [rip + 0x260dfc0] ; [43b1b78] TypeInfo#37312
01da3bb8  movsd    xmm1, qword ptr [rbx + 0x228]
01da3bc0  movss    xmm2, dword ptr [rbx + 0x31c]
01da3bc8  mov      rax, qword ptr [rax + 0xb8]
01da3bcf  mov      rcx, qword ptr [rbx + 0x50]
01da3bd3  movsd    xmm0, qword ptr [rax + 0xd4]
01da3bdb  movsd    qword ptr [rsp + 0x30], xmm0
01da3be1  movaps   xmm4, xmm0
01da3be4  movsd    qword ptr [rsp + 0x30], xmm1
01da3bea  movaps   xmm3, xmm0
01da3bed  shufps   xmm3, xmm3, 0x55
01da3bf1  movaps   xmm0, xmm1
01da3bf4  mulss    xmm4, xmm2
01da3bf8  mulss    xmm3, xmm2
01da3bfc  shufps   xmm0, xmm0, 0x55
01da3c00  addss    xmm4, xmm1
01da3c04  movss    xmm1, dword ptr [rax + 0xdc]
01da3c0c  mulss    xmm1, xmm2
01da3c10  addss    xmm3, xmm0
01da3c14  addss    xmm1, dword ptr [rbx + 0x230]
01da3c1c  test     rcx, rcx
01da3c1f  je       0x1da3cdf
01da3c25  unpcklps xmm4, xmm3
01da3c28  lea      rdx, [rsp + 0x30]
01da3c2d  xor      r8d, r8d
01da3c30  movsd    qword ptr [rsp + 0x30], xmm4
01da3c36  movss    dword ptr [rsp + 0x38], xmm1
01da3c3c  call     0x3094570 ; Void Transform::set_localPosition(Vector3)
01da3c41  movaps   xmm12, xmmword ptr [rsp + 0x50]
01da3c47  movaps   xmm11, xmmword ptr [rsp + 0x60]
01da3c4d  movaps   xmm10, xmmword ptr [rsp + 0x70]
01da3c53  movaps   xmm9, xmmword ptr [rsp + 0x80]
01da3c5c  movaps   xmm8, xmmword ptr [rsp + 0x90]
01da3c65  movaps   xmm7, xmmword ptr [rsp + 0xa0]
01da3c6d  movaps   xmm6, xmmword ptr [rsp + 0xb0]
01da3c75  mov      r14, qword ptr [rsp + 0xe8]
01da3c7d  mov      rdi, qword ptr [rsp + 0xe0]
01da3c85  mov      rsi, qword ptr [rsp + 0xd8]
01da3c8d  movaps   xmm13, xmmword ptr [rsp + 0x40]
01da3c93  add      rsp, 0xc0
01da3c9a  pop      rbx
01da3c9b  ret      
01da3c9c  cmp      dword ptr [rbx + 0x270], 6
01da3ca3  je       0x1da3cb7
01da3ca5  xor      edi, edi
01da3ca7  mov      dword ptr [rbx + 0x270], 6
01da3cb1  mov      dword ptr [rbx + 0x1ec], edi
01da3cb7  mov      rax, qword ptr [rbx + 0xb8]
01da3cbe  test     rax, rax
01da3cc1  je       0x1da3cdf
01da3cc3  mov      byte ptr [rax + 0x1d4], 0
01da3cca  mov      byte ptr [rbx + 0x302], 1
01da3cd1  mov      word ptr [rbx + 0x314], 0
01da3cda  jmp      0x1da3c41
01da3cdf  call     0x4e0d00 ; ThrowNullRef
01da3ce4  int3     
01da3ce5  nop      dword ptr [rax]
01da3ce8  jb       0x1da3d1d
01da3cea  fiadd    dword ptr [rcx]
01da3cec  cli      
01da3ced  xor      al, 0xda
01da3cef  add      dword ptr [rax - 0x66fe25cb], edi
01da3cf5  fiadd    dword ptr ss:[rcx]
01da3cfa  fiadd    dword ptr [rcx]
01da3cfc  xchg     ebx, eax
01da3cfd  cmp      dl, bl
01da3cff  add      dword ptr [rcx - 0x66fe25c5], ebx
01da3d05  cmp      ebx, edx
01da3d07  add      dword ptr [rcx - 0x66fe25c5], ebx
01da3d0d  cmp      ebx, edx
01da3d0f  add      ecx, eax
01da3d11  cmp      dl, bl
01da3d13  add      edx, ebp
01da3d15  cmp      edx, ebx
01da3d17  add      dword ptr [rsi], eax
01da3d19  cmp      bl, dl
01da3d1b  add      edx, ebp
01da3d1d  cmp      edx, ebx
01da3d1f  add      dword ptr [rcx + 0x3a], esi
01da3d22  fiadd    dword ptr [rcx]
01da3d24  xchg     byte ptr [rdx], bh
01da3d26  fiadd    dword ptr [rcx]
01da3d28  wait     
01da3d29  cmp      bl, dl
01da3d2b  add      dword ptr [rcx + 0x3a], esi
01da3d2e  fiadd    dword ptr [rcx]

### Void Enemy.Ene_Bos07::LegOrBatteryFire(Single)  RVA=0x1DA1FD0 len=0xA60
01da1fd0  mov      rax, rsp
01da1fd3  mov      qword ptr [rax + 0x18], rbx
01da1fd7  mov      qword ptr [rax + 0x20], r14
01da1fdb  push     rbp
01da1fdc  lea      rbp, [rax - 0x5f]
01da1fe0  sub      rsp, 0xa0
01da1fe7  cmp      byte ptr [rip + 0x28c1826], 0 ; [4663814] bss
01da1fee  mov      rbx, rcx
01da1ff1  movaps   xmmword ptr [rax - 0x18], xmm6
01da1ff5  movaps   xmmword ptr [rax - 0x28], xmm7
01da1ff9  movaps   xmm7, xmm1
01da1ffc  movaps   xmmword ptr [rax - 0x38], xmm8
01da2001  jne      0x1da2016
01da2003  lea      rcx, [rip + 0x260fb6e] ; [43b1b78] TypeInfo#37312
01da200a  call     0x4e0a50 ; il2cpp_init_metadata
01da200f  mov      byte ptr [rip + 0x28c17fe], 1 ; [4663814] bss
01da2016  movss    xmm6, dword ptr [rbx + 0x318]
01da201e  xor      r14d, r14d
01da2021  addss    xmm7, xmm6
01da2025  mov      qword ptr [rsp + 0xb0], rsi
01da202d  xorps    xmm8, xmm8
01da2031  mov      qword ptr [rsp + 0xb8], rdi
01da2039  movss    dword ptr [rbx + 0x318], xmm7
01da2041  cmp      byte ptr [rbx + 0x314], r14b
01da2048  jne      0x1da251a
01da204e  xor      r8d, r8d
01da2051  mov      edx, 1
01da2056  mov      rcx, rbx
01da2059  call     0x1d0da10 ; Enemy.EnePartsGroup Enemy.PawnEnemy::GetParts(Int32)
01da205e  test     rax, rax
01da2061  je       0x1da2a1f
01da2067  mov      rcx, qword ptr [rip + 0x260fb0a] ; [43b1b78] TypeInfo#37312
01da206e  cmp      byte ptr [rax + 0x9a], r14b
01da2075  jne      0x1da221e
01da207b  cmp      dword ptr [rcx + 0xe4], r14d
01da2082  jne      0x1da2090
01da2084  call     0x4e0d90 ; il2cpp_class_init
01da2089  mov      rcx, qword ptr [rip + 0x260fae8] ; [43b1b78] TypeInfo#37312
01da2090  mov      rax, qword ptr [rcx + 0xb8]
01da2097  movss    xmm0, dword ptr [rax + 0x10c]
01da209f  comiss   xmm0, xmm6
01da20a2  jbe      0x1da2179
01da20a8  movss    xmm7, dword ptr [rbx + 0x318]
01da20b0  cmp      dword ptr [rcx + 0xe4], r14d
01da20b7  jne      0x1da20c5
01da20b9  call     0x4e0d90 ; il2cpp_class_init
01da20be  mov      rcx, qword ptr [rip + 0x260fab3] ; [43b1b78] TypeInfo#37312
01da20c5  mov      rax, qword ptr [rcx + 0xb8]
01da20cc  comiss   xmm7, dword ptr [rax + 0x10c]
01da20d3  jb       0x1da2179
01da20d9  xor      r8d, r8d
01da20dc  mov      edx, 2
01da20e1  mov      rcx, rbx
01da20e4  call     0x1db9840 ; Enemy.BulletTemplate Enemy.Ene_BosBase::GetBT(Int32)
01da20e9  mov      rdi, qword ptr [rbx + 0xb8]
01da20f0  xor      edx, edx
01da20f2  mov      rcx, rbx
01da20f5  mov      rsi, rax
01da20f8  call     0x1d11bc0 ; Threading.CancellationToken Enemy.PawnEnemy::get_CToken()
01da20fd  mov      rcx, qword ptr [rbx + 0x280]
01da2104  test     rcx, rcx
01da2107  je       0x1da2a1f
01da210d  cmp      dword ptr [rcx + 0x18], 4
01da2111  jbe      0x1da2a25
01da2117  mov      rdx, qword ptr [rcx + 0x40]
01da211b  test     rdi, rdi
01da211e  je       0x1da2a1f
01da2124  mov      qword ptr [rsp + 0x58], r14
01da2129  lea      rcx, [rbp + 0x17]
01da212d  mov      qword ptr [rsp + 0x50], r14
01da2132  mov      r9, rsi
01da2135  mov      dword ptr [rsp + 0x48], r14d
01da213a  mov      r8, rax
01da213d  movss    dword ptr [rsp + 0x40], xmm8
01da2144  mov      qword ptr [rsp + 0x38], r14
01da2149  mov      qword ptr [rsp + 0x30], rdx
01da214e  mov      rdx, rdi
01da2151  mov      byte ptr [rsp + 0x28], r14b
01da2156  mov      byte ptr [rsp + 0x20], r14b
01da215b  call     0x1cd8fe0 ; Cysharp.Threading.Tasks.UniTask InGameEnemyMoveBase::BulletFireAsync(Threading.CancellationToken,Enemy.BulletTemplate,Boolean,Boolean,Transform,Transform,Single,Int32,Action`1<InGameBulletInterface>)
01da2160  xor      edx, edx
01da2162  lea      rcx, [rbp + 0x17]
01da2166  movups   xmm0, xmmword ptr [rax]
01da2169  movaps   xmmword ptr [rbp + 0x17], xmm0
01da216d  call     0x2742890 ; Void Cysharp.Threading.Tasks.UniTaskExtensions::Forget(Cysharp.Threading.Tasks.UniTask)
01da2172  mov      rcx, qword ptr [rip + 0x260f9ff] ; [43b1b78] TypeInfo#37312
01da2179  cmp      dword ptr [rcx + 0xe4], r14d
01da2180  jne      0x1da218e
01da2182  call     0x4e0d90 ; il2cpp_class_init
01da2187  mov      rcx, qword ptr [rip + 0x260f9ea] ; [43b1b78] TypeInfo#37312
01da218e  mov      rax, qword ptr [rcx + 0xb8]
01da2195  movss    xmm0, dword ptr [rax + 0x110]
01da219d  comiss   xmm0, xmm6
01da21a0  jbe      0x1da251a
01da21a6  movss    xmm7, dword ptr [rbx + 0x318]
01da21ae  cmp      dword ptr [rcx + 0xe4], r14d
01da21b5  jne      0x1da21c3
01da21b7  call     0x4e0d90 ; il2cpp_class_init
01da21bc  mov      rcx, qword ptr [rip + 0x260f9b5] ; [43b1b78] TypeInfo#37312
01da21c3  mov      rax, qword ptr [rcx + 0xb8]
01da21ca  comiss   xmm7, dword ptr [rax + 0x110]
01da21d1  jb       0x1da251a
01da21d7  xor      r8d, r8d
01da21da  mov      edx, 3
01da21df  mov      rcx, rbx
01da21e2  call     0x1db9840 ; Enemy.BulletTemplate Enemy.Ene_BosBase::GetBT(Int32)
01da21e7  mov      rdi, qword ptr [rbx + 0xb8]
01da21ee  xor      edx, edx
01da21f0  mov      rcx, rbx
01da21f3  mov      rsi, rax
01da21f6  call     0x1d11bc0 ; Threading.CancellationToken Enemy.PawnEnemy::get_CToken()
01da21fb  mov      rcx, qword ptr [rbx + 0x280]
01da2202  test     rcx, rcx
01da2205  je       0x1da2a1f
01da220b  cmp      dword ptr [rcx + 0x18], 5
01da220f  jbe      0x1da2a25
01da2215  mov      rdx, qword ptr [rcx + 0x48]
01da2219  jmp      0x1da24c3
01da221e  cmp      dword ptr [rcx + 0xe4], r14d
01da2225  jne      0x1da2233
01da2227  call     0x4e0d90 ; il2cpp_class_init
01da222c  mov      rcx, qword ptr [rip + 0x260f945] ; [43b1b78] TypeInfo#37312
01da2233  mov      rax, qword ptr [rcx + 0xb8]
01da223a  movss    xmm0, dword ptr [rax + 0x114]
01da2242  comiss   xmm0, xmm6
01da2245  jbe      0x1da231f
01da224b  movss    xmm7, dword ptr [rbx + 0x318]
01da2253  cmp      dword ptr [rcx + 0xe4], r14d
01da225a  jne      0x1da2268
01da225c  call     0x4e0d90 ; il2cpp_class_init
01da2261  mov      rcx, qword ptr [rip + 0x260f910] ; [43b1b78] TypeInfo#37312
01da2268  mov      rax, qword ptr [rcx + 0xb8]
01da226f  comiss   xmm7, dword ptr [rax + 0x114]
01da2276  jb       0x1da231f
01da227c  xor      r8d, r8d
01da227f  mov      edx, 4
01da2284  mov      rcx, rbx
01da2287  call     0x1db9840 ; Enemy.BulletTemplate Enemy.Ene_BosBase::GetBT(Int32)
01da228c  mov      rdi, qword ptr [rbx + 0xb8]
01da2293  xor      edx, edx
01da2295  mov      rcx, rbx
01da2298  mov      rsi, rax
01da229b  call     0x1d11bc0 ; Threading.CancellationToken Enemy.PawnEnemy::get_CToken()
01da22a0  mov      rcx, qword ptr [rbx + 0x280]
01da22a7  test     rcx, rcx
01da22aa  je       0x1da2a1f
01da22b0  cmp      dword ptr [rcx + 0x18], 0x10
01da22b4  jbe      0x1da2a25
01da22ba  mov      rdx, qword ptr [rcx + 0xa0]
01da22c1  test     rdi, rdi
01da22c4  je       0x1da2a1f
01da22ca  mov      qword ptr [rsp + 0x58], r14
01da22cf  lea      rcx, [rbp + 0x17]
01da22d3  mov      qword ptr [rsp + 0x50], r14
01da22d8  mov      r9, rsi
01da22db  mov      dword ptr [rsp + 0x48], r14d
01da22e0  mov      r8, rax
01da22e3  movss    dword ptr [rsp + 0x40], xmm8
01da22ea  mov      qword ptr [rsp + 0x38], r14
01da22ef  mov      qword ptr [rsp + 0x30], rdx
01da22f4  mov      rdx, rdi
01da22f7  mov      byte ptr [rsp + 0x28], r14b
01da22fc  mov      byte ptr [rsp + 0x20], r14b
01da2301  call     0x1cd8fe0 ; Cysharp.Threading.Tasks.UniTask InGameEnemyMoveBase::BulletFireAsync(Threading.CancellationToken,Enemy.BulletTemplate,Boolean,Boolean,Transform,Transform,Single,Int32,Action`1<InGameBulletInterface>)
01da2306  xor      edx, edx
01da2308  lea      rcx, [rbp + 0x17]
01da230c  movups   xmm0, xmmword ptr [rax]
01da230f  movaps   xmmword ptr [rbp + 0x17], xmm0
01da2313  call     0x2742890 ; Void Cysharp.Threading.Tasks.UniTaskExtensions::Forget(Cysharp.Threading.Tasks.UniTask)
01da2318  mov      rcx, qword ptr [rip + 0x260f859] ; [43b1b78] TypeInfo#37312
01da231f  cmp      dword ptr [rcx + 0xe4], r14d
01da2326  jne      0x1da2334
01da2328  call     0x4e0d90 ; il2cpp_class_init
01da232d  mov      rcx, qword ptr [rip + 0x260f844] ; [43b1b78] TypeInfo#37312
01da2334  mov      rax, qword ptr [rcx + 0xb8]
01da233b  movss    xmm0, dword ptr [rax + 0x118]
01da2343  comiss   xmm0, xmm6
01da2346  jbe      0x1da2420
01da234c  movss    xmm7, dword ptr [rbx + 0x318]
01da2354  cmp      dword ptr [rcx + 0xe4], r14d
01da235b  jne      0x1da2369
01da235d  call     0x4e0d90 ; il2cpp_class_init
01da2362  mov      rcx, qword ptr [rip + 0x260f80f] ; [43b1b78] TypeInfo#37312
01da2369  mov      rax, qword ptr [rcx + 0xb8]
01da2370  comiss   xmm7, dword ptr [rax + 0x118]
01da2377  jb       0x1da2420
01da237d  xor      r8d, r8d
01da2380  mov      edx, 4
01da2385  mov      rcx, rbx
01da2388  call     0x1db9840 ; Enemy.BulletTemplate Enemy.Ene_BosBase::GetBT(Int32)
01da238d  mov      rdi, qword ptr [rbx + 0xb8]
01da2394  xor      edx, edx
01da2396  mov      rcx, rbx
01da2399  mov      rsi, rax
01da239c  call     0x1d11bc0 ; Threading.CancellationToken Enemy.PawnEnemy::get_CToken()
01da23a1  mov      rcx, qword ptr [rbx + 0x280]
01da23a8  test     rcx, rcx
01da23ab  je       0x1da2a1f
01da23b1  cmp      dword ptr [rcx + 0x18], 0xe
01da23b5  jbe      0x1da2a25
01da23bb  mov      rdx, qword ptr [rcx + 0x90]
01da23c2  test     rdi, rdi
01da23c5  je       0x1da2a1f
01da23cb  mov      qword ptr [rsp + 0x58], r14
01da23d0  lea      rcx, [rbp + 0x17]
01da23d4  mov      qword ptr [rsp + 0x50], r14
01da23d9  mov      r9, rsi
01da23dc  mov      dword ptr [rsp + 0x48], r14d
01da23e1  mov      r8, rax
01da23e4  movss    dword ptr [rsp + 0x40], xmm8
01da23eb  mov      qword ptr [rsp + 0x38], r14
01da23f0  mov      qword ptr [rsp + 0x30], rdx
01da23f5  mov      rdx, rdi
01da23f8  mov      byte ptr [rsp + 0x28], r14b
01da23fd  mov      byte ptr [rsp + 0x20], r14b
01da2402  call     0x1cd8fe0 ; Cysharp.Threading.Tasks.UniTask InGameEnemyMoveBase::BulletFireAsync(Threading.CancellationToken,Enemy.BulletTemplate,Boolean,Boolean,Transform,Transform,Single,Int32,Action`1<InGameBulletInterface>)
01da2407  xor      edx, edx
01da2409  lea      rcx, [rbp + 0x17]
01da240d  movups   xmm0, xmmword ptr [rax]
01da2410  movaps   xmmword ptr [rbp + 0x17], xmm0
01da2414  call     0x2742890 ; Void Cysharp.Threading.Tasks.UniTaskExtensions::Forget(Cysharp.Threading.Tasks.UniTask)
01da2419  mov      rcx, qword ptr [rip + 0x260f758] ; [43b1b78] TypeInfo#37312
01da2420  cmp      dword ptr [rcx + 0xe4], r14d
01da2427  jne      0x1da2435
01da2429  call     0x4e0d90 ; il2cpp_class_init
01da242e  mov      rcx, qword ptr [rip + 0x260f743] ; [43b1b78] TypeInfo#37312
01da2435  mov      rax, qword ptr [rcx + 0xb8]
01da243c  movss    xmm0, dword ptr [rax + 0x11c]
01da2444  comiss   xmm0, xmm6
01da2447  jbe      0x1da251a
01da244d  movss    xmm7, dword ptr [rbx + 0x318]
01da2455  cmp      dword ptr [rcx + 0xe4], r14d
01da245c  jne      0x1da246a
01da245e  call     0x4e0d90 ; il2cpp_class_init
01da2463  mov      rcx, qword ptr [rip + 0x260f70e] ; [43b1b78] TypeInfo#37312
01da246a  mov      rax, qword ptr [rcx + 0xb8]
01da2471  comiss   xmm7, dword ptr [rax + 0x11c]
01da2478  jb       0x1da251a
01da247e  xor      r8d, r8d
01da2481  mov      edx, 4
01da2486  mov      rcx, rbx
01da2489  call     0x1db9840 ; Enemy.BulletTemplate Enemy.Ene_BosBase::GetBT(Int32)
01da248e  mov      rdi, qword ptr [rbx + 0xb8]
01da2495  xor      edx, edx
01da2497  mov      rcx, rbx
01da249a  mov      rsi, rax
01da249d  call     0x1d11bc0 ; Threading.CancellationToken Enemy.PawnEnemy::get_CToken()
01da24a2  mov      rcx, qword ptr [rbx + 0x280]
01da24a9  test     rcx, rcx
01da24ac  je       0x1da2a1f
01da24b2  cmp      dword ptr [rcx + 0x18], 0xc
01da24b6  jbe      0x1da2a25
01da24bc  mov      rdx, qword ptr [rcx + 0x80]
01da24c3  test     rdi, rdi
01da24c6  je       0x1da2a1f
01da24cc  mov      qword ptr [rsp + 0x58], r14
01da24d1  lea      rcx, [rbp + 0x17]
01da24d5  mov      qword ptr [rsp + 0x50], r14
01da24da  mov      r9, rsi
01da24dd  mov      dword ptr [rsp + 0x48], r14d
01da24e2  mov      r8, rax
01da24e5  movss    dword ptr [rsp + 0x40], xmm8
01da24ec  mov      qword ptr [rsp + 0x38], r14
01da24f1  mov      qword ptr [rsp + 0x30], rdx
01da24f6  mov      rdx, rdi
01da24f9  mov      byte ptr [rsp + 0x28], r14b
01da24fe  mov      byte ptr [rsp + 0x20], r14b
01da2503  call     0x1cd8fe0 ; Cysharp.Threading.Tasks.UniTask InGameEnemyMoveBase::BulletFireAsync(Threading.CancellationToken,Enemy.BulletTemplate,Boolean,Boolean,Transform,Transform,Single,Int32,Action`1<InGameBulletInterface>)
01da2508  xor      edx, edx
01da250a  lea      rcx, [rbp + 0x17]
01da250e  movups   xmm0, xmmword ptr [rax]
01da2511  movaps   xmmword ptr [rbp + 0x17], xmm0
01da2515  call     0x2742890 ; Void Cysharp.Threading.Tasks.UniTaskExtensions::Forget(Cysharp.Threading.Tasks.UniTask)
01da251a  cmp      byte ptr [rbx + 0x315], r14b
01da2521  jne      0x1da2749
01da2527  xor      r8d, r8d
01da252a  mov      edx, 2
01da252f  mov      rcx, rbx
01da2532  call     0x1d0da10 ; Enemy.EnePartsGroup Enemy.PawnEnemy::GetParts(Int32)
01da2537  test     rax, rax
01da253a  je       0x1da2a1f
01da2540  mov      rcx, qword ptr [rip + 0x260f631] ; [43b1b78] TypeInfo#37312
01da2547  cmp      byte ptr [rax + 0x9a], r14b
01da254e  jne      0x1da277d
01da2554  cmp      dword ptr [rcx + 0xe4], r14d
01da255b  jne      0x1da2569
01da255d  call     0x4e0d90 ; il2cpp_class_init
01da2562  mov      rcx, qword ptr [rip + 0x260f60f] ; [43b1b78] TypeInfo#37312
01da2569  mov      rax, qword ptr [rcx + 0xb8]
01da2570  movss    xmm0, dword ptr [rax + 0x10c]
01da2578  comiss   xmm0, xmm6
01da257b  jbe      0x1da2652
01da2581  movss    xmm7, dword ptr [rbx + 0x318]
01da2589  cmp      dword ptr [rcx + 0xe4], r14d
01da2590  jne      0x1da259e
01da2592  call     0x4e0d90 ; il2cpp_class_init
01da2597  mov      rcx, qword ptr [rip + 0x260f5da] ; [43b1b78] TypeInfo#37312
01da259e  mov      rax, qword ptr [rcx + 0xb8]
01da25a5  comiss   xmm7, dword ptr [rax + 0x10c]
01da25ac  jb       0x1da2652
01da25b2  xor      r8d, r8d
01da25b5  mov      edx, 2
01da25ba  mov      rcx, rbx
01da25bd  call     0x1db9840 ; Enemy.BulletTemplate Enemy.Ene_BosBase::GetBT(Int32)
01da25c2  mov      rdi, qword ptr [rbx + 0xb8]
01da25c9  xor      edx, edx
01da25cb  mov      rcx, rbx
01da25ce  mov      rsi, rax
01da25d1  call     0x1d11bc0 ; Threading.CancellationToken Enemy.PawnEnemy::get_CToken()
01da25d6  mov      rcx, qword ptr [rbx + 0x280]
01da25dd  test     rcx, rcx
01da25e0  je       0x1da2a1f
01da25e6  cmp      dword ptr [rcx + 0x18], 6
01da25ea  jbe      0x1da2a25
01da25f0  mov      rdx, qword ptr [rcx + 0x50]
01da25f4  test     rdi, rdi
01da25f7  je       0x1da2a1f
01da25fd  mov      qword ptr [rsp + 0x58], r14
01da2602  lea      rcx, [rbp + 0x17]
01da2606  mov      qword ptr [rsp + 0x50], r14
01da260b  mov      r9, rsi
01da260e  mov      dword ptr [rsp + 0x48], r14d
01da2613  mov      r8, rax
01da2616  movss    dword ptr [rsp + 0x40], xmm8
01da261d  mov      qword ptr [rsp + 0x38], r14
01da2622  mov      qword ptr [rsp + 0x30], rdx
01da2627  mov      rdx, rdi
01da262a  mov      byte ptr [rsp + 0x28], r14b
01da262f  mov      byte ptr [rsp + 0x20], r14b
01da2634  call     0x1cd8fe0 ; Cysharp.Threading.Tasks.UniTask InGameEnemyMoveBase::BulletFireAsync(Threading.CancellationToken,Enemy.BulletTemplate,Boolean,Boolean,Transform,Transform,Single,Int32,Action`1<InGameBulletInterface>)
01da2639  xor      edx, edx
01da263b  lea      rcx, [rbp + 0x17]
01da263f  movups   xmm0, xmmword ptr [rax]
01da2642  movaps   xmmword ptr [rbp + 0x17], xmm0
01da2646  call     0x2742890 ; Void Cysharp.Threading.Tasks.UniTaskExtensions::Forget(Cysharp.Threading.Tasks.UniTask)
01da264b  mov      rcx, qword ptr [rip + 0x260f526] ; [43b1b78] TypeInfo#37312
01da2652  cmp      dword ptr [rcx + 0xe4], r14d
01da2659  jne      0x1da2667
01da265b  call     0x4e0d90 ; il2cpp_class_init
01da2660  mov      rcx, qword ptr [rip + 0x260f511] ; [43b1b78] TypeInfo#37312
01da2667  mov      rax, qword ptr [rcx + 0xb8]
01da266e  movss    xmm0, dword ptr [rax + 0x110]
01da2676  comiss   xmm0, xmm6
01da2679  jbe      0x1da2749
01da267f  movss    xmm6, dword ptr [rbx + 0x318]
01da2687  cmp      dword ptr [rcx + 0xe4], r14d
01da268e  jne      0x1da269c
01da2690  call     0x4e0d90 ; il2cpp_class_init
01da2695  mov      rcx, qword ptr [rip + 0x260f4dc] ; [43b1b78] TypeInfo#37312
01da269c  mov      rax, qword ptr [rcx + 0xb8]
01da26a3  comiss   xmm6, dword ptr [rax + 0x110]
01da26aa  jb       0x1da2749
01da26b0  xor      r8d, r8d
01da26b3  mov      edx, 3
01da26b8  mov      rcx, rbx
01da26bb  call     0x1db9840 ; Enemy.BulletTemplate Enemy.Ene_BosBase::GetBT(Int32)
01da26c0  mov      rdi, qword ptr [rbx + 0xb8]
01da26c7  xor      edx, edx
01da26c9  mov      rcx, rbx
01da26cc  mov      rsi, rax
01da26cf  call     0x1d11bc0 ; Threading.CancellationToken Enemy.PawnEnemy::get_CToken()
01da26d4  mov      rcx, qword ptr [rbx + 0x280]
01da26db  test     rcx, rcx
01da26de  je       0x1da2a1f
01da26e4  cmp      dword ptr [rcx + 0x18], 7
01da26e8  jbe      0x1da2a25
01da26ee  mov      rdx, qword ptr [rcx + 0x58]
01da26f2  test     rdi, rdi
01da26f5  je       0x1da2a1f
01da26fb  mov      qword ptr [rsp + 0x58], r14
01da2700  lea      rcx, [rbp + 0x17]
01da2704  mov      qword ptr [rsp + 0x50], r14
01da2709  mov      r9, rsi
01da270c  mov      dword ptr [rsp + 0x48], r14d
01da2711  mov      r8, rax
01da2714  movss    dword ptr [rsp + 0x40], xmm8
01da271b  mov      qword ptr [rsp + 0x38], r14
01da2720  mov      qword ptr [rsp + 0x30], rdx
01da2725  mov      rdx, rdi
01da2728  mov      byte ptr [rsp + 0x28], r14b
01da272d  mov      byte ptr [rsp + 0x20], r14b
01da2732  call     0x1cd8fe0 ; Cysharp.Threading.Tasks.UniTask InGameEnemyMoveBase::BulletFireAsync(Threading.CancellationToken,Enemy.BulletTemplate,Boolean,Boolean,Transform,Transform,Single,Int32,Action`1<InGameBulletInterface>)
01da2737  xor      edx, edx
01da2739  lea      rcx, [rbp + 0x17]
01da273d  movups   xmm0, xmmword ptr [rax]
01da2740  movaps   xmmword ptr [rbp + 0x17], xmm0
01da2744  call     0x2742890 ; Void Cysharp.Threading.Tasks.UniTaskExtensions::Forget(Cysharp.Threading.Tasks.UniTask)
01da2749  mov      rdi, qword ptr [rsp + 0xb8]
01da2751  lea      r11, [rsp + 0xa0]
01da2759  mov      rbx, qword ptr [r11 + 0x20]
01da275d  mov      r14, qword ptr [r11 + 0x28]
01da2761  movaps   xmm6, xmmword ptr [r11 - 0x10]
01da2766  movaps   xmm7, xmmword ptr [r11 - 0x20]
01da276b  movaps   xmm8, xmmword ptr [r11 - 0x30]
01da2770  mov      rsi, qword ptr [rsp + 0xb0]
01da2778  mov      rsp, r11
01da277b  pop      rbp
01da277c  ret      
01da277d  cmp      dword ptr [rcx + 0xe4], r14d
01da2784  jne      0x1da2792
01da2786  call     0x4e0d90 ; il2cpp_class_init
01da278b  mov      rcx, qword ptr [rip + 0x260f3e6] ; [43b1b78] TypeInfo#37312
01da2792  mov      rax, qword ptr [rcx + 0xb8]
01da2799  movss    xmm0, dword ptr [rax + 0x114]
01da27a1  comiss   xmm0, xmm6
01da27a4  jbe      0x1da287e
01da27aa  movss    xmm7, dword ptr [rbx + 0x318]
01da27b2  cmp      dword ptr [rcx + 0xe4], r14d
01da27b9  jne      0x1da27c7
01da27bb  call     0x4e0d90 ; il2cpp_class_init
01da27c0  mov      rcx, qword ptr [rip + 0x260f3b1] ; [43b1b78] TypeInfo#37312
01da27c7  mov      rax, qword ptr [rcx + 0xb8]
01da27ce  comiss   xmm7, dword ptr [rax + 0x114]
01da27d5  jb       0x1da287e
01da27db  xor      r8d, r8d
01da27de  mov      edx, 4
01da27e3  mov      rcx, rbx
01da27e6  call     0x1db9840 ; Enemy.BulletTemplate Enemy.Ene_BosBase::GetBT(Int32)
01da27eb  mov      rdi, qword ptr [rbx + 0xb8]
01da27f2  xor      edx, edx
01da27f4  mov      rcx, rbx
01da27f7  mov      rsi, rax
01da27fa  call     0x1d11bc0 ; Threading.CancellationToken Enemy.PawnEnemy::get_CToken()
01da27ff  mov      rcx, qword ptr [rbx + 0x280]
01da2806  test     rcx, rcx
01da2809  je       0x1da2a1f
01da280f  cmp      dword ptr [rcx + 0x18], 0x11
01da2813  jbe      0x1da2a25
01da2819  mov      rdx, qword ptr [rcx + 0xa8]
01da2820  test     rdi, rdi
01da2823  je       0x1da2a1f
01da2829  mov      qword ptr [rsp + 0x58], r14
01da282e  lea      rcx, [rbp + 0x17]
01da2832  mov      qword ptr [rsp + 0x50], r14
01da2837  mov      r9, rsi
01da283a  mov      dword ptr [rsp + 0x48], r14d
01da283f  mov      r8, rax
01da2842  movss    dword ptr [rsp + 0x40], xmm8
01da2849  mov      qword ptr [rsp + 0x38], r14
01da284e  mov      qword ptr [rsp + 0x30], rdx
01da2853  mov      rdx, rdi
01da2856  mov      byte ptr [rsp + 0x28], r14b
01da285b  mov      byte ptr [rsp + 0x20], r14b
01da2860  call     0x1cd8fe0 ; Cysharp.Threading.Tasks.UniTask InGameEnemyMoveBase::BulletFireAsync(Threading.CancellationToken,Enemy.BulletTemplate,Boolean,Boolean,Transform,Transform,Single,Int32,Action`1<InGameBulletInterface>)
01da2865  xor      edx, edx
01da2867  lea      rcx, [rbp + 0x17]
01da286b  movups   xmm0, xmmword ptr [rax]
01da286e  movaps   xmmword ptr [rbp + 0x17], xmm0
01da2872  call     0x2742890 ; Void Cysharp.Threading.Tasks.UniTaskExtensions::Forget(Cysharp.Threading.Tasks.UniTask)
01da2877  mov      rcx, qword ptr [rip + 0x260f2fa] ; [43b1b78] TypeInfo#37312
01da287e  cmp      dword ptr [rcx + 0xe4], r14d
01da2885  jne      0x1da2893
01da2887  call     0x4e0d90 ; il2cpp_class_init
01da288c  mov      rcx, qword ptr [rip + 0x260f2e5] ; [43b1b78] TypeInfo#37312
01da2893  mov      rax, qword ptr [rcx + 0xb8]
01da289a  movss    xmm0, dword ptr [rax + 0x118]
01da28a2  comiss   xmm0, xmm6
01da28a5  jbe      0x1da297f
01da28ab  movss    xmm7, dword ptr [rbx + 0x318]
01da28b3  cmp      dword ptr [rcx + 0xe4], r14d
01da28ba  jne      0x1da28c8
01da28bc  call     0x4e0d90 ; il2cpp_class_init
01da28c1  mov      rcx, qword ptr [rip + 0x260f2b0] ; [43b1b78] TypeInfo#37312
01da28c8  mov      rax, qword ptr [rcx + 0xb8]
01da28cf  comiss   xmm7, dword ptr [rax + 0x118]
01da28d6  jb       0x1da297f
01da28dc  xor      r8d, r8d
01da28df  mov      edx, 4
01da28e4  mov      rcx, rbx
01da28e7  call     0x1db9840 ; Enemy.BulletTemplate Enemy.Ene_BosBase::GetBT(Int32)
01da28ec  mov      rdi, qword ptr [rbx + 0xb8]
01da28f3  xor      edx, edx
01da28f5  mov      rcx, rbx
01da28f8  mov      rsi, rax
01da28fb  call     0x1d11bc0 ; Threading.CancellationToken Enemy.PawnEnemy::get_CToken()
01da2900  mov      rcx, qword ptr [rbx + 0x280]
01da2907  test     rcx, rcx
01da290a  je       0x1da2a1f
01da2910  cmp      dword ptr [rcx + 0x18], 0xf
01da2914  jbe      0x1da2a25
01da291a  mov      rdx, qword ptr [rcx + 0x98]
01da2921  test     rdi, rdi
01da2924  je       0x1da2a1f
01da292a  mov      qword ptr [rsp + 0x58], r14
01da292f  lea      rcx, [rbp + 0x17]
01da2933  mov      qword ptr [rsp + 0x50], r14
01da2938  mov      r9, rsi
01da293b  mov      dword ptr [rsp + 0x48], r14d
01da2940  mov      r8, rax
01da2943  movss    dword ptr [rsp + 0x40], xmm8
01da294a  mov      qword ptr [rsp + 0x38], r14
01da294f  mov      qword ptr [rsp + 0x30], rdx
01da2954  mov      rdx, rdi
01da2957  mov      byte ptr [rsp + 0x28], r14b
01da295c  mov      byte ptr [rsp + 0x20], r14b
01da2961  call     0x1cd8fe0 ; Cysharp.Threading.Tasks.UniTask InGameEnemyMoveBase::BulletFireAsync(Threading.CancellationToken,Enemy.BulletTemplate,Boolean,Boolean,Transform,Transform,Single,Int32,Action`1<InGameBulletInterface>)
01da2966  xor      edx, edx
01da2968  lea      rcx, [rbp + 0x17]
01da296c  movups   xmm0, xmmword ptr [rax]
01da296f  movaps   xmmword ptr [rbp + 0x17], xmm0
01da2973  call     0x2742890 ; Void Cysharp.Threading.Tasks.UniTaskExtensions::Forget(Cysharp.Threading.Tasks.UniTask)
01da2978  mov      rcx, qword ptr [rip + 0x260f1f9] ; [43b1b78] TypeInfo#37312
01da297f  cmp      dword ptr [rcx + 0xe4], r14d
01da2986  jne      0x1da2994
01da2988  call     0x4e0d90 ; il2cpp_class_init
01da298d  mov      rcx, qword ptr [rip + 0x260f1e4] ; [43b1b78] TypeInfo#37312
01da2994  mov      rax, qword ptr [rcx + 0xb8]
01da299b  movss    xmm0, dword ptr [rax + 0x11c]
01da29a3  comiss   xmm0, xmm6
01da29a6  jbe      0x1da2749
01da29ac  movss    xmm6, dword ptr [rbx + 0x318]
01da29b4  cmp      dword ptr [rcx + 0xe4], r14d
01da29bb  jne      0x1da29c9
01da29bd  call     0x4e0d90 ; il2cpp_class_init
01da29c2  mov      rcx, qword ptr [rip + 0x260f1af] ; [43b1b78] TypeInfo#37312
01da29c9  mov      rax, qword ptr [rcx + 0xb8]
01da29d0  comiss   xmm6, dword ptr [rax + 0x11c]
01da29d7  jb       0x1da2749
01da29dd  xor      r8d, r8d
01da29e0  mov      edx, 4
01da29e5  mov      rcx, rbx
01da29e8  call     0x1db9840 ; Enemy.BulletTemplate Enemy.Ene_BosBase::GetBT(Int32)
01da29ed  mov      rdi, qword ptr [rbx + 0xb8]
01da29f4  xor      edx, edx
01da29f6  mov      rcx, rbx
01da29f9  mov      rsi, rax
01da29fc  call     0x1d11bc0 ; Threading.CancellationToken Enemy.PawnEnemy::get_CToken()
01da2a01  mov      rcx, qword ptr [rbx + 0x280]
01da2a08  test     rcx, rcx
01da2a0b  je       0x1da2a1f
01da2a0d  cmp      dword ptr [rcx + 0x18], 0xd
01da2a11  jbe      0x1da2a25
01da2a13  mov      rdx, qword ptr [rcx + 0x88]
01da2a1a  jmp      0x1da26f2
01da2a1f  call     0x4e0d00 ; ThrowNullRef
01da2a24  int3     
01da2a25  call     0x4e0cf0 ; ?
01da2a2a  int3     
01da2a2b  int3     
01da2a2c  int3     
01da2a2d  int3     
01da2a2e  int3     
01da2a2f  int3     

### Void Enemy.Ene_Bos07::PatternMove4(Single)  RVA=0x1DA3D30 len=0x920
01da3d30  mov      qword ptr [rsp + 0x20], rbx
01da3d35  push     rbp
01da3d36  lea      rbp, [rsp - 0x57]
01da3d3b  sub      rsp, 0xc0
01da3d42  cmp      byte ptr [rip + 0x28bfacc], 0 ; [4663815] bss
01da3d49  mov      rbx, rcx
01da3d4c  movaps   xmmword ptr [rsp + 0xb0], xmm6
01da3d54  movaps   xmm6, xmm1
01da3d57  jne      0x1da3d78
01da3d59  lea      rcx, [rip + 0x260de18] ; [43b1b78] TypeInfo#37312
01da3d60  call     0x4e0a50 ; il2cpp_init_metadata
01da3d65  lea      rcx, [rip + 0x25fe5fc] ; [43a2368] TypeInfo#45781
01da3d6c  call     0x4e0a50 ; il2cpp_init_metadata
01da3d71  mov      byte ptr [rip + 0x28bfa9d], 1 ; [4663815] bss
01da3d78  mov      qword ptr [rsp + 0xd0], rsi
01da3d80  xor      edx, edx
01da3d82  mov      qword ptr [rsp + 0xd8], rdi
01da3d8a  mov      rcx, rbx
01da3d8d  mov      qword ptr [rsp + 0xe0], r14
01da3d95  movaps   xmmword ptr [rsp + 0xa0], xmm7
01da3d9d  movaps   xmmword ptr [rsp + 0x90], xmm8
01da3da6  movaps   xmmword ptr [rsp + 0x80], xmm9
01da3daf  call     0x1da1cf0 ; Boolean Enemy.Ene_Bos07::IsArmBrokenOrDifficultyUp()
01da3db4  test     al, al
01da3db6  jne      0x1da45fa
01da3dbc  movaps   xmm1, xmm6
01da3dbf  xor      r8d, r8d
01da3dc2  mulss    xmm1, dword ptr [rip + 0x1748b4e] ; [34ec918] f=360.0 d=1.4044481158322838e+306 v4=(360.0, inf, nan, nan)
01da3dca  mov      rcx, rbx
01da3dcd  mulss    xmm1, dword ptr [rbx + 0x32c]
01da3dd5  call     0x1da0fa0 ; Void Enemy.Ene_Bos07::FaceCoverRotate(Single)
01da3dda  mov      ecx, dword ptr [rbx + 0x1ec]
01da3de0  test     ecx, ecx
01da3de2  jne      0x1da3ee1
01da3de8  xor      r8d, r8d
01da3deb  mov      edx, 0x22
01da3df0  mov      rcx, rbx
01da3df3  call     0x1ccf580 ; Void InGameCollisionBase::SetObjectFlag(InGameObject/InGameObjectFlag)
01da3df8  mov      rcx, qword ptr [rip + 0x25fe569] ; [43a2368] TypeInfo#45781
01da3dff  cmp      dword ptr [rcx + 0xe4], 0
01da3e06  jne      0x1da3e0d
01da3e08  call     0x4e0d90 ; il2cpp_class_init
01da3e0d  xor      edx, edx
01da3e0f  mov      ecx, 0x58
01da3e14  call     0x2723de0 ; Void TXEKernel.Sound.SoundUtility::PlayQue(TXEKernel.Sound.SoundUtility/ID)
01da3e19  mov      rax, qword ptr [rip + 0x260dd58] ; [43b1b78] TypeInfo#37312
01da3e20  cmp      dword ptr [rax + 0xe4], 0
01da3e27  jne      0x1da3e38
01da3e29  mov      rcx, rax
01da3e2c  call     0x4e0d90 ; il2cpp_class_init
01da3e31  mov      rax, qword ptr [rip + 0x260dd40] ; [43b1b78] TypeInfo#37312
01da3e38  mov      rax, qword ptr [rax + 0xb8]
01da3e3f  xor      r9d, r9d
01da3e42  movss    xmm2, dword ptr [rip + 0x173cd82] ; [34e0bcc] f=1.0 d=50.12387841939926 v4=(1.0, 3.141593, 4.0, 10.0)
01da3e4a  mov      rcx, rbx
01da3e4d  movss    xmm1, dword ptr [rax + 0x120]
01da3e55  call     0x1dba4d0 ; Void Enemy.Ene_BosBase::SetDirectionTime(Single,Single)
01da3e5a  mov      rdx, qword ptr [rbx + 0x50]
01da3e5e  test     rdx, rdx
01da3e61  je       0x1da463f
01da3e67  xor      r8d, r8d
01da3e6a  lea      rcx, [rbp + 7]
01da3e6e  call     0x3093700 ; Vector3 Transform::get_localPosition()
01da3e73  mov      ecx, dword ptr [rax + 8]
01da3e76  movsd    xmm0, qword ptr [rax]
01da3e7a  movsd    qword ptr [rbx + 0x340], xmm0
01da3e82  mov      dword ptr [rbx + 0x348], ecx
01da3e88  xor      ecx, ecx
01da3e8a  inc      dword ptr [rbx + 0x1ec]
01da3e90  mov      dword ptr [rbx + 0x32c], ecx
01da3e96  movaps   xmm9, xmmword ptr [rsp + 0x80]
01da3e9f  movaps   xmm8, xmmword ptr [rsp + 0x90]
01da3ea8  movaps   xmm7, xmmword ptr [rsp + 0xa0]
01da3eb0  mov      r14, qword ptr [rsp + 0xe0]
01da3eb8  mov      rdi, qword ptr [rsp + 0xd8]
01da3ec0  mov      rsi, qword ptr [rsp + 0xd0]
01da3ec8  mov      rbx, qword ptr [rsp + 0xe8]
01da3ed0  movaps   xmm6, xmmword ptr [rsp + 0xb0]
01da3ed8  add      rsp, 0xc0
01da3edf  pop      rbp
01da3ee0  ret      
01da3ee1  cmp      ecx, 1
01da3ee4  jne      0x1da41af
01da3eea  xor      edx, edx
01da3eec  mov      rcx, rbx
01da3eef  call     0x1db9a20 ; Single Enemy.Ene_BosBase::GetDirectionRate()
01da3ef4  xor      edx, edx
01da3ef6  movaps   xmm9, xmm0
01da3efa  call     0x1de85f0 ; Single KANAI.Kernel.EasingUtility::InCubic01(Single)
01da3eff  mov      rcx, qword ptr [rip + 0x260dc72] ; [43b1b78] TypeInfo#37312
01da3f06  movaps   xmm6, xmm0
01da3f09  mov      rdi, qword ptr [rbx + 0x2a0]
01da3f10  cmp      dword ptr [rcx + 0xe4], 0
01da3f17  jne      0x1da3f25
01da3f19  call     0x4e0d90 ; il2cpp_class_init
01da3f1e  mov      rcx, qword ptr [rip + 0x260dc53] ; [43b1b78] TypeInfo#37312
01da3f25  mov      rax, qword ptr [rcx + 0xb8]
01da3f2c  xorps    xmm8, xmm8
01da3f30  comiss   xmm8, xmm6
01da3f34  mov      edx, dword ptr [rax + 0x24]
01da3f37  movsd    xmm1, qword ptr [rax + 0x1c]
01da3f3c  movsd    xmm0, qword ptr [rax + 0x10]
01da3f41  movss    xmm7, dword ptr [rip + 0x173cc83] ; [34e0bcc] f=1.0 d=50.12387841939926 v4=(1.0, 3.141593, 4.0, 10.0)
01da3f49  movsd    qword ptr [rbp - 9], xmm1
01da3f4e  movsd    qword ptr [rbp + 7], xmm0
01da3f53  ja       0x1da3f64
01da3f55  comiss   xmm6, xmm7
01da3f58  ja       0x1da3f5f
01da3f5a  movaps   xmm1, xmm6
01da3f5d  jmp      0x1da3f67
01da3f5f  movaps   xmm1, xmm7
01da3f62  jmp      0x1da3f67
01da3f64  xorps    xmm1, xmm1
01da3f67  movss    xmm2, dword ptr [rbp - 9]
01da3f6c  movss    xmm3, dword ptr [rbp - 5]
01da3f71  movd     xmm4, edx
01da3f75  subss    xmm2, dword ptr [rbp + 7]
01da3f7a  subss    xmm3, dword ptr [rbp + 0xb]
01da3f7f  subss    xmm4, dword ptr [rax + 0x18]
01da3f84  mulss    xmm2, xmm1
01da3f88  mulss    xmm3, xmm1
01da3f8c  mulss    xmm4, xmm1
01da3f90  addss    xmm2, dword ptr [rbp + 7]
01da3f95  addss    xmm3, dword ptr [rbp + 0xb]
01da3f9a  addss    xmm4, dword ptr [rax + 0x18]
01da3f9f  test     rdi, rdi
01da3fa2  je       0x1da463f
01da3fa8  unpcklps xmm2, xmm3
01da3fab  lea      rdx, [rbp + 7]
01da3faf  xor      r8d, r8d
01da3fb2  movsd    qword ptr [rbp + 7], xmm2
01da3fb7  mov      rcx, rdi
01da3fba  movss    dword ptr [rbp + 0xf], xmm4
01da3fbf  call     0x3094570 ; Void Transform::set_localPosition(Vector3)
01da3fc4  comiss   xmm8, xmm6
01da3fc8  mov      rcx, qword ptr [rip + 0x260dba9] ; [43b1b78] TypeInfo#37312
01da3fcf  mov      r9, qword ptr [rbx + 0x2a8]
01da3fd6  mov      rax, qword ptr [rcx + 0xb8]
01da3fdd  movsd    xmm0, qword ptr [rax + 0x7c]
01da3fe2  mov      edx, dword ptr [rax + 0x84]
01da3fe8  movsd    qword ptr [rbp + 7], xmm0
01da3fed  movsd    xmm0, qword ptr [rax + 0x70]
01da3ff2  movsd    qword ptr [rbp - 9], xmm0
01da3ff7  ja       0x1da4003
01da3ff9  comiss   xmm6, xmm7
01da3ffc  jbe      0x1da4006
01da3ffe  movaps   xmm6, xmm7
01da4001  jmp      0x1da4006
01da4003  xorps    xmm6, xmm6
01da4006  movss    xmm1, dword ptr [rbp + 7]
01da400b  movss    xmm2, dword ptr [rbp + 0xb]
01da4010  movd     xmm3, edx
01da4014  subss    xmm1, dword ptr [rbp - 9]
01da4019  subss    xmm2, dword ptr [rbp - 5]
01da401e  subss    xmm3, dword ptr [rax + 0x78]
01da4023  mulss    xmm1, xmm6
01da4027  mulss    xmm2, xmm6
01da402b  mulss    xmm3, xmm6
01da402f  addss    xmm1, dword ptr [rbp - 9]
01da4034  addss    xmm2, dword ptr [rbp - 5]
01da4039  addss    xmm3, dword ptr [rax + 0x78]
01da403e  test     r9, r9
01da4041  je       0x1da463f
01da4047  unpcklps xmm1, xmm2
01da404a  lea      rdx, [rbp + 7]
01da404e  xor      r8d, r8d
01da4051  movsd    qword ptr [rbp + 7], xmm1
01da4056  mov      rcx, r9
01da4059  movss    dword ptr [rbp + 0xf], xmm3
01da405e  call     0x3094570 ; Void Transform::set_localPosition(Vector3)
01da4063  comiss   xmm9, xmm7
01da4067  movss    dword ptr [rbx + 0x32c], xmm9
01da4070  jb       0x1da40f6
01da4076  xor      r8d, r8d
01da4079  mov      edx, 0x22
01da407e  mov      rcx, rbx
01da4081  call     0x1ccf500 ; Void InGameCollisionBase::ResetObjectFlag(InGameObject/InGameObjectFlag)
01da4086  mov      rax, qword ptr [rip + 0x260daeb] ; [43b1b78] TypeInfo#37312
01da408d  cmp      dword ptr [rax + 0xe4], 0
01da4094  jne      0x1da40a5
01da4096  mov      rcx, rax
01da4099  call     0x4e0d90 ; il2cpp_class_init
01da409e  mov      rax, qword ptr [rip + 0x260dad3] ; [43b1b78] TypeInfo#37312
01da40a5  mov      rax, qword ptr [rax + 0xb8]
01da40ac  xor      r8d, r8d
01da40af  mov      rcx, rbx
01da40b2  movss    xmm1, dword ptr [rax + 0x134]
01da40ba  call     0x1dba580 ; Void Enemy.Ene_BosBase::SetRepeatTime(Single)
01da40bf  mov      rax, qword ptr [rip + 0x260dab2] ; [43b1b78] TypeInfo#37312
01da40c6  xor      r9d, r9d
01da40c9  movaps   xmm2, xmm7
01da40cc  mov      rcx, qword ptr [rax + 0xb8]
01da40d3  movss    xmm1, dword ptr [rcx + 0x130]
01da40db  mov      rcx, rbx
01da40de  call     0x1dba4d0 ; Void Enemy.Ene_BosBase::SetDirectionTime(Single,Single)
01da40e3  xor      ecx, ecx
01da40e5  mov      dword ptr [rbx + 0x1ec], 0xa
01da40ef  mov      qword ptr [rbx + 0x324], rcx
01da40f6  movsd    xmm8, qword ptr [rbx + 0x340]
01da40ff  xor      edx, edx
01da4101  mov      esi, dword ptr [rbx + 0x348]
01da4107  movaps   xmm0, xmm9
01da410b  mov      r14, qword ptr [rbx + 0x50]
01da410f  movaps   xmm7, xmm8
01da4113  movsd    xmm6, qword ptr [rbx + 0x228]
01da411b  mov      edi, esi
01da411d  mov      ebx, dword ptr [rbx + 0x230]
01da4123  call     0x1de86f0 ; Single KANAI.Kernel.EasingUtility::InOutSine01(Single)
01da4128  movsd    qword ptr [rbp + 7], xmm6
01da412d  movaps   xmm2, xmm0
01da4130  movsd    qword ptr [rbp + 7], xmm7
01da4135  movaps   xmm1, xmm7
01da4138  shufps   xmm1, xmm1, 0x55
01da413c  movaps   xmm0, xmm8
01da4140  shufps   xmm0, xmm0, 0x55
01da4144  movaps   xmm3, xmm6
01da4147  shufps   xmm3, xmm3, 0x55
01da414b  movaps   xmm4, xmm6
01da414e  movsd    qword ptr [rbp + 7], xmm8
01da4154  subss    xmm3, xmm1
01da4158  movd     xmm1, ebx
01da415c  subss    xmm4, xmm7
01da4160  mulss    xmm3, xmm2
01da4164  mulss    xmm4, xmm2
01da4168  addss    xmm3, xmm0
01da416c  movd     xmm0, esi
01da4170  subss    xmm1, xmm0
01da4174  movd     xmm0, esi
01da4178  addss    xmm4, xmm8
01da417d  mulss    xmm1, xmm2
01da4181  addss    xmm1, xmm0
01da4185  test     r14, r14
01da4188  je       0x1da463f
01da418e  unpcklps xmm4, xmm3
01da4191  lea      rdx, [rbp + 7]
01da4195  xor      r8d, r8d
01da4198  movsd    qword ptr [rbp + 7], xmm4
01da419d  mov      rcx, r14
01da41a0  movss    dword ptr [rbp + 0xf], xmm1
01da41a5  call     0x3094570 ; Void Transform::set_localPosition(Vector3)
01da41aa  jmp      0x1da3e96
01da41af  add      ecx, -0xa
01da41b2  je       0x1da44ed
01da41b8  sub      ecx, 1
01da41bb  je       0x1da4446
01da41c1  cmp      ecx, 1
01da41c4  jne      0x1da3e96
01da41ca  mov      rax, qword ptr [rip + 0x260d9a7] ; [43b1b78] TypeInfo#37312
01da41d1  cmp      dword ptr [rax + 0xe4], 0
01da41d8  jne      0x1da41e9
01da41da  mov      rcx, rax
01da41dd  call     0x4e0d90 ; il2cpp_class_init
01da41e2  mov      rax, qword ptr [rip + 0x260d98f] ; [43b1b78] TypeInfo#37312
01da41e9  mov      rax, qword ptr [rax + 0xb8]
01da41f0  xor      r9d, r9d
01da41f3  movaps   xmm1, xmm6
01da41f6  mov      rcx, rbx
01da41f9  movss    xmm2, dword ptr [rax + 0x124]
01da4201  call     0x1da6f60 ; Void Enemy.Ene_Bos07::<PatternMove4>g__UpdateMoveTime|129_0(Single,Single)
01da4206  cmp      byte ptr [rbx + 0x1dc], 0
01da420d  movss    xmm7, dword ptr [rip + 0x173c9b7] ; [34e0bcc] f=1.0 d=50.12387841939926 v4=(1.0, 3.141593, 4.0, 10.0)
01da4215  je       0x1da4361
01da421b  xor      r8d, r8d
01da421e  mov      edx, 8
01da4223  mov      rcx, rbx
01da4226  call     0x1db9840 ; Enemy.BulletTemplate Enemy.Ene_BosBase::GetBT(Int32)
01da422b  movss    xmm1, dword ptr [rip + 0x17486e1] ; [34ec914] f=3.0 d=1.4411521567102075e+18 v4=(3.0, 360.0, inf, nan)
01da4233  mov      rdi, rax
01da4236  movss    xmm0, dword ptr [rbx + 0x310]
01da423e  call     0x578cb0 ; fmodf
01da4243  xorps    xmm6, xmm6
01da4246  ucomiss  xmm0, xmm6
01da4249  jp       0x1da427e
01da424b  jne      0x1da427e
01da424d  mov      rsi, qword ptr [rbx + 0xb8]
01da4254  xor      edx, edx
01da4256  mov      rcx, rbx
01da4259  call     0x1d11bc0 ; Threading.CancellationToken Enemy.PawnEnemy::get_CToken()
01da425e  mov      rcx, qword ptr [rbx + 0x280]
01da4265  test     rcx, rcx
01da4268  je       0x1da463f
01da426e  cmp      dword ptr [rcx + 0x18], 8
01da4272  jbe      0x1da4645
01da4278  mov      rdx, qword ptr [rcx + 0x60]
01da427c  jmp      0x1da42f8
01da427e  ucomiss  xmm0, xmm7
01da4281  jp       0x1da42b6
01da4283  jne      0x1da42b6
01da4285  mov      rsi, qword ptr [rbx + 0xb8]
01da428c  xor      edx, edx
01da428e  mov      rcx, rbx
01da4291  call     0x1d11bc0 ; Threading.CancellationToken Enemy.PawnEnemy::get_CToken()
01da4296  mov      rcx, qword ptr [rbx + 0x280]
01da429d  test     rcx, rcx
01da42a0  je       0x1da463f
01da42a6  cmp      dword ptr [rcx + 0x18], 9
01da42aa  jbe      0x1da4645
01da42b0  mov      rdx, qword ptr [rcx + 0x68]
01da42b4  jmp      0x1da42f8
01da42b6  ucomiss  xmm0, dword ptr [rip + 0x174874f] ; [34eca0c] f=2.0 d=5.304989477e-315 v4=(2.0, 0.0, 2.0, 6.283185)
01da42bd  jp       0x1da434d
01da42c3  jne      0x1da434d
01da42c9  mov      rsi, qword ptr [rbx + 0xb8]
01da42d0  xor      edx, edx
01da42d2  mov      rcx, rbx
01da42d5  call     0x1d11bc0 ; Threading.CancellationToken Enemy.PawnEnemy::get_CToken()
01da42da  mov      rcx, qword ptr [rbx + 0x280]
01da42e1  test     rcx, rcx
01da42e4  je       0x1da463f
01da42ea  cmp      dword ptr [rcx + 0x18], 0xa
01da42ee  jbe      0x1da4645
01da42f4  mov      rdx, qword ptr [rcx + 0x70]
01da42f8  test     rsi, rsi
01da42fb  je       0x1da463f
01da4301  xor      ecx, ecx
01da4303  mov      r9, rdi
01da4306  mov      qword ptr [rsp + 0x58], rcx
01da430b  mov      r8, rax
01da430e  mov      qword ptr [rsp + 0x50], rcx
01da4313  mov      dword ptr [rsp + 0x48], ecx
01da4317  movss    dword ptr [rsp + 0x40], xmm6
01da431d  mov      qword ptr [rsp + 0x38], rcx
01da4322  mov      qword ptr [rsp + 0x30], rdx
01da4327  mov      rdx, rsi
01da432a  mov      byte ptr [rsp + 0x28], cl
01da432e  mov      byte ptr [rsp + 0x20], cl
01da4332  lea      rcx, [rbp + 7]
01da4336  call     0x1cd8fe0 ; Cysharp.Threading.Tasks.UniTask InGameEnemyMoveBase::BulletFireAsync(Threading.CancellationToken,Enemy.BulletTemplate,Boolean,Boolean,Transform,Transform,Single,Int32,Action`1<InGameBulletInterface>)
01da433b  xor      edx, edx
01da433d  lea      rcx, [rbp + 7]
01da4341  movups   xmm0, xmmword ptr [rax]
01da4344  movaps   xmmword ptr [rbp + 7], xmm0
01da4348  call     0x2742890 ; Void Cysharp.Threading.Tasks.UniTaskExtensions::Forget(Cysharp.Threading.Tasks.UniTask)
01da434d  movss    xmm0, dword ptr [rbx + 0x310]
01da4355  addss    xmm0, xmm7
01da4359  movss    dword ptr [rbx + 0x310], xmm0
01da4361  mov      rcx, qword ptr [rip + 0x260d810] ; [43b1b78] TypeInfo#37312
01da4368  movss    xmm6, dword ptr [rbx + 0x310]
01da4370  cmp      dword ptr [rcx + 0xe4], 0
01da4377  jne      0x1da4385
01da4379  call     0x4e0d90 ; il2cpp_class_init
01da437e  mov      rcx, qword ptr [rip + 0x260d7f3] ; [43b1b78] TypeInfo#37312
01da4385  mov      rax, qword ptr [rcx + 0xb8]
01da438c  comiss   xmm6, dword ptr [rax + 0x140]
01da4393  jb       0x1da43f9
01da4395  cmp      dword ptr [rcx + 0xe4], 0
01da439c  jne      0x1da43aa
01da439e  call     0x4e0d90 ; il2cpp_class_init
01da43a3  mov      rcx, qword ptr [rip + 0x260d7ce] ; [43b1b78] TypeInfo#37312
01da43aa  mov      rax, qword ptr [rcx + 0xb8]
01da43b1  xor      r8d, r8d
01da43b4  mov      rcx, rbx
01da43b7  movss    xmm1, dword ptr [rax + 0x134]
01da43bf  call     0x1dba580 ; Void Enemy.Ene_BosBase::SetRepeatTime(Single)
01da43c4  mov      rax, qword ptr [rip + 0x260d7ad] ; [43b1b78] TypeInfo#37312
01da43cb  xor      r9d, r9d
01da43ce  movaps   xmm2, xmm7
01da43d1  mov      rcx, qword ptr [rax + 0xb8]
01da43d8  movss    xmm1, dword ptr [rcx + 0x130]
01da43e0  mov      rcx, rbx
01da43e3  call     0x1dba4d0 ; Void Enemy.Ene_BosBase::SetDirectionTime(Single,Single)
01da43e8  mov      dword ptr [rbx + 0x1ec], 0xa
01da43f2  mov      rcx, qword ptr [rip + 0x260d77f] ; [43b1b78] TypeInfo#37312
01da43f9  cmp      dword ptr [rcx + 0xe4], 0
01da4400  movss    xmm6, dword ptr [rbx + 0x32c]
01da4408  jne      0x1da4416
01da440a  call     0x4e0d90 ; il2cpp_class_init
01da440f  mov      rcx, qword ptr [rip + 0x260d762] ; [43b1b78] TypeInfo#37312
01da4416  mov      rax, qword ptr [rcx + 0xb8]
01da441d  movss    xmm0, dword ptr [rax + 0x12c]
01da4425  subss    xmm0, dword ptr [rbx + 0x32c]
01da442d  mulss    xmm0, dword ptr [rip + 0x173c793] ; [34e0bc8] f=0.5 d=0.007812501833541319 v4=(0.5, 1.0, 3.141593, 4.0)
01da4435  addss    xmm0, xmm6
01da4439  movss    dword ptr [rbx + 0x32c], xmm0
01da4441  jmp      0x1da3e96
01da4446  mov      rax, qword ptr [rip + 0x260d72b] ; [43b1b78] TypeInfo#37312
01da444d  cmp      dword ptr [rax + 0xe4], 0
01da4454  jne      0x1da4465
01da4456  mov      rcx, rax
01da4459  call     0x4e0d90 ; il2cpp_class_init
01da445e  mov      rax, qword ptr [rip + 0x260d713] ; [43b1b78] TypeInfo#37312
01da4465  mov      rax, qword ptr [rax + 0xb8]
01da446c  xor      r9d, r9d
01da446f  movaps   xmm1, xmm6
01da4472  mov      rcx, rbx
01da4475  movss    xmm2, dword ptr [rax + 0x124]
01da447d  call     0x1da6f60 ; Void Enemy.Ene_Bos07::<PatternMove4>g__UpdateMoveTime|129_0(Single,Single)
01da4482  xor      r8d, r8d
01da4485  movaps   xmm1, xmm6
01da4488  mov      rcx, rbx
01da448b  call     0x1da1fd0 ; Void Enemy.Ene_Bos07::LegOrBatteryFire(Single)
01da4490  xor      edx, edx
01da4492  mov      rcx, rbx
01da4495  call     0x1db9a20 ; Single Enemy.Ene_BosBase::GetDirectionRate()
01da449a  comiss   xmm0, dword ptr [rip + 0x173c72b] ; [34e0bcc] f=1.0 d=50.12387841939926 v4=(1.0, 3.141593, 4.0, 10.0)
01da44a1  jb       0x1da45a3
01da44a7  mov      rax, qword ptr [rip + 0x260d6ca] ; [43b1b78] TypeInfo#37312
01da44ae  cmp      dword ptr [rax + 0xe4], 0
01da44b5  jne      0x1da44c6
01da44b7  mov      rcx, rax
01da44ba  call     0x4e0d90 ; il2cpp_class_init
01da44bf  mov      rax, qword ptr [rip + 0x260d6b2] ; [43b1b78] TypeInfo#37312
01da44c6  mov      rax, qword ptr [rax + 0xb8]
01da44cd  xor      r8d, r8d
01da44d0  mov      rcx, rbx
01da44d3  movss    xmm1, dword ptr [rax + 0x13c]
01da44db  call     0x1dba580 ; Void Enemy.Ene_BosBase::SetRepeatTime(Single)
01da44e0  xor      ecx, ecx
01da44e2  mov      dword ptr [rbx + 0x310], ecx
01da44e8  jmp      0x1da459d
01da44ed  mov      rax, qword ptr [rip + 0x260d684] ; [43b1b78] TypeInfo#37312
01da44f4  cmp      dword ptr [rax + 0xe4], 0
01da44fb  jne      0x1da450c
01da44fd  mov      rcx, rax
01da4500  call     0x4e0d90 ; il2cpp_class_init
01da4505  mov      rax, qword ptr [rip + 0x260d66c] ; [43b1b78] TypeInfo#37312
01da450c  mov      rax, qword ptr [rax + 0xb8]
01da4513  xor      r9d, r9d
01da4516  movaps   xmm1, xmm6
01da4519  mov      rcx, rbx
01da451c  movss    xmm2, dword ptr [rax + 0x124]
01da4524  call     0x1da6f60 ; Void Enemy.Ene_Bos07::<PatternMove4>g__UpdateMoveTime|129_0(Single,Single)
01da4529  cmp      byte ptr [rbx + 0x1dc], 0
01da4530  je       0x1da4542
01da4532  xor      r9d, r9d
01da4535  mov      r8b, 1
01da4538  xor      edx, edx
01da453a  mov      rcx, rbx
01da453d  call     0x1da0910 ; Void Enemy.Ene_Bos07::BCFire(Boolean,Boolean)
01da4542  xor      edx, edx
01da4544  mov      rcx, rbx
01da4547  call     0x1db9a20 ; Single Enemy.Ene_BosBase::GetDirectionRate()
01da454c  movss    xmm6, dword ptr [rip + 0x173c678] ; [34e0bcc] f=1.0 d=50.12387841939926 v4=(1.0, 3.141593, 4.0, 10.0)
01da4554  comiss   xmm0, xmm6
01da4557  jb       0x1da45a3
01da4559  mov      rax, qword ptr [rip + 0x260d618] ; [43b1b78] TypeInfo#37312
01da4560  cmp      dword ptr [rax + 0xe4], 0
01da4567  jne      0x1da4578
01da4569  mov      rcx, rax
01da456c  call     0x4e0d90 ; il2cpp_class_init
01da4571  mov      rax, qword ptr [rip + 0x260d600] ; [43b1b78] TypeInfo#37312
01da4578  mov      rax, qword ptr [rax + 0xb8]
01da457f  xor      r9d, r9d
01da4582  movaps   xmm2, xmm6
01da4585  mov      rcx, rbx
01da4588  movss    xmm1, dword ptr [rax + 0x138]
01da4590  call     0x1dba4d0 ; Void Enemy.Ene_BosBase::SetDirectionTime(Single,Single)
01da4595  xor      ecx, ecx
01da4597  mov      dword ptr [rbx + 0x318], ecx
01da459d  inc      dword ptr [rbx + 0x1ec]
01da45a3  mov      rax, qword ptr [rip + 0x260d5ce] ; [43b1b78] TypeInfo#37312
01da45aa  movss    xmm6, dword ptr [rbx + 0x32c]
01da45b2  cmp      dword ptr [rax + 0xe4], 0
01da45b9  jne      0x1da45ca
01da45bb  mov      rcx, rax
01da45be  call     0x4e0d90 ; il2cpp_class_init
01da45c3  mov      rax, qword ptr [rip + 0x260d5ae] ; [43b1b78] TypeInfo#37312
01da45ca  mov      rax, qword ptr [rax + 0xb8]
01da45d1  movss    xmm0, dword ptr [rax + 0x128]
01da45d9  subss    xmm0, dword ptr [rbx + 0x32c]
01da45e1  mulss    xmm0, dword ptr [rip + 0x173c63b] ; [34e0c24] f=0.10000000149011612 d=1.0681151189828597e-05 v4=(0.1, 0.45, 0.0, 0.0)
01da45e9  addss    xmm0, xmm6
01da45ed  movss    dword ptr [rbx + 0x32c], xmm0
01da45f5  jmp      0x1da3e96
01da45fa  cmp      dword ptr [rbx + 0x270], 4
01da4601  je       0x1da4615
01da4603  xor      ecx, ecx
01da4605  mov      dword ptr [rbx + 0x270], 4
01da460f  mov      dword ptr [rbx + 0x1ec], ecx
01da4615  mov      rax, qword ptr [rbx + 0xb8]
01da461c  test     rax, rax
01da461f  je       0x1da463f
01da4621  mov      byte ptr [rax + 0x1d4], 0
01da4628  mov      word ptr [rbx + 0x302], 0x101
01da4631  mov      word ptr [rbx + 0x314], 0
01da463a  jmp      0x1da3e96
01da463f  call     0x4e0d00 ; ThrowNullRef
01da4644  int3     
01da4645  call     0x4e0cf0 ; ?
01da464a  int3     
01da464b  int3     
01da464c  int3     
01da464d  int3     
01da464e  int3     
01da464f  int3     

### Void Enemy.Ene_Bos07::PatternMove5(Single)  RVA=0x1DA4650 len=0x590
01da4650  push     rbp
01da4652  push     r14
01da4654  lea      rbp, [rsp - 0x4f]
01da4659  sub      rsp, 0x98
01da4660  cmp      byte ptr [rip + 0x28bf1af], 0 ; [4663816] bss
01da4667  mov      r14, rcx
01da466a  jne      0x1da468b
01da466c  lea      rcx, [rip + 0x260d505] ; [43b1b78] TypeInfo#37312
01da4673  call     0x4e0a50 ; il2cpp_init_metadata
01da4678  lea      rcx, [rip + 0x25fdce9] ; [43a2368] TypeInfo#45781
01da467f  call     0x4e0a50 ; il2cpp_init_metadata
01da4684  mov      byte ptr [rip + 0x28bf18b], 1 ; [4663816] bss
01da468b  mov      eax, dword ptr [r14 + 0x1ec]
01da4692  mov      qword ptr [rsp + 0xb0], rbx
01da469a  mov      qword ptr [rsp + 0xb8], rsi
01da46a2  mov      qword ptr [rsp + 0xc0], rdi
01da46aa  mov      qword ptr [rsp + 0x90], r15
01da46b2  movaps   xmmword ptr [rsp + 0x80], xmm6
01da46ba  movaps   xmmword ptr [rsp + 0x70], xmm7
01da46bf  movaps   xmmword ptr [rsp + 0x50], xmm9
01da46c5  test     eax, eax
01da46c7  jne      0x1da48ea
01da46cd  xor      r8d, r8d
01da46d0  mov      edx, 0x22
01da46d5  mov      rcx, r14
01da46d8  call     0x1ccf580 ; Void InGameCollisionBase::SetObjectFlag(InGameObject/InGameObjectFlag)
01da46dd  xor      r8d, r8d
01da46e0  mov      edx, 1
01da46e5  mov      rcx, r14
01da46e8  call     0x1d0da10 ; Enemy.EnePartsGroup Enemy.PawnEnemy::GetParts(Int32)
01da46ed  xor      ebx, ebx
01da46ef  mov      qword ptr [rbp - 9], rbx
01da46f3  test     rax, rax
01da46f6  je       0x1da4bd8
01da46fc  movsd    xmm6, qword ptr [rbp - 9]
01da4701  lea      rcx, [rbp - 0x19]
01da4705  mov      r9b, 1
01da4708  movsd    qword ptr [rbp - 0x19], xmm6
01da470d  xor      edi, edi
01da470f  mov      dword ptr [rbp - 0x11], ebx
01da4712  mov      qword ptr [rsp + 0x28], rdi
01da4717  movzx    r8d, r9b
01da471b  mov      qword ptr [rsp + 0x20], rcx
01da4720  xor      edx, edx
01da4722  mov      rcx, rax
01da4725  call     0x1d61850 ; Void Enemy.EnePartsGroup::BreakParts(Boolean,Boolean,Boolean,Vector3)
01da472a  xor      r8d, r8d
01da472d  mov      edx, 2
01da4732  mov      rcx, r14
01da4735  call     0x1d0da10 ; Enemy.EnePartsGroup Enemy.PawnEnemy::GetParts(Int32)
01da473a  test     rax, rax
01da473d  je       0x1da4bd8
01da4743  lea      rcx, [rbp - 0x19]
01da4747  mov      qword ptr [rsp + 0x28], rdi
01da474c  mov      r9b, 1
01da474f  mov      qword ptr [rsp + 0x20], rcx
01da4754  mov      rcx, rax
01da4757  movsd    qword ptr [rbp - 0x19], xmm6
01da475c  movzx    r8d, r9b
01da4760  mov      dword ptr [rbp - 0x11], ebx
01da4763  xor      edx, edx
01da4765  call     0x1d61850 ; Void Enemy.EnePartsGroup::BreakParts(Boolean,Boolean,Boolean,Vector3)
01da476a  xor      r8d, r8d
01da476d  mov      edx, 3
01da4772  mov      rcx, r14
01da4775  call     0x1d0da10 ; Enemy.EnePartsGroup Enemy.PawnEnemy::GetParts(Int32)
01da477a  test     rax, rax
01da477d  je       0x1da4bd8
01da4783  lea      rcx, [rbp - 0x19]
01da4787  mov      qword ptr [rsp + 0x28], rdi
01da478c  mov      r9b, 1
01da478f  mov      qword ptr [rsp + 0x20], rcx
01da4794  mov      rcx, rax
01da4797  movsd    qword ptr [rbp - 0x19], xmm6
01da479c  movzx    r8d, r9b
01da47a0  mov      dword ptr [rbp - 0x11], ebx
01da47a3  xor      edx, edx
01da47a5  call     0x1d61850 ; Void Enemy.EnePartsGroup::BreakParts(Boolean,Boolean,Boolean,Vector3)
01da47aa  xor      r8d, r8d
01da47ad  mov      edx, 4
01da47b2  mov      rcx, r14
01da47b5  call     0x1d0da10 ; Enemy.EnePartsGroup Enemy.PawnEnemy::GetParts(Int32)
01da47ba  test     rax, rax
01da47bd  je       0x1da4bd8
01da47c3  lea      rcx, [rbp - 0x19]
01da47c7  mov      qword ptr [rsp + 0x28], rdi
01da47cc  mov      r9b, 1
01da47cf  mov      qword ptr [rsp + 0x20], rcx
01da47d4  mov      rcx, rax
01da47d7  movsd    qword ptr [rbp - 0x19], xmm6
01da47dc  movzx    r8d, r9b
01da47e0  mov      dword ptr [rbp - 0x11], ebx
01da47e3  xor      edx, edx
01da47e5  call     0x1d61850 ; Void Enemy.EnePartsGroup::BreakParts(Boolean,Boolean,Boolean,Vector3)
01da47ea  xor      r8d, r8d
01da47ed  mov      edx, 5
01da47f2  mov      rcx, r14
01da47f5  call     0x1d0da10 ; Enemy.EnePartsGroup Enemy.PawnEnemy::GetParts(Int32)
01da47fa  test     rax, rax
01da47fd  je       0x1da4bd8
01da4803  lea      rcx, [rbp - 0x19]
01da4807  mov      qword ptr [rsp + 0x28], rdi
01da480c  mov      r9b, 1
01da480f  mov      qword ptr [rsp + 0x20], rcx
01da4814  mov      rcx, rax
01da4817  movsd    qword ptr [rbp - 0x19], xmm6
01da481c  movzx    r8d, r9b
01da4820  mov      dword ptr [rbp - 0x11], ebx
01da4823  xor      edx, edx
01da4825  call     0x1d61850 ; Void Enemy.EnePartsGroup::BreakParts(Boolean,Boolean,Boolean,Vector3)
01da482a  mov      rcx, qword ptr [rip + 0x25fdb37] ; [43a2368] TypeInfo#45781
01da4831  cmp      dword ptr [rcx + 0xe4], ebx
01da4837  jne      0x1da483e
01da4839  call     0x4e0d90 ; il2cpp_class_init
01da483e  xor      edx, edx
01da4840  mov      ecx, 0x59
01da4845  call     0x2723de0 ; Void TXEKernel.Sound.SoundUtility::PlayQue(TXEKernel.Sound.SoundUtility/ID)
01da484a  xor      edx, edx
01da484c  mov      ecx, 0xd4
01da4851  call     0x2723de0 ; Void TXEKernel.Sound.SoundUtility::PlayQue(TXEKernel.Sound.SoundUtility/ID)
01da4856  mov      rdx, qword ptr [r14 + 0x50]
01da485a  test     rdx, rdx
01da485d  je       0x1da4bd8
01da4863  xor      r8d, r8d
01da4866  lea      rcx, [rbp - 9]
01da486a  call     0x3093700 ; Vector3 Transform::get_localPosition()
01da486f  movss    xmm2, dword ptr [rip + 0x173c355] ; [34e0bcc] f=1.0 d=50.12387841939926 v4=(1.0, 3.141593, 4.0, 10.0)
01da4877  xor      r9d, r9d
01da487a  movss    xmm1, dword ptr [rip + 0x184e53e] ; [35f2dc0] f=1.25 d=4096.000970840454 v4=(1.25, 5.5, 9.999, 58.5)
01da4882  mov      ecx, dword ptr [rax + 8]
01da4885  movsd    xmm0, qword ptr [rax]
01da4889  movsd    qword ptr [r14 + 0x340], xmm0
01da4892  mov      dword ptr [r14 + 0x348], ecx
01da4899  mov      rcx, r14
01da489c  call     0x1dba4d0 ; Void Enemy.Ene_BosBase::SetDirectionTime(Single,Single)
01da48a1  mov      dword ptr [r14 + 0x1ec], 0xa
01da48ac  movaps   xmm9, xmmword ptr [rsp + 0x50]
01da48b2  movaps   xmm7, xmmword ptr [rsp + 0x70]
01da48b7  movaps   xmm6, xmmword ptr [rsp + 0x80]
01da48bf  mov      r15, qword ptr [rsp + 0x90]
01da48c7  mov      rdi, qword ptr [rsp + 0xc0]
01da48cf  mov      rsi, qword ptr [rsp + 0xb8]
01da48d7  mov      rbx, qword ptr [rsp + 0xb0]
01da48df  add      rsp, 0x98
01da48e6  pop      r14
01da48e8  pop      rbp
01da48e9  ret      
01da48ea  cmp      eax, 0xa
01da48ed  jne      0x1da4a6c
01da48f3  mov      qword ptr [rsp + 0xc8], r12
01da48fb  movaps   xmmword ptr [rsp + 0x60], xmm8
01da4901  xor      edx, edx
01da4903  mov      rcx, r14
01da4906  call     0x1db9a20 ; Single Enemy.Ene_BosBase::GetDirectionRate()
01da490b  mov      rax, qword ptr [rip + 0x260d266] ; [43b1b78] TypeInfo#37312
01da4912  movaps   xmm9, xmm0
01da4916  movsd    xmm1, qword ptr [r14 + 0x228]
01da491f  mov      r12d, dword ptr [r14 + 0x230]
01da4926  movsd    qword ptr [rbp - 0x19], xmm1
01da492b  cmp      dword ptr [rax + 0xe4], 0
01da4932  jne      0x1da4943
01da4934  mov      rcx, rax
01da4937  call     0x4e0d90 ; il2cpp_class_init
01da493c  mov      rax, qword ptr [rip + 0x260d235] ; [43b1b78] TypeInfo#37312
01da4943  mov      rax, qword ptr [rax + 0xb8]
01da494a  xor      edx, edx
01da494c  movsd    xmm8, qword ptr [r14 + 0x340]
01da4955  movaps   xmm0, xmm9
01da4959  mov      r15, qword ptr [r14 + 0x50]
01da495d  movaps   xmm6, xmm8
01da4961  mov      esi, dword ptr [r14 + 0x348]
01da4968  movsd    xmm7, qword ptr [rax + 0xb8]
01da4970  mov      edi, dword ptr [rax + 0xc0]
01da4976  call     0x1de86f0 ; Single KANAI.Kernel.EasingUtility::InOutSine01(Single)
01da497b  movss    xmm4, dword ptr [rbp - 0x15]
01da4980  movaps   xmm2, xmm0
01da4983  movss    xmm3, dword ptr [rbp - 0x19]
01da4988  movaps   xmm1, xmm7
01da498b  shufps   xmm1, xmm1, 0x55
01da498f  addss    xmm3, xmm7
01da4993  movd     xmm5, r12d
01da4998  addss    xmm4, xmm1
01da499c  mov      r12, qword ptr [rsp + 0xc8]
01da49a4  movaps   xmm0, xmm6
01da49a7  shufps   xmm0, xmm0, 0x55
01da49ab  movd     xmm1, esi
01da49af  subss    xmm3, xmm6
01da49b3  subss    xmm4, xmm0
01da49b7  movaps   xmm0, xmm8
01da49bb  shufps   xmm0, xmm0, 0x55
01da49bf  mulss    xmm3, xmm2
01da49c3  mulss    xmm4, xmm2
01da49c7  addss    xmm3, xmm8
01da49cc  movaps   xmm8, xmmword ptr [rsp + 0x60]
01da49d2  addss    xmm4, xmm0
01da49d6  movd     xmm0, edi
01da49da  addss    xmm5, xmm0
01da49de  movd     xmm0, esi
01da49e2  subss    xmm5, xmm1
01da49e6  mulss    xmm5, xmm2
01da49ea  addss    xmm5, xmm0
01da49ee  test     r15, r15
01da49f1  je       0x1da4bd8
01da49f7  unpcklps xmm3, xmm4
01da49fa  lea      rdx, [rbp - 0x19]
01da49fe  xor      r8d, r8d
01da4a01  movsd    qword ptr [rbp - 0x19], xmm3
01da4a06  mov      rcx, r15
01da4a09  movss    dword ptr [rbp - 0x11], xmm5
01da4a0e  call     0x3094570 ; Void Transform::set_localPosition(Vector3)
01da4a13  movss    xmm6, dword ptr [rip + 0x173c1b1] ; [34e0bcc] f=1.0 d=50.12387841939926 v4=(1.0, 3.141593, 4.0, 10.0)
01da4a1b  comiss   xmm9, xmm6
01da4a1f  jb       0x1da48ac
01da4a25  mov      rcx, qword ptr [rip + 0x25fd93c] ; [43a2368] TypeInfo#45781
01da4a2c  cmp      dword ptr [rcx + 0xe4], 0
01da4a33  jne      0x1da4a3a
01da4a35  call     0x4e0d90 ; il2cpp_class_init
01da4a3a  xor      edx, edx
01da4a3c  mov      ecx, 0x5a
01da4a41  call     0x2723de0 ; Void TXEKernel.Sound.SoundUtility::PlayQue(TXEKernel.Sound.SoundUtility/ID)
01da4a46  movss    xmm1, dword ptr [rip + 0x1747fbe] ; [34eca0c] f=2.0 d=5.304989477e-315 v4=(2.0, 0.0, 2.0, 6.283185)
01da4a4e  xor      r9d, r9d
01da4a51  movaps   xmm2, xmm6
01da4a54  mov      rcx, r14
01da4a57  call     0x1dba4d0 ; Void Enemy.Ene_BosBase::SetDirectionTime(Single,Single)
01da4a5c  mov      dword ptr [r14 + 0x1ec], 0x14
01da4a67  jmp      0x1da48ac
01da4a6c  cmp      eax, 0x14
01da4a6f  jne      0x1da48ac
01da4a75  xor      edx, edx
01da4a77  mov      rcx, r14
01da4a7a  call     0x1db9a20 ; Single Enemy.Ene_BosBase::GetDirectionRate()
01da4a7f  movss    xmm7, dword ptr [rip + 0x173c145] ; [34e0bcc] f=1.0 d=50.12387841939926 v4=(1.0, 3.141593, 4.0, 10.0)
01da4a87  movaps   xmm6, xmm0
01da4a8a  comiss   xmm7, xmm6
01da4a8d  mov      rbx, qword ptr [r14 + 0x2b0]
01da4a94  ja       0x1da4b09
01da4a96  mov      rax, qword ptr [rip + 0x260d0db] ; [43b1b78] TypeInfo#37312
01da4a9d  cmp      dword ptr [rax + 0xe4], 0
01da4aa4  jne      0x1da4ab5
01da4aa6  mov      rcx, rax
01da4aa9  call     0x4e0d90 ; il2cpp_class_init
01da4aae  mov      rax, qword ptr [rip + 0x260d0c3] ; [43b1b78] TypeInfo#37312
01da4ab5  mov      rax, qword ptr [rax + 0xb8]
01da4abc  test     rbx, rbx
01da4abf  je       0x1da4bd8
01da4ac5  movsd    xmm0, qword ptr [rax + 0xac]
01da4acd  lea      rdx, [rbp - 0x19]
01da4ad1  mov      eax, dword ptr [rax + 0xb4]
01da4ad7  xor      r8d, r8d
01da4ada  mov      rcx, rbx
01da4add  movsd    qword ptr [rbp - 0x19], xmm0
01da4ae2  mov      dword ptr [rbp - 0x11], eax
01da4ae5  call     0x3094570 ; Void Transform::set_localPosition(Vector3)
01da4aea  xor      r8d, r8d
01da4aed  mov      edx, 0x22
01da4af2  mov      rcx, r14
01da4af5  call     0x1ccf500 ; Void InGameCollisionBase::ResetObjectFlag(InGameObject/InGameObjectFlag)
01da4afa  xor      edx, edx
01da4afc  mov      rcx, r14
01da4aff  call     0x1da0d30 ; Void Enemy.Ene_Bos07::CheckNextState()
01da4b04  jmp      0x1da48ac
01da4b09  mov      rcx, qword ptr [rip + 0x260d068] ; [43b1b78] TypeInfo#37312
01da4b10  cmp      dword ptr [rcx + 0xe4], 0
01da4b17  jne      0x1da4b25
01da4b19  call     0x4e0d90 ; il2cpp_class_init
01da4b1e  mov      rcx, qword ptr [rip + 0x260d053] ; [43b1b78] TypeInfo#37312
01da4b25  mov      rax, qword ptr [rcx + 0xb8]
01da4b2c  addss    xmm6, xmm6
01da4b30  xor      edx, edx
01da4b32  movsd    xmm0, qword ptr [rax + 0xac]
01da4b3a  mov      edi, dword ptr [rax + 0xb4]
01da4b40  mov      esi, dword ptr [rax + 0xa8]
01da4b46  movsd    qword ptr [rbp - 0x19], xmm0
01da4b4b  movsd    xmm0, qword ptr [rax + 0xa0]
01da4b53  movsd    qword ptr [rbp - 9], xmm0
01da4b58  movaps   xmm0, xmm6
01da4b5b  call     0x1de8020 ; Single KANAI.Kernel.EasingUtility::EaseOutBounce01(Single)
01da4b60  movaps   xmm1, xmm0
01da4b63  xorps    xmm0, xmm0
01da4b66  comiss   xmm0, xmm1
01da4b69  ja       0x1da4b75
01da4b6b  comiss   xmm1, xmm7
01da4b6e  jbe      0x1da4b78
01da4b70  movaps   xmm1, xmm7
01da4b73  jmp      0x1da4b78
01da4b75  xorps    xmm1, xmm1
01da4b78  movss    xmm2, dword ptr [rbp - 0x19]
01da4b7d  movss    xmm3, dword ptr [rbp - 0x15]
01da4b82  movd     xmm0, esi
01da4b86  movd     xmm4, edi
01da4b8a  subss    xmm4, xmm0
01da4b8e  subss    xmm2, dword ptr [rbp - 9]
01da4b93  subss    xmm3, dword ptr [rbp - 5]
01da4b98  mulss    xmm4, xmm1
01da4b9c  mulss    xmm2, xmm1
01da4ba0  mulss    xmm3, xmm1
01da4ba4  addss    xmm4, xmm0
01da4ba8  addss    xmm2, dword ptr [rbp - 9]
01da4bad  addss    xmm3, dword ptr [rbp - 5]
01da4bb2  test     rbx, rbx
01da4bb5  je       0x1da4bd8
01da4bb7  unpcklps xmm2, xmm3
01da4bba  lea      rdx, [rbp - 9]
01da4bbe  xor      r8d, r8d
01da4bc1  movsd    qword ptr [rbp - 9], xmm2
01da4bc6  mov      rcx, rbx
01da4bc9  movss    dword ptr [rbp - 1], xmm4
01da4bce  call     0x3094570 ; Void Transform::set_localPosition(Vector3)
01da4bd3  jmp      0x1da48ac
01da4bd8  call     0x4e0d00 ; ThrowNullRef
01da4bdd  int3     
01da4bde  int3     
01da4bdf  int3     

### Void Enemy.Ene_Bos07::PatternMove6(Single)  RVA=0x1DA4BE0 len=0x520
01da4be0  mov      rax, rsp
01da4be3  push     rsi
01da4be4  push     rdi
01da4be5  sub      rsp, 0xa8
01da4bec  cmp      byte ptr [rip + 0x28bec24], 0 ; [4663817] bss
01da4bf3  mov      rdi, rcx
01da4bf6  movaps   xmmword ptr [rax - 0x28], xmm7
01da4bfa  movaps   xmm7, xmm1
01da4bfd  movaps   xmmword ptr [rax - 0x38], xmm8
01da4c02  movaps   xmmword ptr [rax - 0x48], xmm9
01da4c07  jne      0x1da4c34
01da4c09  lea      rcx, [rip + 0x260cf68] ; [43b1b78] TypeInfo#37312
01da4c10  call     0x4e0a50 ; il2cpp_init_metadata
01da4c15  lea      rcx, [rip + 0x25fd74c] ; [43a2368] TypeInfo#45781
01da4c1c  call     0x4e0a50 ; il2cpp_init_metadata
01da4c21  lea      rcx, [rip + 0x2614cc0] ; [43b98e8] STR 'body4'
01da4c28  call     0x4e0a50 ; il2cpp_init_metadata
01da4c2d  mov      byte ptr [rip + 0x28bebe3], 1 ; [4663817] bss
01da4c34  mov      ecx, dword ptr [rdi + 0x1ec]
01da4c3a  xor      esi, esi
01da4c3c  movss    xmm8, dword ptr [rip + 0x173bf87] ; [34e0bcc] f=1.0 d=50.12387841939926 v4=(1.0, 3.141593, 4.0, 10.0)
01da4c45  xorps    xmm9, xmm9
01da4c49  mov      qword ptr [rsp + 0xc0], rbx
01da4c51  mov      qword ptr [rsp + 0xc8], rbp
01da4c59  mov      qword ptr [rsp + 0xd0], r14
01da4c61  mov      qword ptr [rsp + 0xa0], r15
01da4c69  test     ecx, ecx
01da4c6b  jne      0x1da4e78
01da4c71  mov      dword ptr [rdi + 0x1ec], 0xa
01da4c7b  movss    xmm1, dword ptr [rip + 0x173bf55] ; [34e0bd8] f=10.0 d=134217760.5625 v4=(10.0, 20.0, 57.29578, 100.0)
01da4c83  xor      r9d, r9d
01da4c86  movaps   xmm2, xmm8
01da4c8a  mov      rcx, rdi
01da4c8d  call     0x1dba4d0 ; Void Enemy.Ene_BosBase::SetDirectionTime(Single,Single)
01da4c92  movss    xmm1, dword ptr [rip + 0x1747d72] ; [34eca0c] f=2.0 d=5.304989477e-315 v4=(2.0, 0.0, 2.0, 6.283185)
01da4c9a  xor      r8d, r8d
01da4c9d  mov      rcx, rdi
01da4ca0  call     0x1dba580 ; Void Enemy.Ene_BosBase::SetRepeatTime(Single)
01da4ca5  movss    xmm1, dword ptr [rip + 0x1747d5f] ; [34eca0c] f=2.0 d=5.304989477e-315 v4=(2.0, 0.0, 2.0, 6.283185)
01da4cad  xor      r8d, r8d
01da4cb0  mov      rcx, rdi
01da4cb3  call     0x1db8ec0 ; Void Enemy.Ene_BosBase::AddRepeatTime(Single)
01da4cb8  mov      dword ptr [rdi + 0x310], esi
01da4cbe  mov      dword ptr [rdi + 0x274], esi
01da4cc4  mov      dword ptr [rdi + 0x1ec], 0xb
01da4cce  xor      edx, edx
01da4cd0  mov      rcx, rdi
01da4cd3  call     0x1db9a20 ; Single Enemy.Ene_BosBase::GetDirectionRate()
01da4cd8  comiss   xmm0, xmm8
01da4cdc  jb       0x1da4d4a
01da4cde  xor      r9d, r9d
01da4ce1  movaps   xmm2, xmm8
01da4ce5  movaps   xmm1, xmm8
01da4ce9  mov      rcx, rdi
01da4cec  call     0x1dba4d0 ; Void Enemy.Ene_BosBase::SetDirectionTime(Single,Single)
01da4cf1  movss    xmm1, dword ptr [rip + 0x184dea7] ; [35f2ba0] f=0.20000000298023224 d=9.765628744844435e-05 v4=(0.2, 0.6, 6.0, 7.0)
01da4cf9  xor      r8d, r8d
01da4cfc  mov      rcx, rdi
01da4cff  call     0x1dba580 ; Void Enemy.Ene_BosBase::SetRepeatTime(Single)
01da4d04  mov      dword ptr [rdi + 0x324], esi
01da4d0a  mov      rax, qword ptr [rip + 0x260ce67] ; [43b1b78] TypeInfo#37312
01da4d11  cmp      dword ptr [rax + 0xe4], esi
01da4d17  jne      0x1da4d28
01da4d19  mov      rcx, rax
01da4d1c  call     0x4e0d90 ; il2cpp_class_init
01da4d21  mov      rax, qword ptr [rip + 0x260ce50] ; [43b1b78] TypeInfo#37312
01da4d28  mov      rax, qword ptr [rax + 0xb8]
01da4d2f  xor      r9d, r9d
01da4d32  xor      edx, edx
01da4d34  mov      rcx, rdi
01da4d37  movss    xmm2, dword ptr [rax + 0x148]
01da4d3f  call     0x1da7130 ; Void Enemy.Ene_Bos07::<PatternMove6>g__SetHomingAngle|131_1(Boolean,Single)
01da4d44  inc      dword ptr [rdi + 0x1ec]
01da4d4a  cmp      byte ptr [rdi + 0x1dc], sil
01da4d51  je       0x1da4f30
01da4d57  movss    xmm0, dword ptr [rip + 0x173c109] ; [34e0e68] f=5.0 d=7.673846671558197e+21 v4=(5.0, 1000.0, 10.0, 10.0)
01da4d5f  comiss   xmm0, dword ptr [rdi + 0x310]
01da4d66  jbe      0x1da4f30
01da4d6c  movss    xmm0, dword ptr [rdi + 0x310]
01da4d74  mov      rax, qword ptr [rdi + 0x280]
01da4d7b  addss    xmm0, xmm8
01da4d80  movss    dword ptr [rdi + 0x310], xmm0
01da4d88  test     rax, rax
01da4d8b  je       0x1da50f0
01da4d91  cmp      dword ptr [rax + 0x18], 1
01da4d95  jbe      0x1da50f6
01da4d9b  cmp      dword ptr [rax + 0x18], 0xb
01da4d9f  mov      rbp, qword ptr [rax + 0x28]
01da4da3  jbe      0x1da50f6
01da4da9  mov      r15, qword ptr [rax + 0x78]
01da4dad  xor      edx, edx
01da4daf  mov      r14, qword ptr [rdi + 0xb8]
01da4db6  mov      rcx, rdi
01da4db9  call     0x1d11bc0 ; Threading.CancellationToken Enemy.PawnEnemy::get_CToken()
01da4dbe  xor      r8d, r8d
01da4dc1  mov      edx, 9
01da4dc6  mov      rcx, rdi
01da4dc9  mov      rbx, rax
01da4dcc  call     0x1db9840 ; Enemy.BulletTemplate Enemy.Ene_BosBase::GetBT(Int32)
01da4dd1  test     r14, r14
01da4dd4  je       0x1da50f0
01da4dda  mov      qword ptr [rsp + 0x40], rsi
01da4ddf  lea      rcx, [rsp + 0x50]
01da4de4  mov      qword ptr [rsp + 0x38], rsi
01da4de9  mov      r9, rax
01da4dec  mov      dword ptr [rsp + 0x30], esi
01da4df0  mov      r8, rbx
01da4df3  mov      qword ptr [rsp + 0x28], r15
01da4df8  mov      rdx, r14
01da4dfb  mov      qword ptr [rsp + 0x20], rbp
01da4e00  call     0x1cd8bf0 ; Cysharp.Threading.Tasks.UniTask InGameEnemyMoveBase::BulletDirFireAsync(Threading.CancellationToken,Enemy.BulletTemplate,Transform,Transform,Int32,Action`1<InGameBulletInterface>)
01da4e05  xor      edx, edx
01da4e07  lea      rcx, [rsp + 0x50]
01da4e0c  movups   xmm0, xmmword ptr [rax]
01da4e0f  movaps   xmmword ptr [rsp + 0x50], xmm0
01da4e14  call     0x2742890 ; Void Cysharp.Threading.Tasks.UniTaskExtensions::Forget(Cysharp.Threading.Tasks.UniTask)
01da4e19  mov      rcx, qword ptr [rip + 0x25fd548] ; [43a2368] TypeInfo#45781
01da4e20  cmp      dword ptr [rcx + 0xe4], esi
01da4e26  jne      0x1da4e2d
01da4e28  call     0x4e0d90 ; il2cpp_class_init
01da4e2d  xor      edx, edx
01da4e2f  mov      ecx, 0xc0
01da4e34  call     0x2723de0 ; Void TXEKernel.Sound.SoundUtility::PlayQue(TXEKernel.Sound.SoundUtility/ID)
01da4e39  mov      rax, qword ptr [rip + 0x260cd38] ; [43b1b78] TypeInfo#37312
01da4e40  cmp      dword ptr [rax + 0xe4], esi
01da4e46  jne      0x1da4e57
01da4e48  mov      rcx, rax
01da4e4b  call     0x4e0d90 ; il2cpp_class_init
01da4e50  mov      rax, qword ptr [rip + 0x260cd21] ; [43b1b78] TypeInfo#37312
01da4e57  mov      rax, qword ptr [rax + 0xb8]
01da4e5e  xor      r9d, r9d
01da4e61  mov      dl, 1
01da4e63  mov      rcx, rdi
01da4e66  movss    xmm2, dword ptr [rax + 0x148]
01da4e6e  call     0x1da7130 ; Void Enemy.Ene_Bos07::<PatternMove6>g__SetHomingAngle|131_1(Boolean,Single)
01da4e73  jmp      0x1da4f30
01da4e78  add      ecx, -0xa
01da4e7b  je       0x1da4c7b
01da4e81  sub      ecx, 1
01da4e84  je       0x1da4cce
01da4e8a  sub      ecx, 1
01da4e8d  je       0x1da4f5b
01da4e93  sub      ecx, 1
01da4e96  je       0x1da4ebf
01da4e98  cmp      ecx, 1
01da4e9b  jne      0x1da4f30
01da4ea1  xor      r8d, r8d
01da4ea4  movaps   xmm1, xmm7
01da4ea7  mov      rcx, rdi
01da4eaa  call     0x1da7490 ; Boolean Enemy.Ene_Bos07::<PatternMove6>g__UpdateCircuitMove|131_0(Single)
01da4eaf  test     al, al
01da4eb1  je       0x1da4f30
01da4eb3  mov      dword ptr [rdi + 0x1ec], 0xa
01da4ebd  jmp      0x1da4f30
01da4ebf  xor      edx, edx
01da4ec1  mov      rcx, rdi
01da4ec4  call     0x1db9a20 ; Single Enemy.Ene_BosBase::GetDirectionRate()
01da4ec9  comiss   xmm0, xmm8
01da4ecd  jb       0x1da4efb
01da4ecf  movss    xmm1, dword ptr [rip + 0x184dcd1] ; [35f2ba8] f=6.0 d=32768.007904052734 v4=(6.0, 7.0, 15.0, 30.0)
01da4ed7  xor      r9d, r9d
01da4eda  movaps   xmm2, xmm8
01da4ede  mov      rcx, rdi
01da4ee1  call     0x1dba4d0 ; Void Enemy.Ene_BosBase::SetDirectionTime(Single,Single)
01da4ee6  xor      r8d, r8d
01da4ee9  movaps   xmm1, xmm8
01da4eed  mov      rcx, rdi
01da4ef0  call     0x1dba580 ; Void Enemy.Ene_BosBase::SetRepeatTime(Single)
01da4ef5  inc      dword ptr [rdi + 0x1ec]
01da4efb  cmp      byte ptr [rdi + 0x1dc], sil
01da4f02  je       0x1da4f14
01da4f04  xor      r9d, r9d
01da4f07  mov      r8b, 1
01da4f0a  xor      edx, edx
01da4f0c  mov      rcx, rdi
01da4f0f  call     0x1da0910 ; Void Enemy.Ene_Bos07::BCFire(Boolean,Boolean)
01da4f14  xor      r8d, r8d
01da4f17  movaps   xmm1, xmm7
01da4f1a  mov      rcx, rdi
01da4f1d  call     0x1da1fd0 ; Void Enemy.Ene_Bos07::LegOrBatteryFire(Single)
01da4f22  xor      r8d, r8d
01da4f25  movaps   xmm1, xmm7
01da4f28  mov      rcx, rdi
01da4f2b  call     0x1da7490 ; Boolean Enemy.Ene_Bos07::<PatternMove6>g__UpdateCircuitMove|131_0(Single)
01da4f30  addss    xmm7, dword ptr [rdi + 0x338]
01da4f38  comiss   xmm9, xmm7
01da4f3c  ja       0x1da5027
01da4f42  movss    xmm0, dword ptr [rdi + 0x33c]
01da4f4a  comiss   xmm7, xmm0
01da4f4d  jbe      0x1da502a
01da4f53  movaps   xmm7, xmm0
01da4f56  jmp      0x1da502a
01da4f5b  xor      edx, edx
01da4f5d  mov      rcx, rdi
01da4f60  call     0x1db9a20 ; Single Enemy.Ene_BosBase::GetDirectionRate()
01da4f65  comiss   xmm0, xmm8
01da4f69  jb       0x1da4f9d
01da4f6b  movss    xmm1, dword ptr [rip + 0x1747a99] ; [34eca0c] f=2.0 d=5.304989477e-315 v4=(2.0, 0.0, 2.0, 6.283185)
01da4f73  xor      r9d, r9d
01da4f76  movaps   xmm2, xmm8
01da4f7a  mov      rcx, rdi
01da4f7d  call     0x1dba4d0 ; Void Enemy.Ene_BosBase::SetDirectionTime(Single,Single)
01da4f82  xor      r8d, r8d
01da4f85  movaps   xmm1, xmm8
01da4f89  mov      rcx, rdi
01da4f8c  call     0x1dba580 ; Void Enemy.Ene_BosBase::SetRepeatTime(Single)
01da4f91  inc      dword ptr [rdi + 0x1ec]
01da4f97  mov      dword ptr [rdi + 0x318], esi
01da4f9d  cmp      byte ptr [rdi + 0x1dc], sil
01da4fa4  je       0x1da4f22
01da4faa  xor      r8d, r8d
01da4fad  xor      edx, edx
01da4faf  mov      rcx, rdi
01da4fb2  call     0x1db9840 ; Enemy.BulletTemplate Enemy.Ene_BosBase::GetBT(Int32)
01da4fb7  mov      rbx, qword ptr [rdi + 0xb8]
01da4fbe  xor      edx, edx
01da4fc0  mov      rcx, rdi
01da4fc3  mov      rbp, rax
01da4fc6  call     0x1d11bc0 ; Threading.CancellationToken Enemy.PawnEnemy::get_CToken()
01da4fcb  test     rbx, rbx
01da4fce  je       0x1da50f0
01da4fd4  mov      rdx, qword ptr [rip + 0x261490d] ; [43b98e8] STR 'body4'
01da4fdb  mov      r9b, 1
01da4fde  mov      qword ptr [rsp + 0x38], rsi
01da4fe3  mov      r8, rbp
01da4fe6  movss    dword ptr [rsp + 0x30], xmm9
01da4fed  mov      rcx, rbx
01da4ff0  mov      qword ptr [rsp + 0x28], rdx
01da4ff5  mov      rdx, rax
01da4ff8  mov      byte ptr [rsp + 0x20], 1
01da4ffd  call     0x1cd9150 ; Void InGameEnemyMoveBase::BulletFireByMuzzlePack(Threading.CancellationToken,Enemy.BulletTemplate,Boolean,Boolean,String,Single)
01da5002  mov      rcx, qword ptr [rip + 0x25fd35f] ; [43a2368] TypeInfo#45781
01da5009  cmp      dword ptr [rcx + 0xe4], esi
01da500f  jne      0x1da5016
01da5011  call     0x4e0d90 ; il2cpp_class_init
01da5016  xor      edx, edx
01da5018  mov      ecx, 0xc0
01da501d  call     0x2723de0 ; Void TXEKernel.Sound.SoundUtility::PlayQue(TXEKernel.Sound.SoundUtility/ID)
01da5022  jmp      0x1da4f22
01da5027  xorps    xmm7, xmm7
01da502a  movss    dword ptr [rdi + 0x338], xmm7
01da5032  xor      edx, edx
01da5034  divss    xmm7, dword ptr [rdi + 0x33c]
01da503c  movaps   xmm0, xmm7
01da503f  call     0x1de8650 ; Single KANAI.Kernel.EasingUtility::InOutQuad01(Single)
01da5044  movss    xmm1, dword ptr [rdi + 0x334]
01da504c  movaps   xmm2, xmm0
01da504f  movss    xmm0, dword ptr [rdi + 0x330]
01da5057  xor      r9d, r9d
01da505a  mov      rbx, qword ptr [rdi + 0x2b0]
01da5061  mov      dword ptr [rsp + 0x50], 0
01da5069  call     0x1cfa430 ; Single Mathf::LerpAngle(Single,Single,Single)
01da506e  mulss    xmm0, dword ptr [rip + 0x173bb4a] ; [34e0bc0] f=0.01745329238474369 d=2.0463635523047694e-13 v4=(0.017453, 0.05, 0.5, 1.0)
01da5076  lea      rdx, [rsp + 0x50]
01da507b  xor      r8d, r8d
01da507e  mov      dword ptr [rsp + 0x58], 0
01da5086  lea      rcx, [rsp + 0x60]
01da508b  movss    dword ptr [rsp + 0x54], xmm0
01da5091  call     0x304d890 ; Quaternion Quaternion::Internal_FromEulerRad(Vector3&)
01da5096  test     rbx, rbx
01da5099  je       0x1da50f0
01da509b  movups   xmm0, xmmword ptr [rax]
01da509e  xor      r8d, r8d
01da50a1  lea      rdx, [rsp + 0x50]
01da50a6  mov      rcx, rbx
01da50a9  movaps   xmmword ptr [rsp + 0x50], xmm0
01da50ae  call     0x3094650 ; Void Transform::set_localRotation(Quaternion)
01da50b3  mov      r15, qword ptr [rsp + 0xa0]
01da50bb  lea      r11, [rsp + 0xa8]
01da50c3  movaps   xmm7, xmmword ptr [r11 - 0x18]
01da50c8  movaps   xmm8, xmmword ptr [r11 - 0x28]
01da50cd  movaps   xmm9, xmmword ptr [r11 - 0x38]
01da50d2  mov      r14, qword ptr [rsp + 0xd0]
01da50da  mov      rbp, qword ptr [rsp + 0xc8]
01da50e2  mov      rbx, qword ptr [rsp + 0xc0]
01da50ea  mov      rsp, r11
01da50ed  pop      rdi
01da50ee  pop      rsi
01da50ef  ret      
01da50f0  call     0x4e0d00 ; ThrowNullRef
01da50f5  int3     
01da50f6  call     0x4e0cf0 ; ?
01da50fb  int3     
01da50fc  int3     
01da50fd  int3     
01da50fe  int3     
01da50ff  int3     

### Void Enemy.Ene_Bos07::PatternMove7(Single)  RVA=0x1DA5100 len=0x2C0
01da5100  mov      qword ptr [rsp + 8], rbx
01da5105  mov      qword ptr [rsp + 0x10], rbp
01da510a  mov      qword ptr [rsp + 0x18], rsi
01da510f  push     rdi
01da5110  sub      rsp, 0x90
01da5117  mov      eax, dword ptr [rcx + 0x1ec]
01da511d  mov      rbx, rcx
01da5120  movaps   xmmword ptr [rsp + 0x50], xmm9
01da5126  test     eax, eax
01da5128  jne      0x1da5257
01da512e  xor      r8d, r8d
01da5131  mov      edx, 1
01da5136  call     0x1d0da10 ; Enemy.EnePartsGroup Enemy.PawnEnemy::GetParts(Int32)
01da513b  xor      r8d, r8d
01da513e  mov      edx, 2
01da5143  mov      rcx, rbx
01da5146  mov      rsi, rax
01da5149  call     0x1d0da10 ; Enemy.EnePartsGroup Enemy.PawnEnemy::GetParts(Int32)
01da514e  mov      rdi, rax
01da5151  test     rsi, rsi
01da5154  je       0x1da53b2
01da515a  xor      ebp, ebp
01da515c  cmp      byte ptr [rsi + 0x9a], bpl
01da5163  jne      0x1da519c
01da5165  xor      eax, eax
01da5167  mov      qword ptr [rsp + 0x28], rbp
01da516c  mov      qword ptr [rsp + 0x30], rax
01da5171  mov      r9b, 1
01da5174  movsd    xmm0, qword ptr [rsp + 0x30]
01da517a  movzx    r8d, r9b
01da517e  mov      dword ptr [rsp + 0x48], eax
01da5182  xor      edx, edx
01da5184  lea      rax, [rsp + 0x40]
01da5189  movsd    qword ptr [rsp + 0x40], xmm0
01da518f  mov      rcx, rsi
01da5192  mov      qword ptr [rsp + 0x20], rax
01da5197  call     0x1d61850 ; Void Enemy.EnePartsGroup::BreakParts(Boolean,Boolean,Boolean,Vector3)
01da519c  test     rdi, rdi
01da519f  je       0x1da53b2
01da51a5  cmp      byte ptr [rdi + 0x9a], bpl
01da51ac  jne      0x1da51e5
01da51ae  xor      eax, eax
01da51b0  mov      qword ptr [rsp + 0x28], rbp
01da51b5  mov      qword ptr [rsp + 0x30], rax
01da51ba  mov      r9b, 1
01da51bd  movsd    xmm0, qword ptr [rsp + 0x30]
01da51c3  movzx    r8d, r9b
01da51c7  mov      dword ptr [rsp + 0x48], eax
01da51cb  xor      edx, edx
01da51cd  lea      rax, [rsp + 0x40]
01da51d2  movsd    qword ptr [rsp + 0x40], xmm0
01da51d8  mov      rcx, rdi
01da51db  mov      qword ptr [rsp + 0x20], rax
01da51e0  call     0x1d61850 ; Void Enemy.EnePartsGroup::BreakParts(Boolean,Boolean,Boolean,Vector3)
01da51e5  mov      rdx, qword ptr [rbx + 0x50]
01da51e9  test     rdx, rdx
01da51ec  je       0x1da53b2
01da51f2  xor      r8d, r8d
01da51f5  lea      rcx, [rsp + 0x40]
01da51fa  call     0x3093700 ; Vector3 Transform::get_localPosition()
01da51ff  movss    xmm2, dword ptr [rip + 0x173b9c5] ; [34e0bcc] f=1.0 d=50.12387841939926 v4=(1.0, 3.141593, 4.0, 10.0)
01da5207  xor      r9d, r9d
01da520a  movss    xmm1, dword ptr [rip + 0x17477fa] ; [34eca0c] f=2.0 d=5.304989477e-315 v4=(2.0, 0.0, 2.0, 6.283185)
01da5212  mov      ecx, dword ptr [rax + 8]
01da5215  movsd    xmm0, qword ptr [rax]
01da5219  movsd    qword ptr [rbx + 0x340], xmm0
01da5221  mov      dword ptr [rbx + 0x348], ecx
01da5227  mov      rcx, rbx
01da522a  call     0x1dba4d0 ; Void Enemy.Ene_BosBase::SetDirectionTime(Single,Single)
01da522f  mov      dword ptr [rbx + 0x1ec], 1
01da5239  lea      r11, [rsp + 0x90]
01da5241  mov      rbx, qword ptr [r11 + 0x10]
01da5245  mov      rbp, qword ptr [r11 + 0x18]
01da5249  mov      rsi, qword ptr [r11 + 0x20]
01da524d  movaps   xmm9, xmmword ptr [r11 - 0x40]
01da5252  mov      rsp, r11
01da5255  pop      rdi
01da5256  ret      
01da5257  cmp      eax, 1
01da525a  jne      0x1da5239
01da525c  xor      edx, edx
01da525e  call     0x1db9a20 ; Single Enemy.Ene_BosBase::GetDirectionRate()
01da5263  movaps   xmm9, xmm0
01da5267  comiss   xmm9, dword ptr [rip + 0x173b95d] ; [34e0bcc] f=1.0 d=50.12387841939926 v4=(1.0, 3.141593, 4.0, 10.0)
01da526f  jb       0x1da52d3
01da5271  xor      r8d, r8d
01da5274  mov      edx, 3
01da5279  mov      rcx, rbx
01da527c  call     0x1d0da10 ; Enemy.EnePartsGroup Enemy.PawnEnemy::GetParts(Int32)
01da5281  test     rax, rax
01da5284  je       0x1da53b2
01da528a  xor      r9d, r9d
01da528d  xor      r8d, r8d
01da5290  mov      edx, 0x10
01da5295  mov      rcx, rax
01da5298  call     0x1d61c30 ; Void Enemy.EnePartsGroup::ChangeCollisionsAttribute(Enemy.EnemyCollisionAttribute,Boolean)
01da529d  xor      r8d, r8d
01da52a0  mov      edx, 4
01da52a5  mov      rcx, rbx
01da52a8  call     0x1d0da10 ; Enemy.EnePartsGroup Enemy.PawnEnemy::GetParts(Int32)
01da52ad  test     rax, rax
01da52b0  je       0x1da53b2
01da52b6  xor      r9d, r9d
01da52b9  xor      r8d, r8d
01da52bc  mov      edx, 0x10
01da52c1  mov      rcx, rax
01da52c4  call     0x1d61c30 ; Void Enemy.EnePartsGroup::ChangeCollisionsAttribute(Enemy.EnemyCollisionAttribute,Boolean)
01da52c9  xor      edx, edx
01da52cb  mov      rcx, rbx
01da52ce  call     0x1da0d30 ; Void Enemy.Ene_Bos07::CheckNextState()
01da52d3  mov      rbp, qword ptr [rbx + 0x50]
01da52d7  xor      edx, edx
01da52d9  mov      esi, dword ptr [rbx + 0x348]
01da52df  movaps   xmm0, xmm9
01da52e3  movaps   xmmword ptr [rsp + 0x80], xmm6
01da52eb  movsd    xmm6, qword ptr [rbx + 0x228]
01da52f3  movaps   xmmword ptr [rsp + 0x70], xmm7
01da52f8  movaps   xmmword ptr [rsp + 0x60], xmm8
01da52fe  movsd    xmm8, qword ptr [rbx + 0x340]
01da5307  mov      ebx, dword ptr [rbx + 0x230]
01da530d  movaps   xmm7, xmm8
01da5311  call     0x1de86f0 ; Single KANAI.Kernel.EasingUtility::InOutSine01(Single)
01da5316  movsd    qword ptr [rsp + 0x40], xmm6
01da531c  movaps   xmm2, xmm0
01da531f  movsd    qword ptr [rsp + 0x40], xmm7
01da5325  movaps   xmm1, xmm7
01da5328  shufps   xmm1, xmm1, 0x55
01da532c  movaps   xmm0, xmm8
01da5330  shufps   xmm0, xmm0, 0x55
01da5334  movaps   xmm3, xmm6
01da5337  shufps   xmm3, xmm3, 0x55
01da533b  movaps   xmm4, xmm6
01da533e  movaps   xmm6, xmmword ptr [rsp + 0x80]
01da5346  subss    xmm3, xmm1
01da534a  movd     xmm1, ebx
01da534e  subss    xmm4, xmm7
01da5352  movaps   xmm7, xmmword ptr [rsp + 0x70]
01da5357  movsd    qword ptr [rsp + 0x40], xmm8
01da535e  mulss    xmm3, xmm2
01da5362  mulss    xmm4, xmm2
01da5366  addss    xmm3, xmm0
01da536a  movd     xmm0, esi
01da536e  subss    xmm1, xmm0
01da5372  movd     xmm0, esi
01da5376  addss    xmm4, xmm8
01da537b  movaps   xmm8, xmmword ptr [rsp + 0x60]
01da5381  mulss    xmm1, xmm2
01da5385  addss    xmm1, xmm0
01da5389  test     rbp, rbp
01da538c  je       0x1da53b2
01da538e  unpcklps xmm4, xmm3
01da5391  lea      rdx, [rsp + 0x40]
01da5396  xor      r8d, r8d
01da5399  movsd    qword ptr [rsp + 0x40], xmm4
01da539f  mov      rcx, rbp
01da53a2  movss    dword ptr [rsp + 0x48], xmm1
01da53a8  call     0x3094570 ; Void Transform::set_localPosition(Vector3)
01da53ad  jmp      0x1da5239
01da53b2  call     0x4e0d00 ; ThrowNullRef
01da53b7  int3     
01da53b8  int3     
01da53b9  int3     
01da53ba  int3     
01da53bb  int3     
01da53bc  int3     
01da53bd  int3     
01da53be  int3     
01da53bf  int3     

### Void Enemy.Ene_Bos07::PatternMoveDestruction(Single)  RVA=0x1DA53C0 len=0x5E0
01da53c0  mov      qword ptr [rsp + 0x20], rbx
01da53c5  push     rbp
01da53c6  mov      rbp, rsp
01da53c9  sub      rsp, 0x60
01da53cd  cmp      byte ptr [rip + 0x28be444], 0 ; [4663818] bss
01da53d4  mov      rbx, rcx
01da53d7  movaps   xmmword ptr [rsp + 0x50], xmm6
01da53dc  movaps   xmm6, xmm1
01da53df  jne      0x1da540c
01da53e1  lea      rcx, [rip + 0x25c5b98] ; [436af80] TypeInfo#41050
01da53e8  call     0x4e0a50 ; il2cpp_init_metadata
01da53ed  lea      rcx, [rip + 0x25fa36c] ; [439f760] TypeInfo#45545
01da53f4  call     0x4e0a50 ; il2cpp_init_metadata
01da53f9  lea      rcx, [rip + 0x25fcf68] ; [43a2368] TypeInfo#45781
01da5400  call     0x4e0a50 ; il2cpp_init_metadata
01da5405  mov      byte ptr [rip + 0x28be40c], 1 ; [4663818] bss
01da540c  mov      eax, dword ptr [rbx + 0x1ec]
01da5412  mov      qword ptr [rsp + 0x70], rsi
01da5417  mov      qword ptr [rsp + 0x78], rdi
01da541c  mov      qword ptr [rsp + 0x80], r14
01da5424  cmp      eax, 0xa
01da5427  jle      0x1da55f5
01da542d  cmp      eax, 0xb
01da5430  jne      0x1da55c3
01da5436  mov      rsi, qword ptr [rbx + 0x50]
01da543a  xor      edx, edx
01da543c  mov      rcx, rbx
01da543f  call     0x1db9a20 ; Single Enemy.Ene_BosBase::GetDirectionRate()
01da5444  xor      edi, edi
01da5446  lea      rcx, [rbp - 0x20]
01da544a  mov      r9d, 1
01da5450  mov      qword ptr [rsp + 0x20], rdi
01da5455  movaps   xmm2, xmm0
01da5458  mov      rdx, rbx
01da545b  call     0x1db9630 ; Vector3 Enemy.Ene_BosBase::CurrentTargetVector(Single,KANAI.Kernel.EasingUtility/EasingType)
01da5460  test     rsi, rsi
01da5463  je       0x1da5990
01da5469  movsd    xmm0, qword ptr [rax]
01da546d  lea      rdx, [rbp - 0x30]
01da5471  mov      eax, dword ptr [rax + 8]
01da5474  xor      r8d, r8d
01da5477  mov      rcx, rsi
01da547a  movsd    qword ptr [rbp - 0x30], xmm0
01da547f  mov      dword ptr [rbp - 0x28], eax
01da5482  call     0x3094570 ; Void Transform::set_localPosition(Vector3)
01da5487  mov      rsi, qword ptr [rbx + 0x50]
01da548b  xor      edx, edx
01da548d  mov      rcx, rbx
01da5490  call     0x1db9a20 ; Single Enemy.Ene_BosBase::GetDirectionRate()
01da5495  xor      r9d, r9d
01da5498  lea      rcx, [rbp - 0x20]
01da549c  movaps   xmm2, xmm0
01da549f  mov      rdx, rbx
01da54a2  call     0x1db95c0 ; Quaternion Enemy.Ene_BosBase::CurrentTargetAngle(Single)
01da54a7  test     rsi, rsi
01da54aa  je       0x1da5990
01da54b0  movups   xmm0, xmmword ptr [rax]
01da54b3  xor      r8d, r8d
01da54b6  lea      rdx, [rbp - 0x20]
01da54ba  mov      rcx, rsi
01da54bd  movaps   xmmword ptr [rbp - 0x20], xmm0
01da54c1  call     0x3094650 ; Void Transform::set_localRotation(Quaternion)
01da54c6  movss    xmm0, dword ptr [rbx + 0x274]
01da54ce  xor      r8d, r8d
01da54d1  subss    xmm0, xmm6
01da54d5  movaps   xmm1, xmm6
01da54d8  mov      rcx, rbx
01da54db  movss    dword ptr [rbx + 0x274], xmm0
01da54e3  call     0x1db9e90 ; Boolean Enemy.Ene_BosBase::IsCallSmallBomb(Single)
01da54e8  test     al, al
01da54ea  je       0x1da5588
01da54f0  mov      rax, qword ptr [rip + 0x25fa269] ; [439f760] TypeInfo#45545
01da54f7  cmp      dword ptr [rax + 0xe4], edi
01da54fd  jne      0x1da550e
01da54ff  mov      rcx, rax
01da5502  call     0x4e0d90 ; il2cpp_class_init
01da5507  mov      rax, qword ptr [rip + 0x25fa252] ; [439f760] TypeInfo#45545
01da550e  mov      rax, qword ptr [rax + 0xb8]
01da5515  lea      rcx, [rbp - 0x20]
01da5519  mov      r8, qword ptr [rbx]
01da551c  mov      rdx, rbx
01da551f  mov      esi, dword ptr [rax + 4]
01da5522  mov      rax, qword ptr [r8 + 0x6f8]
01da5529  mov      r8, qword ptr [r8 + 0x700]
01da5530  call     rax
01da5532  mov      r9, qword ptr [rip + 0x25c5a47] ; [436af80] TypeInfo#41050
01da5539  movsd    xmm6, qword ptr [rax]
01da553d  mov      r14d, dword ptr [rax + 8]
01da5541  cmp      dword ptr [r9 + 0xe4], edi
01da5548  jne      0x1da5559
01da554a  mov      rcx, r9
01da554d  call     0x4e0d90 ; il2cpp_class_init
01da5552  mov      r9, qword ptr [rip + 0x25c5a27] ; [436af80] TypeInfo#41050
01da5559  mov      r9, qword ptr [r9 + 0xb8]
01da5560  lea      r8, [rbp - 0x30]
01da5564  mov      qword ptr [rsp + 0x28], rdi
01da5569  mov      edx, esi
01da556b  mov      rcx, rbx
01da556e  movsd    qword ptr [rbp - 0x30], xmm6
01da5573  mov      dword ptr [rbp - 0x28], r14d
01da5577  mov      r9d, dword ptr [r9 + 0x20]
01da557b  mov      dword ptr [rsp + 0x20], 0x28
01da5583  call     0x1dba5c0 ; Void Enemy.Ene_BosBase::SkyExplosionEffect(Int32,Vector3,Int32,TXEKernel.Sound.SoundUtility/ID)
01da5588  xorps    xmm0, xmm0
01da558b  comiss   xmm0, dword ptr [rbx + 0x274]
01da5592  jb       0x1da559e
01da5594  mov      dword ptr [rbx + 0x1ec], 0x1e
01da559e  mov      r14, qword ptr [rsp + 0x80]
01da55a6  mov      rdi, qword ptr [rsp + 0x78]
01da55ab  mov      rsi, qword ptr [rsp + 0x70]
01da55b0  mov      rbx, qword ptr [rsp + 0x88]
01da55b8  movaps   xmm6, xmmword ptr [rsp + 0x50]
01da55bd  add      rsp, 0x60
01da55c1  pop      rbp
01da55c2  ret      
01da55c3  cmp      eax, 0x1e
01da55c6  jne      0x1da559e
01da55c8  mov      rcx, qword ptr [rip + 0x25fcd99] ; [43a2368] TypeInfo#45781
01da55cf  cmp      dword ptr [rcx + 0xe4], 0
01da55d6  jne      0x1da55dd
01da55d8  call     0x4e0d90 ; il2cpp_class_init
01da55dd  xor      edx, edx
01da55df  mov      ecx, 0x2a
01da55e4  call     0x2723de0 ; Void TXEKernel.Sound.SoundUtility::PlayQue(TXEKernel.Sound.SoundUtility/ID)
01da55e9  xor      edx, edx
01da55eb  mov      rcx, rbx
01da55ee  call     0x1dbac60 ; Void Enemy.Ene_BosBase::ToDestroid()
01da55f3  jmp      0x1da559e
01da55f5  test     eax, eax
01da55f7  jne      0x1da57b8
01da55fd  mov      rdx, qword ptr [rbx + 0x50]
01da5601  test     rdx, rdx
01da5604  je       0x1da5990
01da560a  xor      r8d, r8d
01da560d  lea      rcx, [rbp - 0x20]
01da5611  call     0x3093700 ; Vector3 Transform::get_localPosition()
01da5616  movsd    xmm1, qword ptr [rax]
01da561a  mov      ecx, dword ptr [rax + 8]
01da561d  movsd    qword ptr [rbx + 0x234], xmm1
01da5625  movsd    qword ptr [rbx + 0x240], xmm1
01da562d  mov      dword ptr [rbx + 0x23c], ecx
01da5633  mov      dword ptr [rbx + 0x248], ecx
01da5639  movss    xmm0, dword ptr [rbx + 0x244]
01da5641  subss    xmm0, dword ptr [rip + 0x184d78f] ; [35f2dd8] f=150.0 d=-5.56078426e-315 v4=(150.0, -0.0, -25.0, -30.0)
01da5649  movss    dword ptr [rbx + 0x244], xmm0
01da5651  mov      rdx, qword ptr [rbx + 0x50]
01da5655  test     rdx, rdx
01da5658  je       0x1da5990
01da565e  xor      r8d, r8d
01da5661  lea      rcx, [rbp - 0x20]
01da5665  call     0x30937f0 ; Quaternion Transform::get_localRotation()
01da566a  xor      r8d, r8d
01da566d  mov      dword ptr [rbp - 0x30], 0x3eb2b8c2
01da5674  lea      rdx, [rbp - 0x30]
01da5678  mov      qword ptr [rbp - 0x2c], 0x3f490fdb
01da5680  lea      rcx, [rbp - 0x20]
01da5684  movups   xmm0, xmmword ptr [rax]
01da5687  movups   xmmword ptr [rbx + 0x24c], xmm0
01da568e  call     0x304d890 ; Quaternion Quaternion::Internal_FromEulerRad(Vector3&)
01da5693  movups   xmm0, xmmword ptr [rax]
01da5696  movups   xmmword ptr [rbx + 0x25c], xmm0
01da569d  mov      rax, qword ptr [rip + 0x25fa0bc] ; [439f760] TypeInfo#45545
01da56a4  cmp      dword ptr [rax + 0xe4], 0
01da56ab  jne      0x1da56bc
01da56ad  mov      rcx, rax
01da56b0  call     0x4e0d90 ; il2cpp_class_init
01da56b5  mov      rax, qword ptr [rip + 0x25fa0a4] ; [439f760] TypeInfo#45545
01da56bc  mov      rax, qword ptr [rax + 0xb8]
01da56c3  lea      rcx, [rbp - 0x20]
01da56c7  mov      r8, qword ptr [rbx]
01da56ca  mov      rdx, rbx
01da56cd  mov      esi, dword ptr [rax + 8]
01da56d0  mov      rax, qword ptr [r8 + 0x6f8]
01da56d7  mov      r8, qword ptr [r8 + 0x700]
01da56de  call     rax
01da56e0  mov      r9, qword ptr [rip + 0x25c5899] ; [436af80] TypeInfo#41050
01da56e7  movsd    xmm6, qword ptr [rax]
01da56eb  cmp      dword ptr [r9 + 0xe4], 0
01da56f3  mov      edi, dword ptr [rax + 8]
01da56f6  jne      0x1da5707
01da56f8  mov      rcx, r9
01da56fb  call     0x4e0d90 ; il2cpp_class_init
01da5700  mov      r9, qword ptr [rip + 0x25c5879] ; [436af80] TypeInfo#41050
01da5707  mov      r9, qword ptr [r9 + 0xb8]
01da570e  lea      r8, [rbp - 0x30]
01da5712  mov      dword ptr [rbp - 0x28], edi
01da5715  mov      edx, esi
01da5717  xor      edi, edi
01da5719  movsd    qword ptr [rbp - 0x30], xmm6
01da571e  mov      qword ptr [rsp + 0x28], rdi
01da5723  mov      rcx, rbx
01da5726  mov      r9d, dword ptr [r9 + 0x20]
01da572a  mov      dword ptr [rsp + 0x20], 0xffffffff
01da5732  call     0x1dba5c0 ; Void Enemy.Ene_BosBase::SkyExplosionEffect(Int32,Vector3,Int32,TXEKernel.Sound.SoundUtility/ID)
01da5737  movss    xmm6, dword ptr [rip + 0x173b48d] ; [34e0bcc] f=1.0 d=50.12387841939926 v4=(1.0, 3.141593, 4.0, 10.0)
01da573f  mov      rcx, rbx
01da5742  movss    xmm3, dword ptr [rip + 0x17472c2] ; [34eca0c] f=2.0 d=5.304989477e-315 v4=(2.0, 0.0, 2.0, 6.283185)
01da574a  movaps   xmm2, xmm6
01da574d  movss    xmm1, dword ptr [rip + 0x173b473] ; [34e0bc8] f=0.5 d=0.007812501833541319 v4=(0.5, 1.0, 3.141593, 4.0)
01da5755  mov      qword ptr [rsp + 0x20], rdi
01da575a  call     0x1d0cad0 ; Void Enemy.PawnEnemy::AddShake(Single,Single,Single)
01da575f  movss    xmm1, dword ptr [rip + 0x184d439] ; [35f2ba0] f=0.20000000298023224 d=9.765628744844435e-05 v4=(0.2, 0.6, 6.0, 7.0)
01da5767  xor      r8d, r8d
01da576a  mov      rcx, rbx
01da576d  call     0x1dba5a0 ; Void Enemy.Ene_BosBase::SetSmallBombSecond(Single)
01da5772  movss    xmm1, dword ptr [rip + 0x184d64a] ; [35f2dc4] f=5.5 d=524025.8131713867 v4=(5.5, 9.999, 58.5, 80.0)
01da577a  xor      r9d, r9d
01da577d  movaps   xmm2, xmm6
01da5780  mov      rcx, rbx
01da5783  call     0x1dba4d0 ; Void Enemy.Ene_BosBase::SetDirectionTime(Single,Single)
01da5788  mov      rax, qword ptr [rbx + 0xb8]
01da578f  test     rax, rax
01da5792  je       0x1da5990
01da5798  mov      byte ptr [rax + 0x1d4], 1
01da579f  mov      dword ptr [rbx + 0x274], 0x40600000
01da57a9  mov      dword ptr [rbx + 0x1ec], 0xa
01da57b3  jmp      0x1da559e
01da57b8  cmp      eax, 0xa
01da57bb  jne      0x1da559e
01da57c1  mov      rsi, qword ptr [rbx + 0x50]
01da57c5  xor      edx, edx
01da57c7  mov      rcx, rbx
01da57ca  call     0x1db9a20 ; Single Enemy.Ene_BosBase::GetDirectionRate()
01da57cf  xor      edi, edi
01da57d1  lea      rcx, [rbp - 0x20]
01da57d5  mov      r9d, 1
01da57db  mov      qword ptr [rsp + 0x20], rdi
01da57e0  movaps   xmm2, xmm0
01da57e3  mov      rdx, rbx
01da57e6  call     0x1db9630 ; Vector3 Enemy.Ene_BosBase::CurrentTargetVector(Single,KANAI.Kernel.EasingUtility/EasingType)
01da57eb  test     rsi, rsi
01da57ee  je       0x1da5990
01da57f4  movsd    xmm0, qword ptr [rax]
01da57f8  lea      rdx, [rbp - 0x30]
01da57fc  mov      eax, dword ptr [rax + 8]
01da57ff  xor      r8d, r8d
01da5802  mov      rcx, rsi
01da5805  movsd    qword ptr [rbp - 0x30], xmm0
01da580a  mov      dword ptr [rbp - 0x28], eax
01da580d  call     0x3094570 ; Void Transform::set_localPosition(Vector3)
01da5812  mov      rsi, qword ptr [rbx + 0x50]
01da5816  xor      edx, edx
01da5818  mov      rcx, rbx
01da581b  call     0x1db9a20 ; Single Enemy.Ene_BosBase::GetDirectionRate()
01da5820  xor      r9d, r9d
01da5823  lea      rcx, [rbp - 0x20]
01da5827  movaps   xmm2, xmm0
01da582a  mov      rdx, rbx
01da582d  call     0x1db95c0 ; Quaternion Enemy.Ene_BosBase::CurrentTargetAngle(Single)
01da5832  test     rsi, rsi
01da5835  je       0x1da5990
01da583b  movups   xmm0, xmmword ptr [rax]
01da583e  xor      r8d, r8d
01da5841  lea      rdx, [rbp - 0x20]
01da5845  mov      rcx, rsi
01da5848  movaps   xmmword ptr [rbp - 0x20], xmm0
01da584c  call     0x3094650 ; Void Transform::set_localRotation(Quaternion)
01da5851  movss    xmm1, dword ptr [rbx + 0x274]
01da5859  xorps    xmm0, xmm0
01da585c  subss    xmm1, xmm6
01da5860  comiss   xmm0, xmm1
01da5863  movss    dword ptr [rbx + 0x274], xmm1
01da586b  jb       0x1da58b8
01da586d  movss    xmm3, dword ptr [rip + 0x173b5f3] ; [34e0e68] f=5.0 d=7.673846671558197e+21 v4=(5.0, 1000.0, 10.0, 10.0)
01da5875  mov      rcx, rbx
01da5878  movss    xmm2, dword ptr [rip + 0x173b34c] ; [34e0bcc] f=1.0 d=50.12387841939926 v4=(1.0, 3.141593, 4.0, 10.0)
01da5880  movss    xmm1, dword ptr [rip + 0x173b340] ; [34e0bc8] f=0.5 d=0.007812501833541319 v4=(0.5, 1.0, 3.141593, 4.0)
01da5888  mov      qword ptr [rsp + 0x20], rdi
01da588d  call     0x1d0cad0 ; Void Enemy.PawnEnemy::AddShake(Single,Single,Single)
01da5892  mov      rdx, qword ptr [rbx]
01da5895  mov      rcx, rbx
01da5898  mov      rax, qword ptr [rdx + 0x588]
01da589f  mov      rdx, qword ptr [rdx + 0x590]
01da58a6  call     rax
01da58a8  inc      dword ptr [rbx + 0x1ec]
01da58ae  mov      dword ptr [rbx + 0x274], 0x40000000
01da58b8  xor      r8d, r8d
01da58bb  movaps   xmm1, xmm6
01da58be  mov      rcx, rbx
01da58c1  call     0x1db9e90 ; Boolean Enemy.Ene_BosBase::IsCallSmallBomb(Single)
01da58c6  test     al, al
01da58c8  je       0x1da559e
01da58ce  mov      rax, qword ptr [rip + 0x25f9e8b] ; [439f760] TypeInfo#45545
01da58d5  cmp      dword ptr [rax + 0xe4], edi
01da58db  jne      0x1da58ec
01da58dd  mov      rcx, rax
01da58e0  call     0x4e0d90 ; il2cpp_class_init
01da58e5  mov      rax, qword ptr [rip + 0x25f9e74] ; [439f760] TypeInfo#45545
01da58ec  mov      rax, qword ptr [rax + 0xb8]
01da58f3  lea      rcx, [rbp - 0x20]
01da58f7  mov      r8, qword ptr [rbx]
01da58fa  mov      rdx, rbx
01da58fd  mov      esi, dword ptr [rax + 4]
01da5900  mov      rax, qword ptr [r8 + 0x6f8]
01da5907  mov      r8, qword ptr [r8 + 0x700]
01da590e  call     rax
01da5910  mov      r9, qword ptr [rip + 0x25c5669] ; [436af80] TypeInfo#41050
01da5917  movsd    xmm6, qword ptr [rax]
01da591b  mov      r14d, dword ptr [rax + 8]
01da591f  cmp      dword ptr [r9 + 0xe4], edi
01da5926  jne      0x1da5937
01da5928  mov      rcx, r9
01da592b  call     0x4e0d90 ; il2cpp_class_init
01da5930  mov      r9, qword ptr [rip + 0x25c5649] ; [436af80] TypeInfo#41050
01da5937  mov      r9, qword ptr [r9 + 0xb8]
01da593e  lea      r8, [rbp - 0x30]
01da5942  mov      qword ptr [rsp + 0x28], rdi
01da5947  mov      edx, esi
01da5949  mov      rcx, rbx
01da594c  movsd    qword ptr [rbp - 0x30], xmm6
01da5951  mov      dword ptr [rbp - 0x28], r14d
01da5955  mov      r9d, dword ptr [r9 + 0x20]
01da5959  mov      dword ptr [rsp + 0x20], 0x28
01da5961  call     0x1dba5c0 ; Void Enemy.Ene_BosBase::SkyExplosionEffect(Int32,Vector3,Int32,TXEKernel.Sound.SoundUtility/ID)
01da5966  movss    xmm3, dword ptr [rip + 0x173b4fa] ; [34e0e68] f=5.0 d=7.673846671558197e+21 v4=(5.0, 1000.0, 10.0, 10.0)
01da596e  mov      rcx, rbx
01da5971  movss    xmm2, dword ptr [rip + 0x173b253] ; [34e0bcc] f=1.0 d=50.12387841939926 v4=(1.0, 3.141593, 4.0, 10.0)
01da5979  movss    xmm1, dword ptr [rip + 0x173b247] ; [34e0bc8] f=0.5 d=0.007812501833541319 v4=(0.5, 1.0, 3.141593, 4.0)
01da5981  mov      qword ptr [rsp + 0x20], rdi
01da5986  call     0x1d0cad0 ; Void Enemy.PawnEnemy::AddShake(Single,Single,Single)
01da598b  jmp      0x1da559e
01da5990  call     0x4e0d00 ; ThrowNullRef
01da5995  int3     
01da5996  int3     
01da5997  int3     
01da5998  int3     
01da5999  int3     
01da599a  int3     
01da599b  int3     
01da599c  int3     
01da599d  int3     
01da599e  int3     
01da599f  int3     

### Vector3 Enemy.Ene_Bos07::GetSmallBombPosition()  RVA=0x1DA1200 len=0xE0
01da1200  mov      qword ptr [rsp + 8], rbx
01da1205  mov      qword ptr [rsp + 0x10], rsi
01da120a  push     rdi
01da120b  sub      rsp, 0x30
01da120f  cmp      byte ptr [rip + 0x28c2603], 0 ; [4663819] bss
01da1216  mov      rsi, rdx
01da1219  mov      rdi, rcx
01da121c  jne      0x1da123d
01da121e  lea      rcx, [rip + 0x25ccb13] ; [436dd38] TypeInfo#31733
01da1225  call     0x4e0a50 ; il2cpp_init_metadata
01da122a  lea      rcx, [rip + 0x25f2b0f] ; [4393d40] Field#14
01da1231  call     0x4e0a50 ; il2cpp_init_metadata
01da1236  mov      byte ptr [rip + 0x28c25dc], 1 ; [4663819] bss
01da123d  mov      rcx, qword ptr [rip + 0x25ccaf4] ; [436dd38] TypeInfo#31733
01da1244  mov      edx, 0xb
01da1249  call     0x4dfe00 ; ?
01da124e  mov      rdx, qword ptr [rip + 0x25f2aeb] ; [4393d40] Field#14
01da1255  xor      r8d, r8d
01da1258  mov      rcx, rax
01da125b  mov      rbx, rax
01da125e  call     0x1f40520 ; Void Runtime.CompilerServices.RuntimeHelpers::InitializeArray(Array,RuntimeFieldHandle)
01da1263  test     rbx, rbx
01da1266  je       0x1da12d0
01da1268  mov      edx, dword ptr [rbx + 0x18]
01da126b  xor      r8d, r8d
01da126e  mov      ecx, 1
01da1273  call     0x1df1780 ; Int32 KANAI.Kernel.RandomUtility::Range(Int32,Int32)
01da1278  cdqe     
01da127a  dec      rax
01da127d  cmp      eax, dword ptr [rbx + 0x18]
01da1280  jae      0x1da12d6
01da1282  mov      rcx, qword ptr [rsi + 0x280]
01da1289  test     rcx, rcx
01da128c  je       0x1da12d0
01da128e  movsxd   rax, dword ptr [rbx + rax*4 + 0x20]
01da1293  cmp      eax, dword ptr [rcx + 0x18]
01da1296  jae      0x1da12d6
01da1298  mov      rdx, qword ptr [rcx + rax*8 + 0x20]
01da129d  test     rdx, rdx
01da12a0  je       0x1da12d0
01da12a2  xor      r8d, r8d
01da12a5  lea      rcx, [rsp + 0x20]
01da12aa  call     0x3093ba0 ; Vector3 Transform::get_position()
01da12af  mov      rbx, qword ptr [rsp + 0x40]
01da12b4  mov      rsi, qword ptr [rsp + 0x48]
01da12b9  movsd    xmm0, qword ptr [rax]
01da12bd  mov      eax, dword ptr [rax + 8]
01da12c0  movsd    qword ptr [rdi], xmm0
01da12c4  mov      dword ptr [rdi + 8], eax
01da12c7  mov      rax, rdi
01da12ca  add      rsp, 0x30
01da12ce  pop      rdi
01da12cf  ret      
01da12d0  call     0x4e0d00 ; ThrowNullRef
01da12d5  int3     
01da12d6  call     0x4e0cf0 ; ?
01da12db  int3     
01da12dc  int3     
01da12dd  int3     
01da12de  int3     
01da12df  int3     

### Void Enemy.Ene_Bos07::.ctor()  RVA=0x1DA7F10 len=0x100
01da7f10  mov      qword ptr [rsp + 8], rbx
01da7f15  push     rdi
01da7f16  sub      rsp, 0x20
01da7f1a  cmp      byte ptr [rip + 0x28bb8f9], 0 ; [466381a] bss
01da7f21  mov      rdi, rcx
01da7f24  jne      0x1da7f45
01da7f26  lea      rcx, [rip + 0x260ef63] ; [43b6e90] Type#53940
01da7f2d  call     0x4e0a50 ; il2cpp_init_metadata
01da7f32  lea      rcx, [rip + 0x2609f0f] ; [43b1e48] TypeInfo#37321
01da7f39  call     0x4e0a50 ; il2cpp_init_metadata
01da7f3e  mov      byte ptr [rip + 0x28bb8d5], 1 ; [466381a] bss
01da7f45  mov      rcx, qword ptr [rip + 0x28d0004] ; [4677f50] bss
01da7f4c  mov      rbx, qword ptr [rip + 0x260ef3d] ; [43b6e90] Type#53940
01da7f53  cmp      dword ptr [rcx + 0xe4], 0
01da7f5a  jne      0x1da7f61
01da7f5c  call     0x4e0d90 ; il2cpp_class_init
01da7f61  xor      edx, edx
01da7f63  mov      rcx, rbx
01da7f66  call     0x2051bf0 ; Type Type::GetTypeFromHandle(RuntimeTypeHandle)
01da7f6b  mov      rcx, qword ptr [rip + 0x28cff96] ; [4677f08] bss
01da7f72  mov      rbx, rax
01da7f75  cmp      dword ptr [rcx + 0xe4], 0
01da7f7c  jne      0x1da7f83
01da7f7e  call     0x4e0d90 ; il2cpp_class_init
01da7f83  xor      edx, edx
01da7f85  mov      rcx, rbx
01da7f88  call     0x2064b50 ; Array Enum::GetValues(Type)
01da7f8d  test     rax, rax
01da7f90  je       0x1da800a
01da7f92  xor      edx, edx
01da7f94  mov      rcx, rax
01da7f97  call     0x203fd00 ; Int32 Array::Collections.ICollection.get_Count() || Int32 Array::InternalArray__ICollection_get_Count() || Int32 Array::InternalArray__IReadOnlyCollection_get_Count()
01da7f9c  mov      dword ptr [rdi + 0x278], eax
01da7fa2  cmp      byte ptr [rip + 0x28b44b4], 0 ; [465c45d] bss
01da7fa9  jne      0x1da7fbe
01da7fab  lea      rcx, [rip + 0x2619726] ; [43c16d8] TypeInfo#48704
01da7fb2  call     0x4e0a50 ; il2cpp_init_metadata
01da7fb7  mov      byte ptr [rip + 0x28b449f], 1 ; [465c45d] bss
01da7fbe  mov      rax, qword ptr [rip + 0x2619713] ; [43c16d8] TypeInfo#48704
01da7fc5  mov      rcx, qword ptr [rax + 0xb8]
01da7fcc  movsd    xmm0, qword ptr [rcx]
01da7fd0  mov      eax, dword ptr [rcx + 8]
01da7fd3  movsd    qword ptr [rdi + 0x340], xmm0
01da7fdb  mov      dword ptr [rdi + 0x348], eax
01da7fe1  mov      rcx, qword ptr [rip + 0x2609e60] ; [43b1e48] TypeInfo#37321
01da7fe8  cmp      dword ptr [rcx + 0xe4], 0
01da7fef  jne      0x1da7ff6
01da7ff1  call     0x4e0d90 ; il2cpp_class_init
01da7ff6  xor      edx, edx
01da7ff8  mov      rcx, rdi
01da7ffb  mov      rbx, qword ptr [rsp + 0x30]
01da8000  add      rsp, 0x20
01da8004  pop      rdi
01da8005  jmp      0x1dbb0b0 ; Void Enemy.Ene_BosBase::.ctor()
01da800a  call     0x4e0d00 ; ThrowNullRef
01da800f  int3     

### Void Enemy.Ene_Bos07::.cctor()  RVA=0x1DA7580 len=0x990
01da7580  push     rbx
01da7582  sub      rsp, 0xa0
01da7589  cmp      byte ptr [rip + 0x28bc28b], 0 ; [466381b] bss
01da7590  jne      0x1da7639
01da7596  lea      rcx, [rip + 0x260a5db] ; [43b1b78] TypeInfo#37312
01da759d  call     0x4e0a50 ; il2cpp_init_metadata
01da75a2  lea      rcx, [rip + 0x25d25e7] ; [4379b90] TypeInfo#72448
01da75a9  call     0x4e0a50 ; il2cpp_init_metadata
01da75ae  lea      rcx, [rip + 0x25cbfcb] ; [4373580] TypeInfo#32047
01da75b5  call     0x4e0a50 ; il2cpp_init_metadata
01da75ba  lea      rcx, [rip + 0x262a3bf] ; [43d1980] STR 'Boss07/bos07laser'
01da75c1  call     0x4e0a50 ; il2cpp_init_metadata
01da75c6  lea      rcx, [rip + 0x262a523] ; [43d1af0] STR 'Boss07/bos07leg1way'
01da75cd  call     0x4e0a50 ; il2cpp_init_metadata
01da75d2  lea      rcx, [rip + 0x262a5cf] ; [43d1ba8] STR 'Boss07/bos07leg2'
01da75d9  call     0x4e0a50 ; il2cpp_init_metadata
01da75de  lea      rcx, [rip + 0x262a173] ; [43d1758] STR 'Boss07/bos07body3way'
01da75e5  call     0x4e0a50 ; il2cpp_init_metadata
01da75ea  lea      rcx, [rip + 0x262a66f] ; [43d1c60] STR 'Boss07/bos07leg2way'
01da75f1  call     0x4e0a50 ; il2cpp_init_metadata
01da75f6  lea      rcx, [rip + 0x262a2cb] ; [43d18c8] STR 'Boss07/bos07face'
01da75fd  call     0x4e0a50 ; il2cpp_init_metadata
01da7602  lea      rcx, [rip + 0x262a097] ; [43d16a0] STR 'Boss07/bos07body'
01da7609  call     0x4e0a50 ; il2cpp_init_metadata
01da760e  lea      rcx, [rip + 0x262a1fb] ; [43d1810] STR 'Boss07/bos07bodyS'
01da7615  call     0x4e0a50 ; il2cpp_init_metadata
01da761a  lea      rcx, [rip + 0x262a417] ; [43d1a38] STR 'Boss07/bos07leg'
01da7621  call     0x4e0a50 ; il2cpp_init_metadata
01da7626  lea      rcx, [rip + 0x2629fbb] ; [43d15e8] STR 'Boss07/bos07armh'
01da762d  call     0x4e0a50 ; il2cpp_init_metadata
01da7632  mov      byte ptr [rip + 0x28bc1e2], 1 ; [466381b] bss
01da7639  mov      rcx, qword ptr [rip + 0x25cbf40] ; [4373580] TypeInfo#32047
01da7640  mov      edx, 0xa
01da7645  movaps   xmmword ptr [rsp + 0x50], xmm10
01da764b  movaps   xmmword ptr [rsp + 0x40], xmm11
01da7651  call     0x4dfe00 ; ?
01da7656  mov      rbx, rax
01da7659  test     rax, rax
01da765c  je       0x1da7ef7
01da7662  cmp      dword ptr [rax + 0x18], 0
01da7666  mov      rdx, qword ptr [rip + 0x262a3cb] ; [43d1a38] STR 'Boss07/bos07leg'
01da766d  jbe      0x1da7efd
01da7673  lea      rcx, [rax + 0x20]
01da7677  mov      qword ptr [rax + 0x20], rdx
01da767b  call     0x4dfd80 ; ?
01da7680  cmp      dword ptr [rbx + 0x18], 1
01da7684  mov      rdx, qword ptr [rip + 0x262a51d] ; [43d1ba8] STR 'Boss07/bos07leg2'
01da768b  jbe      0x1da7efd
01da7691  lea      rcx, [rbx + 0x28]
01da7695  mov      qword ptr [rbx + 0x28], rdx
01da7699  call     0x4dfd80 ; ?
01da769e  cmp      dword ptr [rbx + 0x18], 2
01da76a2  mov      rdx, qword ptr [rip + 0x262a447] ; [43d1af0] STR 'Boss07/bos07leg1way'
01da76a9  jbe      0x1da7efd
01da76af  lea      rcx, [rbx + 0x30]
01da76b3  mov      qword ptr [rbx + 0x30], rdx
01da76b7  call     0x4dfd80 ; ?
01da76bc  cmp      dword ptr [rbx + 0x18], 3
01da76c0  mov      rdx, qword ptr [rip + 0x262a599] ; [43d1c60] STR 'Boss07/bos07leg2way'
01da76c7  jbe      0x1da7efd
01da76cd  lea      rcx, [rbx + 0x38]
01da76d1  mov      qword ptr [rbx + 0x38], rdx
01da76d5  call     0x4dfd80 ; ?
01da76da  cmp      dword ptr [rbx + 0x18], 4
01da76de  mov      rdx, qword ptr [rip + 0x262a073] ; [43d1758] STR 'Boss07/bos07body3way'
01da76e5  jbe      0x1da7efd
01da76eb  lea      rcx, [rbx + 0x40]
01da76ef  mov      qword ptr [rbx + 0x40], rdx
01da76f3  call     0x4dfd80 ; ?
01da76f8  cmp      dword ptr [rbx + 0x18], 5
01da76fc  mov      rdx, qword ptr [rip + 0x2629ee5] ; [43d15e8] STR 'Boss07/bos07armh'
01da7703  jbe      0x1da7efd
01da7709  lea      rcx, [rbx + 0x48]
01da770d  mov      qword ptr [rbx + 0x48], rdx
01da7711  call     0x4dfd80 ; ?
01da7716  cmp      dword ptr [rbx + 0x18], 6
01da771a  mov      rdx, qword ptr [rip + 0x2629f7f] ; [43d16a0] STR 'Boss07/bos07body'
01da7721  jbe      0x1da7efd
01da7727  lea      rcx, [rbx + 0x50]
01da772b  mov      qword ptr [rbx + 0x50], rdx
01da772f  call     0x4dfd80 ; ?
01da7734  cmp      dword ptr [rbx + 0x18], 7
01da7738  mov      rdx, qword ptr [rip + 0x262a0d1] ; [43d1810] STR 'Boss07/bos07bodyS'
01da773f  jbe      0x1da7efd
01da7745  lea      rcx, [rbx + 0x58]
01da7749  mov      qword ptr [rbx + 0x58], rdx
01da774d  call     0x4dfd80 ; ?
01da7752  cmp      dword ptr [rbx + 0x18], 8
01da7756  mov      rdx, qword ptr [rip + 0x262a16b] ; [43d18c8] STR 'Boss07/bos07face'
01da775d  jbe      0x1da7efd
01da7763  lea      rcx, [rbx + 0x60]
01da7767  mov      qword ptr [rbx + 0x60], rdx
01da776b  call     0x4dfd80 ; ?
01da7770  cmp      dword ptr [rbx + 0x18], 9
01da7774  mov      rdx, qword ptr [rip + 0x262a205] ; [43d1980] STR 'Boss07/bos07laser'
01da777b  jbe      0x1da7efd
01da7781  lea      rcx, [rbx + 0x68]
01da7785  mov      qword ptr [rbx + 0x68], rdx
01da7789  call     0x4dfd80 ; ?
01da778e  mov      rax, qword ptr [rip + 0x260a3e3] ; [43b1b78] TypeInfo#37312
01da7795  mov      rdx, rbx
01da7798  mov      rcx, qword ptr [rax + 0xb8]
01da779f  mov      qword ptr [rcx], rbx
01da77a2  mov      rcx, qword ptr [rip + 0x260a3cf] ; [43b1b78] TypeInfo#37312
01da77a9  mov      rcx, qword ptr [rcx + 0xb8]
01da77b0  call     0x4dfd80 ; ?
01da77b5  mov      rcx, qword ptr [rip + 0x25d23d4] ; [4379b90] TypeInfo#72448
01da77bc  mov      edx, 8
01da77c1  call     0x4dfe00 ; ?
01da77c6  movss    xmm1, dword ptr [rip + 0x184b606] ; [35f2dd4] f=135.0 d=1548112653041664.0 v4=(135.0, 150.0, -0.0, -25.0)
01da77ce  mov      rdx, rax
01da77d1  movss    xmm4, dword ptr [rip + 0x184b503] ; [35f2cdc] f=45.0 d=1099511898944.0 v4=(45.0, 60.0, 120.0, 300.0)
01da77d9  test     rax, rax
01da77dc  je       0x1da7ef7
01da77e2  cmp      dword ptr [rax + 0x18], 0
01da77e6  jbe      0x1da7efd
01da77ec  movss    xmm0, dword ptr [rip + 0x184b688] ; [35f2e7c] f=-45.0 d=-1.8446757419246682e+19 v4=(-45.0, -480.0, 0.002, 0.005)
01da77f4  movss    xmm5, dword ptr [rip + 0x17393dc] ; [34e0bd8] f=10.0 d=134217760.5625 v4=(10.0, 20.0, 57.29578, 100.0)
01da77fc  movss    xmm2, dword ptr [rip + 0x17393d8] ; [34e0bdc] f=20.0 d=727846620416.0 v4=(20.0, 57.29578, 100.0, 180.0)
01da7804  movss    xmm3, dword ptr [rip + 0x184b3a8] ; [35f2bb4] f=30.0 d=34359746808.0 v4=(30.0, 40.0, 50.0, 99.900002)
01da780c  unpcklps xmm0, xmm1
01da780f  movsd    qword ptr [rax + 0x20], xmm0
01da7814  movss    dword ptr [rax + 0x28], xmm4
01da7819  cmp      dword ptr [rax + 0x18], 1
01da781d  jbe      0x1da7efd
01da7823  movaps   xmm0, xmm5
01da7826  unpcklps xmm0, xmm2
01da7829  movsd    qword ptr [rax + 0x2c], xmm0
01da782e  movss    dword ptr [rax + 0x34], xmm3
01da7833  cmp      dword ptr [rax + 0x18], 2
01da7837  jbe      0x1da7efd
01da783d  movaps   xmm0, xmm5
01da7840  unpcklps xmm0, xmm2
01da7843  movsd    qword ptr [rax + 0x38], xmm0
01da7848  movss    dword ptr [rax + 0x40], xmm3
01da784d  cmp      dword ptr [rax + 0x18], 3
01da7851  jbe      0x1da7efd
01da7857  movss    xmm0, dword ptr [rip + 0x17451c9] ; [34eca28] f=-10.0 d=1.60082202e-314 v4=(-10.0, 0.0, 3370280550400.0, 2.142699)
01da785f  movss    xmm5, dword ptr [rip + 0x184b479] ; [35f2ce0] f=60.0 d=281475046375424.0 v4=(60.0, 120.0, 300.0, 720.0)
01da7867  unpcklps xmm0, xmm2
01da786a  movsd    qword ptr [rax + 0x44], xmm0
01da786f  movss    dword ptr [rax + 0x4c], xmm3
01da7874  cmp      dword ptr [rax + 0x18], 4
01da7878  jbe      0x1da7efd
01da787e  movss    xmm11, dword ptr [rip + 0x184b391] ; [35f2c18] f=-20.0 d=-206158529344.0 v4=(-20.0, -50.0, -200.0, 0.0)
01da7887  movaps   xmm0, xmm5
01da788a  unpcklps xmm0, xmm5
01da788d  movsd    qword ptr [rax + 0x50], xmm0
01da7892  movss    dword ptr [rax + 0x58], xmm5
01da7897  cmp      dword ptr [rax + 0x18], 5
01da789b  jbe      0x1da7efd
01da78a1  movaps   xmm0, xmm11
01da78a5  xorps    xmm10, xmm10
01da78a9  unpcklps xmm0, xmm2
01da78ac  movsd    qword ptr [rax + 0x5c], xmm0
01da78b1  movss    dword ptr [rax + 0x64], xmm3
01da78b6  cmp      dword ptr [rax + 0x18], 6
01da78ba  jbe      0x1da7efd
01da78c0  movaps   xmm0, xmm4
01da78c3  unpcklps xmm0, xmm4
01da78c6  movsd    qword ptr [rax + 0x68], xmm0
01da78cb  movss    dword ptr [rax + 0x70], xmm10
01da78d1  cmp      dword ptr [rax + 0x18], 7
01da78d5  jbe      0x1da7efd
01da78db  movaps   xmmword ptr [rsp + 0x90], xmm6
01da78e3  movaps   xmm0, xmm4
01da78e6  movaps   xmmword ptr [rsp + 0x80], xmm7
01da78ee  unpcklps xmm0, xmm4
01da78f1  movsd    qword ptr [rax + 0x74], xmm0
01da78f6  movss    dword ptr [rax + 0x7c], xmm4
01da78fb  mov      rax, qword ptr [rip + 0x260a276] ; [43b1b78] TypeInfo#37312
01da7902  movaps   xmmword ptr [rsp + 0x70], xmm8
01da7908  movaps   xmmword ptr [rsp + 0x60], xmm9
01da790e  mov      rcx, qword ptr [rax + 0xb8]
01da7915  mov      qword ptr [rcx + 8], rdx
01da7919  mov      rax, qword ptr [rip + 0x260a258] ; [43b1b78] TypeInfo#37312
01da7920  mov      rcx, qword ptr [rax + 0xb8]
01da7927  add      rcx, 8
01da792b  call     0x4dfd80 ; ?
01da7930  mov      rax, qword ptr [rip + 0x260a241] ; [43b1b78] TypeInfo#37312
01da7937  lea      rdx, [rsp + 0x20]
01da793c  movss    xmm2, dword ptr [rip + 0x184b49c] ; [35f2de0] f=-25.0 d=-4294970396.5 v4=(-25.0, -30.0, -35.0, -40.0)
01da7944  xor      r8d, r8d
01da7947  movss    xmm9, dword ptr [rip + 0x184b508] ; [35f2e58] f=48.0 d=1.8446748626374885e+19 v4=(48.0, 480.0, -0.05, -0.12)
01da7950  movaps   xmm0, xmm2
01da7953  movss    xmm8, dword ptr [rip + 0x184b51c] ; [35f2e78] f=-16.0 d=-85899395456.0 v4=(-16.0, -45.0, -480.0, 0.002)
01da795c  mov      rcx, qword ptr [rax + 0xb8]
01da7963  movss    xmm7, dword ptr [rip + 0x184b425] ; [35f2d90] f=16.0 d=-5.238690747476002e-11 v4=(16.0, -0.1, -0.25, -0.75)
01da796b  movss    xmm6, dword ptr [rip + 0x184b255] ; [35f2bc8] f=-100.0 d=-7.673848961291161e+21 v4=(-100.0, -1000.0, 0.5, 0.5)
01da7973  unpcklps xmm0, xmm10
01da7977  movsd    qword ptr [rcx + 0x10], xmm0
01da797c  movaps   xmm0, xmm2
01da797f  movss    dword ptr [rcx + 0x18], xmm8
01da7985  mov      rax, qword ptr [rip + 0x260a1ec] ; [43b1b78] TypeInfo#37312
01da798c  unpcklps xmm0, xmm10
01da7990  mov      qword ptr [rsp + 0x20], 0x3fc6d3f2
01da7999  mov      dword ptr [rsp + 0x28], 0
01da79a1  mov      rcx, qword ptr [rax + 0xb8]
01da79a8  movsd    qword ptr [rcx + 0x1c], xmm0
01da79ad  movaps   xmm0, xmm2
01da79b0  movss    dword ptr [rcx + 0x24], xmm7
01da79b5  mov      rax, qword ptr [rip + 0x260a1bc] ; [43b1b78] TypeInfo#37312
01da79bc  unpcklps xmm0, xmm10
01da79c0  mov      rcx, qword ptr [rax + 0xb8]
01da79c7  movsd    qword ptr [rcx + 0x28], xmm0
01da79cc  movaps   xmm0, xmm2
01da79cf  movss    dword ptr [rcx + 0x30], xmm9
01da79d5  mov      rax, qword ptr [rip + 0x260a19c] ; [43b1b78] TypeInfo#37312
01da79dc  unpcklps xmm0, xmm6
01da79df  mov      rcx, qword ptr [rax + 0xb8]
01da79e6  movsd    qword ptr [rcx + 0x34], xmm0
01da79eb  movss    dword ptr [rcx + 0x3c], xmm9
01da79f1  lea      rcx, [rsp + 0x30]
01da79f6  call     0x304d890 ; Quaternion Quaternion::Internal_FromEulerRad(Vector3&)
01da79fb  xor      r8d, r8d
01da79fe  lea      rdx, [rsp + 0x20]
01da7a03  movups   xmm0, xmmword ptr [rax]
01da7a06  mov      rax, qword ptr [rip + 0x260a16b] ; [43b1b78] TypeInfo#37312
01da7a0d  mov      dword ptr [rsp + 0x20], 0
01da7a15  mov      dword ptr [rsp + 0x24], 0xbfc6d3f2
01da7a1d  mov      dword ptr [rsp + 0x28], 0
01da7a25  mov      rcx, qword ptr [rax + 0xb8]
01da7a2c  movups   xmmword ptr [rcx + 0x40], xmm0
01da7a30  lea      rcx, [rsp + 0x30]
01da7a35  call     0x304d890 ; Quaternion Quaternion::Internal_FromEulerRad(Vector3&)
01da7a3a  xor      r8d, r8d
01da7a3d  lea      rdx, [rsp + 0x20]
01da7a42  movups   xmm0, xmmword ptr [rax]
01da7a45  mov      rax, qword ptr [rip + 0x260a12c] ; [43b1b78] TypeInfo#37312
01da7a4c  mov      dword ptr [rsp + 0x20], 0
01da7a54  mov      qword ptr [rsp + 0x24], 0x3fc6d3f2
01da7a5d  mov      rcx, qword ptr [rax + 0xb8]
01da7a64  movups   xmmword ptr [rcx + 0x50], xmm0
01da7a68  lea      rcx, [rsp + 0x30]
01da7a6d  call     0x304d890 ; Quaternion Quaternion::Internal_FromEulerRad(Vector3&)
01da7a72  movss    xmm2, dword ptr [rip + 0x184b176] ; [35f2bf0] f=25.0 d=457396906131456.0 v4=(25.0, 125.0, 200.0, 999.0)
01da7a7a  movups   xmm0, xmmword ptr [rax]
01da7a7d  mov      rax, qword ptr [rip + 0x260a0f4] ; [43b1b78] TypeInfo#37312
01da7a84  mov      rcx, qword ptr [rax + 0xb8]
01da7a8b  movups   xmmword ptr [rcx + 0x60], xmm0
01da7a8f  mov      rax, qword ptr [rip + 0x260a0e2] ; [43b1b78] TypeInfo#37312
01da7a96  movaps   xmm0, xmm2
01da7a99  unpcklps xmm0, xmm10
01da7a9d  mov      rcx, qword ptr [rax + 0xb8]
01da7aa4  movsd    qword ptr [rcx + 0x70], xmm0
01da7aa9  movss    dword ptr [rcx + 0x78], xmm8
01da7aaf  movaps   xmm0, xmm2
01da7ab2  mov      rax, qword ptr [rip + 0x260a0bf] ; [43b1b78] TypeInfo#37312
01da7ab9  movss    xmm1, dword ptr [rip + 0x184b3af] ; [35f2e70] f=-9.0 d=-16777228.06640625 v4=(-9.0, -15.0, -16.0, -45.0)
01da7ac1  unpcklps xmm0, xmm10
01da7ac5  mov      rcx, qword ptr [rax + 0xb8]
01da7acc  movsd    qword ptr [rcx + 0x7c], xmm0
01da7ad1  movaps   xmm0, xmm2
01da7ad4  movss    dword ptr [rcx + 0x84], xmm7
01da7adc  mov      rax, qword ptr [rip + 0x260a095] ; [43b1b78] TypeInfo#37312
01da7ae3  unpcklps xmm0, xmm10
01da7ae7  mov      rcx, qword ptr [rax + 0xb8]
01da7aee  movsd    qword ptr [rcx + 0x88], xmm0
01da7af6  movaps   xmm0, xmm2
01da7af9  movss    dword ptr [rcx + 0x90], xmm9
01da7b02  mov      rax, qword ptr [rip + 0x260a06f] ; [43b1b78] TypeInfo#37312
01da7b09  movss    xmm2, dword ptr [rip + 0x184b35b] ; [35f2e6c] f=-8.0 d=-262144.1884765625 v4=(-8.0, -9.0, -15.0, -16.0)
01da7b11  unpcklps xmm0, xmm6
01da7b14  mov      rcx, qword ptr [rax + 0xb8]
01da7b1b  movsd    qword ptr [rcx + 0x94], xmm0
01da7b23  xorps    xmm0, xmm0
01da7b26  movss    dword ptr [rcx + 0x9c], xmm9
01da7b2f  mov      rax, qword ptr [rip + 0x260a042] ; [43b1b78] TypeInfo#37312
01da7b36  unpcklps xmm0, xmm1
01da7b39  mov      rcx, qword ptr [rax + 0xb8]
01da7b40  movsd    qword ptr [rcx + 0xa0], xmm0
01da7b48  xorps    xmm0, xmm0
01da7b4b  movss    dword ptr [rcx + 0xa8], xmm2
01da7b53  mov      rax, qword ptr [rip + 0x260a01e] ; [43b1b78] TypeInfo#37312
01da7b5a  movss    xmm2, dword ptr [rip + 0x184b312] ; [35f2e74] f=-15.0 d=-33554456.1796875 v4=(-15.0, -16.0, -45.0, -480.0)
01da7b62  unpcklps xmm0, xmm10
01da7b66  mov      rcx, qword ptr [rax + 0xb8]
01da7b6d  movsd    qword ptr [rcx + 0xac], xmm0
01da7b75  xorps    xmm0, xmm0
01da7b78  movss    dword ptr [rcx + 0xb4], xmm2
01da7b80  mov      rax, qword ptr [rip + 0x2609ff1] ; [43b1b78] TypeInfo#37312
01da7b87  unpcklps xmm0, xmm10
01da7b8b  mov      rcx, qword ptr [rax + 0xb8]
01da7b92  movsd    qword ptr [rcx + 0xb8], xmm0
01da7b9a  movss    dword ptr [rcx + 0xc0], xmm11
01da7ba3  mov      rax, qword ptr [rip + 0x2609fce] ; [43b1b78] TypeInfo#37312
01da7baa  mov      rcx, qword ptr [rax + 0xb8]
01da7bb1  mov      dword ptr [rcx + 0xc4], 0x40600000
01da7bbb  mov      rax, qword ptr [rip + 0x2609fb6] ; [43b1b78] TypeInfo#37312
01da7bc2  mov      rcx, qword ptr [rax + 0xb8]
01da7bc9  mov      dword ptr [rcx + 0xc8], 0x41f00000
01da7bd3  mov      rax, qword ptr [rip + 0x2609f9e] ; [43b1b78] TypeInfo#37312
01da7bda  mov      rcx, qword ptr [rax + 0xb8]
01da7be1  mov      dword ptr [rcx + 0xcc], 0xc2480000
01da7beb  mov      rdx, qword ptr [rip + 0x2609f86] ; [43b1b78] TypeInfo#37312
01da7bf2  mov      rax, qword ptr [rdx + 0xb8]
01da7bf9  movss    xmm0, dword ptr [rax + 0xc8]
01da7c01  divss    xmm0, dword ptr [rax + 0xcc]
01da7c09  movss    dword ptr [rax + 0xd0], xmm0
01da7c11  xorps    xmm0, xmm0
01da7c14  mov      rcx, qword ptr [rip + 0x2609f5d] ; [43b1b78] TypeInfo#37312
01da7c1b  unpcklps xmm0, xmm10
01da7c1f  mov      rax, qword ptr [rcx + 0xb8]
01da7c26  movss    xmm2, dword ptr [rax + 0xcc]
01da7c2e  movsd    qword ptr [rax + 0xd4], xmm0
01da7c36  movss    dword ptr [rax + 0xdc], xmm2
01da7c3e  mov      rax, qword ptr [rip + 0x2609f33] ; [43b1b78] TypeInfo#37312
01da7c45  mov      rcx, qword ptr [rax + 0xb8]
01da7c4c  mov      dword ptr [rcx + 0xe0], 0x3f800000
01da7c56  mov      rax, qword ptr [rip + 0x2609f1b] ; [43b1b78] TypeInfo#37312
01da7c5d  mov      rcx, qword ptr [rax + 0xb8]
01da7c64  mov      dword ptr [rcx + 0xe4], 0x3e4ccccd
01da7c6e  mov      rax, qword ptr [rip + 0x2609f03] ; [43b1b78] TypeInfo#37312
01da7c75  mov      rcx, qword ptr [rax + 0xb8]
01da7c7c  mov      dword ptr [rcx + 0xe8], 0x40c00000
01da7c86  mov      rax, qword ptr [rip + 0x2609eeb] ; [43b1b78] TypeInfo#37312
01da7c8d  mov      rcx, qword ptr [rax + 0xb8]
01da7c94  mov      dword ptr [rcx + 0xec], 0xf
01da7c9e  mov      rax, qword ptr [rip + 0x2609ed3] ; [43b1b78] TypeInfo#37312
01da7ca5  mov      rcx, qword ptr [rax + 0xb8]
01da7cac  mov      dword ptr [rcx + 0xf0], 0x41a00000
01da7cb6  mov      rax, qword ptr [rip + 0x2609ebb] ; [43b1b78] TypeInfo#37312
01da7cbd  mov      rcx, qword ptr [rax + 0xb8]
01da7cc4  mov      dword ptr [rcx + 0xf4], 0x3e2aaaab
01da7cce  mov      rax, qword ptr [rip + 0x2609ea3] ; [43b1b78] TypeInfo#37312
01da7cd5  mov      rcx, qword ptr [rax + 0xb8]
01da7cdc  mov      dword ptr [rcx + 0xf8], 0x3fc00000
01da7ce6  mov      rax, qword ptr [rip + 0x2609e8b] ; [43b1b78] TypeInfo#37312
01da7ced  movaps   xmm9, xmmword ptr [rsp + 0x60]
01da7cf3  movaps   xmm8, xmmword ptr [rsp + 0x70]
01da7cf9  movaps   xmm7, xmmword ptr [rsp + 0x80]
01da7d01  mov      rcx, qword ptr [rax + 0xb8]
01da7d08  movaps   xmm6, xmmword ptr [rsp + 0x90]
01da7d10  movaps   xmm11, xmmword ptr [rsp + 0x40]
01da7d16  movaps   xmm10, xmmword ptr [rsp + 0x50]
01da7d1c  mov      dword ptr [rcx + 0xfc], 0x3fe66666
01da7d26  mov      rax, qword ptr [rip + 0x2609e4b] ; [43b1b78] TypeInfo#37312
01da7d2d  mov      rcx, qword ptr [rax + 0xb8]
01da7d34  mov      dword ptr [rcx + 0x100], 0x3e4ccccd
01da7d3e  mov      rax, qword ptr [rip + 0x2609e33] ; [43b1b78] TypeInfo#37312
01da7d45  mov      rcx, qword ptr [rax + 0xb8]
01da7d4c  mov      dword ptr [rcx + 0x104], 0x3f4ccccd
01da7d56  mov      rax, qword ptr [rip + 0x2609e1b] ; [43b1b78] TypeInfo#37312
01da7d5d  mov      rcx, qword ptr [rax + 0xb8]
01da7d64  mov      dword ptr [rcx + 0x108], 0x3e4ccccd
01da7d6e  mov      rax, qword ptr [rip + 0x2609e03] ; [43b1b78] TypeInfo#37312
01da7d75  mov      rcx, qword ptr [rax + 0xb8]
01da7d7c  mov      dword ptr [rcx + 0x10c], 0x3f000000
01da7d86  mov      rax, qword ptr [rip + 0x2609deb] ; [43b1b78] TypeInfo#37312
01da7d8d  mov      rcx, qword ptr [rax + 0xb8]
01da7d94  mov      dword ptr [rcx + 0x110], 0x3f800000
01da7d9e  mov      rax, qword ptr [rip + 0x2609dd3] ; [43b1b78] TypeInfo#37312
01da7da5  mov      rcx, qword ptr [rax + 0xb8]
01da7dac  mov      dword ptr [rcx + 0x114], 0x3f000000
01da7db6  mov      rax, qword ptr [rip + 0x2609dbb] ; [43b1b78] TypeInfo#37312
01da7dbd  mov      rcx, qword ptr [rax + 0xb8]
01da7dc4  mov      dword ptr [rcx + 0x118], 0x3f400000
01da7dce  mov      rax, qword ptr [rip + 0x2609da3] ; [43b1b78] TypeInfo#37312
01da7dd5  mov      rcx, qword ptr [rax + 0xb8]
01da7ddc  mov      dword ptr [rcx + 0x11c], 0x3f800000
01da7de6  mov      rax, qword ptr [rip + 0x2609d8b] ; [43b1b78] TypeInfo#37312
01da7ded  mov      rcx, qword ptr [rax + 0xb8]
01da7df4  mov      dword ptr [rcx + 0x120], 0x3f99999a
01da7dfe  mov      rax, qword ptr [rip + 0x2609d73] ; [43b1b78] TypeInfo#37312
01da7e05  mov      rcx, qword ptr [rax + 0xb8]
01da7e0c  mov      dword ptr [rcx + 0x124], 0x41000000
01da7e16  mov      rax, qword ptr [rip + 0x2609d5b] ; [43b1b78] TypeInfo#37312
01da7e1d  mov      rcx, qword ptr [rax + 0xb8]
01da7e24  mov      dword ptr [rcx + 0x128], 0x3f000000
01da7e2e  mov      rax, qword ptr [rip + 0x2609d43] ; [43b1b78] TypeInfo#37312
01da7e35  mov      rcx, qword ptr [rax + 0xb8]
01da7e3c  mov      dword ptr [rcx + 0x12c], 0x40000000
01da7e46  mov      rax, qword ptr [rip + 0x2609d2b] ; [43b1b78] TypeInfo#37312
01da7e4d  mov      rcx, qword ptr [rax + 0xb8]
01da7e54  mov      dword ptr [rcx + 0x130], 0x40400000
01da7e5e  mov      rax, qword ptr [rip + 0x2609d13] ; [43b1b78] TypeInfo#37312
01da7e65  mov      rcx, qword ptr [rax + 0xb8]
01da7e6c  mov      dword ptr [rcx + 0x134], 0x40000000
01da7e76  mov      rax, qword ptr [rip + 0x2609cfb] ; [43b1b78] TypeInfo#37312
01da7e7d  mov      rcx, qword ptr [rax + 0xb8]
01da7e84  mov      dword ptr [rcx + 0x138], 0x40000000
01da7e8e  mov      rax, qword ptr [rip + 0x2609ce3] ; [43b1b78] TypeInfo#37312
01da7e95  mov      rcx, qword ptr [rax + 0xb8]
01da7e9c  mov      dword ptr [rcx + 0x13c], 0x3dcccccd
01da7ea6  mov      rax, qword ptr [rip + 0x2609ccb] ; [43b1b78] TypeInfo#37312
01da7ead  mov      rcx, qword ptr [rax + 0xb8]
01da7eb4  mov      dword ptr [rcx + 0x140], 0x41700000
01da7ebe  mov      rax, qword ptr [rip + 0x2609cb3] ; [43b1b78] TypeInfo#37312
01da7ec5  mov      rcx, qword ptr [rax + 0xb8]
01da7ecc  mov      dword ptr [rcx + 0x144], 0x40800000
01da7ed6  mov      rax, qword ptr [rip + 0x2609c9b] ; [43b1b78] TypeInfo#37312
01da7edd  mov      rcx, qword ptr [rax + 0xb8]
01da7ee4  mov      dword ptr [rcx + 0x148], 0x3f4ccccd
01da7eee  add      rsp, 0xa0
01da7ef5  pop      rbx
01da7ef6  ret      
01da7ef7  call     0x4e0d00 ; ThrowNullRef
01da7efc  int3     
01da7efd  call     0x4e0cf0 ; ?
01da7f02  int3     
01da7f03  int3     
01da7f04  int3     
01da7f05  int3     
01da7f06  int3     
01da7f07  int3     
01da7f08  int3     
01da7f09  int3     
01da7f0a  int3     
01da7f0b  int3     
01da7f0c  int3     
01da7f0d  int3     
01da7f0e  int3     
01da7f0f  int3     

### Void Enemy.Ene_Bos07::<HomingLeg>g__calc|125_0(Single,Transform,Transform,Single,Boolean,Single,Single,Enemy.Ene_Bos07/<>c__DisplayClass125_0&)  RVA=0x1DA6850 len=0x710
01da6850  mov      qword ptr [rsp + 0x18], rbx
01da6855  push     rbp
01da6856  push     rsi
01da6857  push     rdi
01da6858  push     r12
01da685a  push     r15
01da685c  lea      rbp, [rsp - 0x20]
01da6861  sub      rsp, 0x120
01da6868  cmp      byte ptr [rip + 0x28bcfad], 0 ; [466381c] bss
01da686f  mov      r15, r9
01da6872  movaps   xmmword ptr [rsp + 0xd0], xmm10
01da687b  mov      r12, r8
01da687e  movaps   xmm10, xmm1
01da6882  mov      rsi, rcx
01da6885  jne      0x1da689a
01da6887  lea      rcx, [rip + 0x260b2ea] ; [43b1b78] TypeInfo#37312
01da688e  call     0x4e0a50 ; il2cpp_init_metadata
01da6893  mov      byte ptr [rip + 0x28bcf82], 1 ; [466381c] bss
01da689a  mov      rbx, qword ptr [rbp + 0x90]
01da68a1  xor      eax, eax
01da68a3  mov      qword ptr [rsp + 0x150], r13
01da68ab  mov      qword ptr [rsp + 0x158], r14
01da68b3  movaps   xmmword ptr [rsp + 0x110], xmm6
01da68bb  mov      rdi, qword ptr [rbx]
01da68be  movaps   xmmword ptr [rsp + 0x100], xmm7
01da68c6  movaps   xmmword ptr [rsp + 0xf0], xmm8
01da68cf  movaps   xmmword ptr [rsp + 0xe0], xmm9
01da68d8  movaps   xmmword ptr [rsp + 0xc0], xmm11
01da68e1  movaps   xmmword ptr [rsp + 0xb0], xmm12
01da68ea  movaps   xmmword ptr [rsp + 0xa0], xmm13
01da68f3  movaps   xmmword ptr [rsp + 0x90], xmm14
01da68fc  mov      qword ptr [rsp + 0x50], rax
01da6901  mov      dword ptr [rsp + 0x58], eax
01da6905  mov      qword ptr [rsp + 0x60], rax
01da690a  mov      dword ptr [rsp + 0x68], eax
01da690e  test     r12, r12
01da6911  je       0x1da6f51
01da6917  xor      r8d, r8d
01da691a  lea      rcx, [rbp - 0x80]
01da691e  mov      rdx, r12
01da6921  call     0x3093ba0 ; Vector3 Transform::get_position()
01da6926  mov      rdx, qword ptr [rsi]
01da6929  mov      rcx, rsi
01da692c  movsd    xmm6, qword ptr [rax]
01da6930  mov      r14d, dword ptr [rax + 8]
01da6934  mov      rax, qword ptr [rdx + 0x238]
01da693b  mov      rdx, qword ptr [rdx + 0x240]
01da6942  call     rax
01da6944  test     rdi, rdi
01da6947  je       0x1da6f51
01da694d  xor      r13d, r13d
01da6950  movsd    qword ptr [rsp + 0x40], xmm6
01da6956  movzx    r9d, al
01da695a  mov      qword ptr [rsp + 0x20], r13
01da695f  lea      r8, [rsp + 0x40]
01da6964  mov      dword ptr [rsp + 0x48], r14d
01da6969  mov      rdx, rdi
01da696c  lea      rcx, [rbp - 0x80]
01da6970  call     0x1ce6750 ; Vector3 InGameManager::GetSkyRootPosition(Vector3,Boolean)
01da6975  movsd    xmm6, qword ptr [rbx + 0x10]
01da697a  xorps    xmm8, xmm8
01da697e  mov      r14d, dword ptr [rbx + 0x18]
01da6982  movsd    xmm0, qword ptr [rax]
01da6986  mov      edi, dword ptr [rax + 8]
01da6989  mov      rax, qword ptr [rip + 0x260b1e8] ; [43b1b78] TypeInfo#37312
01da6990  movsd    qword ptr [rsp + 0x40], xmm0
01da6996  movss    dword ptr [rsp + 0x44], xmm8
01da699d  cmp      dword ptr [rax + 0xe4], r13d
01da69a4  jne      0x1da69b5
01da69a6  mov      rcx, rax
01da69a9  call     0x4e0d90 ; il2cpp_class_init
01da69ae  mov      rax, qword ptr [rip + 0x260b1c3] ; [43b1b78] TypeInfo#37312
01da69b5  mov      rax, qword ptr [rax + 0xb8]
01da69bc  lea      rcx, [rsp + 0x60]
01da69c1  movsd    xmm0, qword ptr [rsp + 0x40]
01da69c7  lea      r8, [rsp + 0x70]
01da69cc  mov      qword ptr [rsp + 0x30], r13
01da69d1  lea      rdx, [rbp - 0x80]
01da69d5  mov      qword ptr [rsp + 0x28], rcx
01da69da  lea      rcx, [rsp + 0x50]
01da69df  movss    xmm3, dword ptr [rax + 0xf0]
01da69e7  mov      qword ptr [rsp + 0x20], rcx
01da69ec  mov      rcx, rsi
01da69ef  movsd    qword ptr [rsp + 0x70], xmm6
01da69f5  mov      dword ptr [rsp + 0x78], r14d
01da69fa  movsd    qword ptr [rbp - 0x80], xmm0
01da69ff  mov      dword ptr [rbp - 0x78], edi
01da6a02  call     0x1da12e0 ; Boolean Enemy.Ene_Bos07::GetTangentPoints(Vector3,Vector3,Single,Vector3&,Vector3&)
01da6a07  test     al, al
01da6a09  je       0x1da6edf
01da6a0f  cmp      byte ptr [rip + 0x28b5b12], r13b ; [465c528] bss
01da6a16  movsd    xmm0, qword ptr [rbx + 0x10]
01da6a1b  movss    xmm12, dword ptr [rsp + 0x40]
01da6a22  movaps   xmm7, xmm0
01da6a25  movss    xmm9, dword ptr [rbx + 0x18]
01da6a2b  subss    xmm7, xmm12
01da6a30  movaps   xmm6, xmm0
01da6a33  movsd    qword ptr [rbp - 0x80], xmm0
01da6a38  shufps   xmm6, xmm6, 0x55
01da6a3c  subss    xmm6, xmm8
01da6a41  movd     xmm13, edi
01da6a46  subss    xmm9, xmm13
01da6a4b  movaps   xmm0, xmm7
01da6a4e  unpcklps xmm0, xmm6
01da6a51  movsd    qword ptr [rsp + 0x40], xmm0
01da6a57  movss    dword ptr [rsp + 0x48], xmm9
01da6a5e  jne      0x1da6a73
01da6a60  lea      rcx, [rip + 0x261ac71] ; [43c16d8] TypeInfo#48704
01da6a67  call     0x4e0a50 ; il2cpp_init_metadata
01da6a6c  mov      byte ptr [rip + 0x28b5ab5], 1 ; [465c528] bss
01da6a73  xor      edx, edx
01da6a75  lea      rcx, [rsp + 0x40]
01da6a7a  call     0x5d2df0 ; Vector3.Magnitude
01da6a7f  movss    xmm14, dword ptr [rip + 0x173a1d8] ; [34e0c60] f=9.999999747378752e-06 d=-2.000000410939455 v4=(1e-05, -2.0, 6.211745610597864e+22, 1.86130400330351e+34)
01da6a88  comiss   xmm0, xmm14
01da6a8c  jbe      0x1da6aab
01da6a8e  divss    xmm7, xmm0
01da6a92  divss    xmm6, xmm0
01da6a96  divss    xmm9, xmm0
01da6a9b  unpcklps xmm7, xmm6
01da6a9e  movsd    qword ptr [rsp + 0x70], xmm7
01da6aa4  movd     edi, xmm9
01da6aa9  jmp      0x1da6ac6
01da6aab  mov      rax, qword ptr [rip + 0x261ac26] ; [43c16d8] TypeInfo#48704
01da6ab2  mov      rcx, qword ptr [rax + 0xb8]
01da6ab9  movsd    xmm0, qword ptr [rcx]
01da6abd  mov      edi, dword ptr [rcx + 8]
01da6ac0  movsd    qword ptr [rsp + 0x70], xmm0
01da6ac6  cmp      byte ptr [rip + 0x28b5a5b], r13b ; [465c528] bss
01da6acd  movss    xmm6, dword ptr [rsp + 0x50]
01da6ad3  movss    xmm7, dword ptr [rsp + 0x54]
01da6ad9  subss    xmm6, xmm12
01da6ade  movss    xmm9, dword ptr [rsp + 0x58]
01da6ae5  subss    xmm7, xmm8
01da6aea  subss    xmm9, xmm13
01da6aef  movaps   xmm0, xmm6
01da6af2  unpcklps xmm0, xmm7
01da6af5  movsd    qword ptr [rsp + 0x40], xmm0
01da6afb  movss    dword ptr [rsp + 0x48], xmm9
01da6b02  jne      0x1da6b17
01da6b04  lea      rcx, [rip + 0x261abcd] ; [43c16d8] TypeInfo#48704
01da6b0b  call     0x4e0a50 ; il2cpp_init_metadata
01da6b10  mov      byte ptr [rip + 0x28b5a11], 1 ; [465c528] bss
01da6b17  xor      edx, edx
01da6b19  lea      rcx, [rsp + 0x40]
01da6b1e  call     0x5d2df0 ; Vector3.Magnitude
01da6b23  comiss   xmm0, xmm14
01da6b27  jbe      0x1da6b45
01da6b29  divss    xmm6, xmm0
01da6b2d  divss    xmm7, xmm0
01da6b31  divss    xmm9, xmm0
01da6b36  unpcklps xmm6, xmm7
01da6b39  movsd    qword ptr [rbp - 0x80], xmm6
01da6b3e  movd     eax, xmm9
01da6b43  jmp      0x1da6b5f
01da6b45  mov      rax, qword ptr [rip + 0x261ab8c] ; [43c16d8] TypeInfo#48704
01da6b4c  mov      rcx, qword ptr [rax + 0xb8]
01da6b53  movsd    xmm0, qword ptr [rcx]
01da6b57  mov      eax, dword ptr [rcx + 8]
01da6b5a  movsd    qword ptr [rbp - 0x80], xmm0
01da6b5f  movss    xmm0, dword ptr [rsp + 0x70]
01da6b65  movss    xmm7, dword ptr [rbp - 0x80]
01da6b6a  movd     xmm1, edi
01da6b6e  movd     xmm11, eax
01da6b73  call     0x578890 ; atan2f(y,x)
01da6b78  movaps   xmm6, xmm0
01da6b7b  movaps   xmm1, xmm11
01da6b7f  mulss    xmm6, dword ptr [rip + 0x173a059] ; [34e0be0] f=57.295780181884766 d=52776566835805.76 v4=(57.29578, 100.0, 180.0, 2000.0)
01da6b87  movaps   xmm0, xmm7
01da6b8a  call     0x578890 ; atan2f(y,x)
01da6b8f  mulss    xmm0, dword ptr [rip + 0x173a049] ; [34e0be0] f=57.295780181884766 d=52776566835805.76 v4=(57.29578, 100.0, 180.0, 2000.0)
01da6b97  movss    xmm9, dword ptr [rip + 0x1745d78] ; [34ec918] f=360.0 d=1.4044481158322838e+306 v4=(360.0, inf, nan, nan)
01da6ba0  subss    xmm6, xmm0
01da6ba4  movaps   xmm0, xmm6
01da6ba7  divss    xmm0, xmm9
01da6bac  call     0x578740 ; floorf
01da6bb1  mulss    xmm0, xmm9
01da6bb6  subss    xmm6, xmm0
01da6bba  comiss   xmm8, xmm6
01da6bbe  ja       0x1da6bcc
01da6bc0  comiss   xmm6, xmm9
01da6bc4  jbe      0x1da6bcf
01da6bc6  movaps   xmm6, xmm9
01da6bca  jmp      0x1da6bcf
01da6bcc  xorps    xmm6, xmm6
01da6bcf  comiss   xmm6, dword ptr [rip + 0x173a012] ; [34e0be8] f=180.0 d=1.964504759529741e+24 v4=(180.0, 2000.0, -0.0001, -1.0)
01da6bd6  jbe      0x1da6bdd
01da6bd8  subss    xmm6, xmm9
01da6bdd  comiss   xmm6, xmm8
01da6be1  seta     al
01da6be4  cmp      byte ptr [rbp + 0x78], al
01da6be7  je       0x1da6c90
01da6bed  cmp      byte ptr [rip + 0x28b5934], r13b ; [465c528] bss
01da6bf4  movss    xmm6, dword ptr [rsp + 0x60]
01da6bfa  movss    xmm7, dword ptr [rsp + 0x64]
01da6c00  subss    xmm6, xmm12
01da6c05  movss    xmm11, dword ptr [rsp + 0x68]
01da6c0c  subss    xmm7, xmm8
01da6c11  subss    xmm11, xmm13
01da6c16  movaps   xmm0, xmm6
01da6c19  unpcklps xmm0, xmm7
01da6c1c  movsd    qword ptr [rsp + 0x40], xmm0
01da6c22  movss    dword ptr [rsp + 0x48], xmm11
01da6c29  jne      0x1da6c3e
01da6c2b  lea      rcx, [rip + 0x261aaa6] ; [43c16d8] TypeInfo#48704
01da6c32  call     0x4e0a50 ; il2cpp_init_metadata
01da6c37  mov      byte ptr [rip + 0x28b58ea], 1 ; [465c528] bss
01da6c3e  xor      edx, edx
01da6c40  lea      rcx, [rsp + 0x40]
01da6c45  call     0x5d2df0 ; Vector3.Magnitude
01da6c4a  comiss   xmm0, xmm14
01da6c4e  jbe      0x1da6c6c
01da6c50  divss    xmm6, xmm0
01da6c54  divss    xmm7, xmm0
01da6c58  divss    xmm11, xmm0
01da6c5d  unpcklps xmm6, xmm7
01da6c60  movsd    qword ptr [rbp - 0x80], xmm6
01da6c65  movd     eax, xmm11
01da6c6a  jmp      0x1da6c86
01da6c6c  mov      rax, qword ptr [rip + 0x261aa65] ; [43c16d8] TypeInfo#48704
01da6c73  mov      rcx, qword ptr [rax + 0xb8]
01da6c7a  movsd    xmm0, qword ptr [rcx]
01da6c7e  mov      eax, dword ptr [rcx + 8]
01da6c81  movsd    qword ptr [rbp - 0x80], xmm0
01da6c86  movss    xmm7, dword ptr [rbp - 0x80]
01da6c8b  movd     xmm11, eax
01da6c90  mov      rbx, qword ptr [rbx]
01da6c93  test     r15, r15
01da6c96  je       0x1da6f51
01da6c9c  xor      r8d, r8d
01da6c9f  lea      rcx, [rbp - 0x80]
01da6ca3  mov      rdx, r15
01da6ca6  call     0x3093ba0 ; Vector3 Transform::get_position()
01da6cab  mov      rdx, qword ptr [rsi]
01da6cae  mov      rcx, rsi
01da6cb1  movsd    xmm6, qword ptr [rax]
01da6cb5  mov      edi, dword ptr [rax + 8]
01da6cb8  mov      rax, qword ptr [rdx + 0x238]
01da6cbf  mov      rdx, qword ptr [rdx + 0x240]
01da6cc6  call     rax
01da6cc8  test     rbx, rbx
01da6ccb  je       0x1da6f51
01da6cd1  movzx    r9d, al
01da6cd5  movsd    qword ptr [rbp - 0x80], xmm6
01da6cda  lea      r8, [rbp - 0x80]
01da6cde  mov      dword ptr [rbp - 0x78], edi
01da6ce1  mov      rdx, rbx
01da6ce4  mov      qword ptr [rsp + 0x20], r13
01da6ce9  lea      rcx, [rsp + 0x70]
01da6cee  call     0x1ce6750 ; Vector3 InGameManager::GetSkyRootPosition(Vector3,Boolean)
01da6cf3  cmp      byte ptr [rip + 0x28b582e], r13b ; [465c528] bss
01da6cfa  movsd    xmm0, qword ptr [rax]
01da6cfe  subss    xmm13, dword ptr [rax + 8]
01da6d04  subss    xmm12, xmm0
01da6d09  movsd    qword ptr [rbp - 0x80], xmm0
01da6d0e  movss    dword ptr [rsp + 0x48], xmm13
01da6d15  movaps   xmm0, xmm12
01da6d19  unpcklps xmm0, xmm8
01da6d1d  movsd    qword ptr [rsp + 0x40], xmm0
01da6d23  jne      0x1da6d38
01da6d25  lea      rcx, [rip + 0x261a9ac] ; [43c16d8] TypeInfo#48704
01da6d2c  call     0x4e0a50 ; il2cpp_init_metadata
01da6d31  mov      byte ptr [rip + 0x28b57f0], 1 ; [465c528] bss
01da6d38  xor      edx, edx
01da6d3a  lea      rcx, [rsp + 0x40]
01da6d3f  call     0x5d2df0 ; Vector3.Magnitude
01da6d44  comiss   xmm0, xmm14
01da6d48  jbe      0x1da6d6c
01da6d4a  xorps    xmm1, xmm1
01da6d4d  divss    xmm1, xmm0
01da6d51  divss    xmm12, xmm0
01da6d56  divss    xmm13, xmm0
01da6d5b  unpcklps xmm12, xmm1
01da6d5f  movsd    qword ptr [rbp - 0x80], xmm12
01da6d65  movd     ebx, xmm13
01da6d6a  jmp      0x1da6d86
01da6d6c  mov      rax, qword ptr [rip + 0x261a965] ; [43c16d8] TypeInfo#48704
01da6d73  mov      rcx, qword ptr [rax + 0xb8]
01da6d7a  movsd    xmm2, qword ptr [rcx]
01da6d7e  mov      ebx, dword ptr [rcx + 8]
01da6d81  movsd    qword ptr [rbp - 0x80], xmm2
01da6d86  movaps   xmm1, xmm11
01da6d8a  movaps   xmm0, xmm7
01da6d8d  call     0x578890 ; atan2f(y,x)
01da6d92  movaps   xmm7, xmm0
01da6d95  movd     xmm1, ebx
01da6d99  movss    xmm0, dword ptr [rbp - 0x80]
01da6d9e  mulss    xmm7, dword ptr [rip + 0x1739e3a] ; [34e0be0] f=57.295780181884766 d=52776566835805.76 v4=(57.29578, 100.0, 180.0, 2000.0)
01da6da6  call     0x578890 ; atan2f(y,x)
01da6dab  mulss    xmm0, dword ptr [rip + 0x1739e2d] ; [34e0be0] f=57.295780181884766 d=52776566835805.76 v4=(57.29578, 100.0, 180.0, 2000.0)
01da6db3  subss    xmm7, xmm0
01da6db7  movaps   xmm0, xmm7
01da6dba  divss    xmm0, xmm9
01da6dbf  call     0x578740 ; floorf
01da6dc4  mulss    xmm0, xmm9
01da6dc9  subss    xmm7, xmm0
01da6dcd  comiss   xmm8, xmm7
01da6dd1  ja       0x1da6ddf
01da6dd3  comiss   xmm7, xmm9
01da6dd7  jbe      0x1da6de2
01da6dd9  movaps   xmm7, xmm9
01da6ddd  jmp      0x1da6de2
01da6ddf  xorps    xmm7, xmm7
01da6de2  comiss   xmm7, dword ptr [rip + 0x1739dff] ; [34e0be8] f=180.0 d=1.964504759529741e+24 v4=(180.0, 2000.0, -0.0001, -1.0)
01da6de9  jbe      0x1da6df0
01da6deb  subss    xmm7, xmm9
01da6df0  movss    xmm0, dword ptr [rbp + 0x80]
01da6df8  comiss   xmm0, xmm7
01da6dfb  ja       0x1da6e0f
01da6dfd  movss    xmm1, dword ptr [rbp + 0x88]
01da6e05  comiss   xmm7, xmm1
01da6e08  jbe      0x1da6e12
01da6e0a  movaps   xmm7, xmm1
01da6e0d  jmp      0x1da6e12
01da6e0f  movaps   xmm7, xmm0
01da6e12  mov      rax, qword ptr [rip + 0x260ad5f] ; [43b1b78] TypeInfo#37312
01da6e19  cmp      dword ptr [rax + 0xe4], r13d
01da6e20  jne      0x1da6e31
01da6e22  mov      rcx, rax
01da6e25  call     0x4e0d90 ; il2cpp_class_init
01da6e2a  mov      rax, qword ptr [rip + 0x260ad47] ; [43b1b78] TypeInfo#37312
01da6e31  mov      rax, qword ptr [rax + 0xb8]
01da6e38  divss    xmm10, dword ptr [rax + 0xf4]
01da6e41  comiss   xmm8, xmm10
01da6e45  ja       0x1da6e5b
01da6e47  movss    xmm0, dword ptr [rip + 0x1739d7d] ; [34e0bcc] f=1.0 d=50.12387841939926 v4=(1.0, 3.141593, 4.0, 10.0)
01da6e4f  comiss   xmm10, xmm0
01da6e53  jbe      0x1da6e5f
01da6e55  movaps   xmm10, xmm0
01da6e59  jmp      0x1da6e5f
01da6e5b  xorps    xmm10, xmm10
01da6e5f  xor      r8d, r8d
01da6e62  lea      rcx, [rbp - 0x80]
01da6e66  mov      rdx, r12
01da6e69  call     0x30937f0 ; Quaternion Transform::get_localRotation()
01da6e6e  addss    xmm7, dword ptr [rbp + 0x70]
01da6e73  xorps    xmm0, xmm0
01da6e76  lea      rdx, [rbp - 0x80]
01da6e7a  xor      r8d, r8d
01da6e7d  lea      rcx, [rsp + 0x70]
01da6e82  movups   xmm6, xmmword ptr [rax]
01da6e85  mulss    xmm7, dword ptr [rip + 0x1739d33] ; [34e0bc0] f=0.01745329238474369 d=2.0463635523047694e-13 v4=(0.017453, 0.05, 0.5, 1.0)
01da6e8d  movss    dword ptr [rbp - 0x78], xmm8
01da6e93  unpcklps xmm0, xmm7
01da6e96  movsd    qword ptr [rbp - 0x80], xmm0
01da6e9b  call     0x304d890 ; Quaternion Quaternion::Internal_FromEulerRad(Vector3&)
01da6ea0  movaps   xmm3, xmm10
01da6ea4  mov      qword ptr [rsp + 0x20], r13
01da6ea9  lea      r8, [rbp - 0x80]
01da6ead  lea      rdx, [rsp + 0x70]
01da6eb2  movups   xmm0, xmmword ptr [rax]
01da6eb5  lea      rcx, [rsp + 0x60]
01da6eba  movdqa   xmmword ptr [rsp + 0x70], xmm6
01da6ec0  movaps   xmmword ptr [rbp - 0x80], xmm0
01da6ec4  call     0x304ddc0 ; Quaternion Quaternion::Internal_Slerp(Quaternion&,Quaternion&,Single)
01da6ec9  xor      r8d, r8d
01da6ecc  lea      rdx, [rbp - 0x80]
01da6ed0  mov      rcx, r12
01da6ed3  movups   xmm0, xmmword ptr [rax]
01da6ed6  movaps   xmmword ptr [rbp - 0x80], xmm0
01da6eda  call     0x3094650 ; Void Transform::set_localRotation(Quaternion)
01da6edf  movaps   xmm14, xmmword ptr [rsp + 0x90]
01da6ee8  lea      r11, [rsp + 0x120]
01da6ef0  mov      rbx, qword ptr [r11 + 0x40]
01da6ef4  movaps   xmm10, xmmword ptr [r11 - 0x50]
01da6ef9  movaps   xmm13, xmmword ptr [rsp + 0xa0]
01da6f02  movaps   xmm12, xmmword ptr [rsp + 0xb0]
01da6f0b  movaps   xmm11, xmmword ptr [rsp + 0xc0]
01da6f14  movaps   xmm9, xmmword ptr [rsp + 0xe0]
01da6f1d  movaps   xmm8, xmmword ptr [rsp + 0xf0]
01da6f26  movaps   xmm7, xmmword ptr [rsp + 0x100]
01da6f2e  movaps   xmm6, xmmword ptr [rsp + 0x110]
01da6f36  mov      r14, qword ptr [rsp + 0x158]
01da6f3e  mov      r13, qword ptr [rsp + 0x150]
01da6f46  mov      rsp, r11
01da6f49  pop      r15
01da6f4b  pop      r12
01da6f4d  pop      rdi
01da6f4e  pop      rsi
01da6f4f  pop      rbp
01da6f50  ret      
01da6f51  call     0x4e0d00 ; ThrowNullRef
01da6f56  int3     
01da6f57  int3     
01da6f58  int3     
01da6f59  int3     
01da6f5a  int3     
01da6f5b  int3     
01da6f5c  int3     
01da6f5d  int3     
01da6f5e  int3     
01da6f5f  int3     

### Vector3 Enemy.Ene_Bos07::<GetTangentPoints>g__Rotate|126_0(Vector3,Single)  RVA=0x1DA67D0 len=0x80
01da67d0  mov      qword ptr [rsp + 8], rbx
01da67d5  push     rdi
01da67d6  sub      rsp, 0x40
01da67da  movaps   xmmword ptr [rsp + 0x30], xmm6
01da67df  movaps   xmm0, xmm2
01da67e2  movaps   xmmword ptr [rsp + 0x20], xmm7
01da67e7  movaps   xmm6, xmm2
01da67ea  mov      rbx, rdx
01da67ed  mov      rdi, rcx
01da67f0  call     0x576bf0 ; cosf
01da67f5  movaps   xmm7, xmm0
01da67f8  movaps   xmm0, xmm6
01da67fb  call     0x578040 ; sinf
01da6800  movaps   xmm6, xmmword ptr [rsp + 0x30]
01da6805  movaps   xmm2, xmm7
01da6808  mulss    xmm7, dword ptr [rbx + 8]
01da680d  movaps   xmm1, xmm0
01da6810  mov      rax, rdi
01da6813  mov      dword ptr [rdi + 4], 0
01da681a  mulss    xmm0, dword ptr [rbx]
01da681e  mulss    xmm2, dword ptr [rbx]
01da6822  mulss    xmm1, dword ptr [rbx + 8]
01da6827  addss    xmm7, xmm0
01da682b  mov      rbx, qword ptr [rsp + 0x50]
01da6830  subss    xmm2, xmm1
01da6834  movss    dword ptr [rdi + 8], xmm7
01da6839  movaps   xmm7, xmmword ptr [rsp + 0x20]
01da683e  movss    dword ptr [rdi], xmm2
01da6842  add      rsp, 0x40
01da6846  pop      rdi
01da6847  ret      
01da6848  int3     
01da6849  int3     
01da684a  int3     
01da684b  int3     
01da684c  int3     
01da684d  int3     
01da684e  int3     
01da684f  int3     

### Void Enemy.Ene_Bos07::<PatternMove4>g__UpdateMoveTime|129_0(Single,Single)  RVA=0x1DA6F60 len=0x100
01da6f60  push     rbx
01da6f62  sub      rsp, 0x60
01da6f66  movaps   xmmword ptr [rsp + 0x50], xmm6
01da6f6b  mov      rbx, rcx
01da6f6e  movaps   xmmword ptr [rsp + 0x40], xmm7
01da6f73  movaps   xmm6, xmm1
01da6f76  addss    xmm6, dword ptr [rcx + 0x328]
01da6f7e  movaps   xmmword ptr [rsp + 0x30], xmm8
01da6f84  movaps   xmm7, xmm2
01da6f87  xorps    xmm8, xmm8
01da6f8b  comiss   xmm8, xmm6
01da6f8f  ja       0x1da6fa3
01da6f91  movss    xmm0, dword ptr [rip + 0x1739c33] ; [34e0bcc] f=1.0 d=50.12387841939926 v4=(1.0, 3.141593, 4.0, 10.0)
01da6f99  comiss   xmm6, xmm0
01da6f9c  jbe      0x1da6fa6
01da6f9e  movaps   xmm6, xmm0
01da6fa1  jmp      0x1da6fa6
01da6fa3  xorps    xmm6, xmm6
01da6fa6  movss    dword ptr [rcx + 0x328], xmm6
01da6fae  mulss    xmm6, xmm1
01da6fb2  addss    xmm6, dword ptr [rcx + 0x324]
01da6fba  movaps   xmm0, xmm6
01da6fbd  divss    xmm0, xmm7
01da6fc1  call     0x578740 ; floorf
01da6fc6  mulss    xmm0, xmm7
01da6fca  subss    xmm6, xmm0
01da6fce  comiss   xmm8, xmm6
01da6fd2  ja       0x1da6fde
01da6fd4  comiss   xmm6, xmm7
01da6fd7  jbe      0x1da6fe1
01da6fd9  movaps   xmm6, xmm7
01da6fdc  jmp      0x1da6fe1
01da6fde  xorps    xmm6, xmm6
01da6fe1  movss    dword ptr [rbx + 0x324], xmm6
01da6fe9  cmp      byte ptr [rip + 0x28b546d], 0 ; [465c45d] bss
01da6ff0  divss    xmm6, xmm7
01da6ff4  jne      0x1da7009
01da6ff6  lea      rcx, [rip + 0x261a6db] ; [43c16d8] TypeInfo#48704
01da6ffd  call     0x4e0a50 ; il2cpp_init_metadata
01da7002  mov      byte ptr [rip + 0x28b5454], 1 ; [465c45d] bss
01da7009  mov      rax, qword ptr [rip + 0x261a6c8] ; [43c16d8] TypeInfo#48704
01da7010  lea      r8, [rsp + 0x20]
01da7015  xor      r9d, r9d
01da7018  movaps   xmm1, xmm6
01da701b  mov      rcx, rbx
01da701e  mov      rax, qword ptr [rax + 0xb8]
01da7025  movsd    xmm0, qword ptr [rax]
01da7029  mov      eax, dword ptr [rax + 8]
01da702c  movsd    qword ptr [rsp + 0x20], xmm0
01da7032  mov      dword ptr [rsp + 0x28], eax
01da7036  call     0x1da0bf0 ; Void Enemy.Ene_Bos07::BCMove(Single,Vector3)
01da703b  movaps   xmm6, xmmword ptr [rsp + 0x50]
01da7040  movaps   xmm7, xmmword ptr [rsp + 0x40]
01da7045  movaps   xmm8, xmmword ptr [rsp + 0x30]
01da704b  add      rsp, 0x60
01da704f  pop      rbx
01da7050  ret      
01da7051  int3     
01da7052  int3     
01da7053  int3     
01da7054  int3     
01da7055  int3     
01da7056  int3     
01da7057  int3     
01da7058  int3     
01da7059  int3     
01da705a  int3     
01da705b  int3     
01da705c  int3     
01da705d  int3     
01da705e  int3     
01da705f  int3     

### Boolean Enemy.Ene_Bos07::<PatternMove6>g__UpdateCircuitMove|131_0(Single)  RVA=0x1DA7490 len=0xF0
01da7490  push     rbx
01da7492  sub      rsp, 0x40
01da7496  cmp      byte ptr [rip + 0x28bc380], 0 ; [466381d] bss
01da749d  mov      rbx, rcx
01da74a0  movaps   xmmword ptr [rsp + 0x30], xmm6
01da74a5  movaps   xmm6, xmm1
01da74a8  jne      0x1da74bd
01da74aa  lea      rcx, [rip + 0x260a6c7] ; [43b1b78] TypeInfo#37312
01da74b1  call     0x4e0a50 ; il2cpp_init_metadata
01da74b6  mov      byte ptr [rip + 0x28bc360], 1 ; [466381d] bss
01da74bd  addss    xmm6, dword ptr [rbx + 0x324]
01da74c5  movss    dword ptr [rbx + 0x324], xmm6
01da74cd  mov      rax, qword ptr [rip + 0x260a6a4] ; [43b1b78] TypeInfo#37312
01da74d4  cmp      dword ptr [rax + 0xe4], 0
01da74db  jne      0x1da74ec
01da74dd  mov      rcx, rax
01da74e0  call     0x4e0d90 ; il2cpp_class_init
01da74e5  mov      rax, qword ptr [rip + 0x260a68c] ; [43b1b78] TypeInfo#37312
01da74ec  mov      rax, qword ptr [rax + 0xb8]
01da74f3  xorps    xmm0, xmm0
01da74f6  divss    xmm6, dword ptr [rax + 0x144]
01da74fe  comiss   xmm0, xmm6
01da7501  ja       0x1da7516
01da7503  comiss   xmm6, dword ptr [rip + 0x17396c2] ; [34e0bcc] f=1.0 d=50.12387841939926 v4=(1.0, 3.141593, 4.0, 10.0)
01da750a  jbe      0x1da7519
01da750c  movss    xmm6, dword ptr [rip + 0x17396b8] ; [34e0bcc] f=1.0 d=50.12387841939926 v4=(1.0, 3.141593, 4.0, 10.0)
01da7514  jmp      0x1da7519
01da7516  xorps    xmm6, xmm6
01da7519  xor      edx, edx
01da751b  movaps   xmm0, xmm6
01da751e  call     0x1de86f0 ; Single KANAI.Kernel.EasingUtility::InOutSine01(Single)
01da7523  mov      rax, qword ptr [rip + 0x260a64e] ; [43b1b78] TypeInfo#37312
01da752a  lea      r8, [rsp + 0x20]
01da752f  xor      r9d, r9d
01da7532  mov      rcx, rbx
01da7535  mov      rax, qword ptr [rax + 0xb8]
01da753c  movsd    xmm1, qword ptr [rax + 0xb8]
01da7544  mov      eax, dword ptr [rax + 0xc0]
01da754a  movsd    qword ptr [rsp + 0x20], xmm1
01da7550  movaps   xmm1, xmm0
01da7553  mov      dword ptr [rsp + 0x28], eax
01da7557  call     0x1da0bf0 ; Void Enemy.Ene_Bos07::BCMove(Single,Vector3)
01da755c  comiss   xmm6, dword ptr [rip + 0x1739669] ; [34e0bcc] f=1.0 d=50.12387841939926 v4=(1.0, 3.141593, 4.0, 10.0)
01da7563  movaps   xmm6, xmmword ptr [rsp + 0x30]
01da7568  setae    al
01da756b  add      rsp, 0x40
01da756f  pop      rbx
01da7570  ret      
01da7571  int3     
01da7572  int3     
01da7573  int3     
01da7574  int3     
01da7575  int3     
01da7576  int3     
01da7577  int3     
01da7578  int3     
01da7579  int3     
01da757a  int3     
01da757b  int3     
01da757c  int3     
01da757d  int3     
01da757e  int3     
01da757f  int3     

### Void Enemy.Ene_Bos07::<PatternMove6>g__SetHomingAngle|131_1(Boolean,Single)  RVA=0x1DA7130 len=0x360
01da7130  mov      qword ptr [rsp + 0x10], rbx
01da7135  mov      qword ptr [rsp + 0x18], rsi
01da713a  push     rbp
01da713b  lea      rbp, [rsp - 0x57]
01da7140  sub      rsp, 0x90
01da7147  cmp      byte ptr [rip + 0x28bc6d0], 0 ; [466381e] bss
01da714e  movzx    esi, dl
01da7151  movaps   xmmword ptr [rsp + 0x60], xmm8
01da7157  mov      rbx, rcx
01da715a  movaps   xmm8, xmm2
01da715e  jne      0x1da718b
01da7160  lea      rcx, [rip + 0x2631dc9] ; [43d8f30] TypeInfo#40031
01da7167  call     0x4e0a50 ; il2cpp_init_metadata
01da716c  lea      rcx, [rip + 0x2610e8d] ; [43b8000] MethodRef#202981
01da7173  call     0x4e0a50 ; il2cpp_init_metadata
01da7178  lea      rcx, [rip + 0x25d6d21] ; [437dea0] TypeInfo#42619
01da717f  call     0x4e0a50 ; il2cpp_init_metadata
01da7184  mov      byte ptr [rip + 0x28bc693], 1 ; [466381e] bss
01da718b  mov      rcx, qword ptr [rbx + 0x2b0]
01da7192  xorps    xmm0, xmm0
01da7195  mov      qword ptr [rsp + 0xa0], rdi
01da719d  movaps   xmmword ptr [rsp + 0x80], xmm6
01da71a5  movaps   xmmword ptr [rsp + 0x70], xmm7
01da71aa  movups   xmmword ptr [rbp + 0x17], xmm0
01da71ae  test     rcx, rcx
01da71b1  je       0x1da747b
01da71b7  xor      edx, edx
01da71b9  call     0x308de10 ; Transform Transform::get_parent() || Transform Transform::get_parentInternal() || Transform Transform::GetParent()
01da71be  mov      rcx, qword ptr [rip + 0x25d6cdb] ; [437dea0] TypeInfo#42619
01da71c5  mov      rdi, rax
01da71c8  cmp      dword ptr [rcx + 0xe4], 0
01da71cf  jne      0x1da71d6
01da71d1  call     0x4e0d90 ; il2cpp_class_init
01da71d6  xor      r8d, r8d
01da71d9  xor      edx, edx
01da71db  mov      rcx, rdi
01da71de  call     0x306d270 ; Boolean Object::op_Equality(Object,Object)
01da71e3  mov      rdi, qword ptr [rbx + 0x2b0]
01da71ea  test     al, al
01da71ec  jne      0x1da7204
01da71ee  test     rdi, rdi
01da71f1  je       0x1da747b
01da71f7  xor      edx, edx
01da71f9  mov      rcx, rdi
01da71fc  call     0x308de10 ; Transform Transform::get_parent() || Transform Transform::get_parentInternal() || Transform Transform::GetParent()
01da7201  mov      rdi, rax
01da7204  test     sil, sil
01da7207  jne      0x1da7211
01da7209  xorps    xmm0, xmm0
01da720c  jmp      0x1da73a8
01da7211  mov      rax, qword ptr [rip + 0x2610de8] ; [43b8000] MethodRef#202981
01da7218  mov      rax, qword ptr [rax + 0x20]
01da721c  test     byte ptr [rax + 0x135], 1
01da7223  jne      0x1da722d
01da7225  mov      rcx, rax
01da7228  call     0x4de1e0 ; ?
01da722d  mov      rax, qword ptr [rax + 0xc0]
01da7234  mov      rax, qword ptr [rax + 0x10]
01da7238  test     byte ptr [rax + 0x135], 1
01da723f  jne      0x1da7249
01da7241  mov      rcx, rax
01da7244  call     0x4de1e0 ; ?
01da7249  mov      rcx, qword ptr [rip + 0x25d6c50] ; [437dea0] TypeInfo#42619
01da7250  mov      rax, qword ptr [rax + 0xb8]
01da7257  cmp      dword ptr [rcx + 0xe4], 0
01da725e  mov      rsi, qword ptr [rax]
01da7261  jne      0x1da7268
01da7263  call     0x4e0d90 ; il2cpp_class_init
01da7268  xor      r8d, r8d
01da726b  xor      edx, edx
01da726d  mov      rcx, rsi
01da7270  call     0x306d270 ; Boolean Object::op_Equality(Object,Object)
01da7275  test     al, al
01da7277  jne      0x1da744c
01da727d  mov      rdx, qword ptr [rbx + 0x2c0]
01da7284  test     rdx, rdx
01da7287  je       0x1da747b
01da728d  xor      r8d, r8d
01da7290  lea      rcx, [rbp + 7]
01da7294  call     0x3093ba0 ; Vector3 Transform::get_position()
01da7299  mov      rdx, qword ptr [rbx + 0x2c0]
01da72a0  movss    xmm7, dword ptr [rax]
01da72a4  test     rdx, rdx
01da72a7  je       0x1da747b
01da72ad  xor      r8d, r8d
01da72b0  lea      rcx, [rbp + 7]
01da72b4  call     0x3093ba0 ; Vector3 Transform::get_position()
01da72b9  mov      rdx, qword ptr [rbx + 0x2c0]
01da72c0  movss    xmm6, dword ptr [rax + 4]
01da72c5  test     rdx, rdx
01da72c8  je       0x1da747b
01da72ce  xor      r8d, r8d
01da72d1  lea      rcx, [rbp + 7]
01da72d5  call     0x3093ba0 ; Vector3 Transform::get_position()
01da72da  movss    xmm1, dword ptr [rax + 8]
01da72df  test     rsi, rsi
01da72e2  je       0x1da747b
01da72e8  unpcklps xmm7, xmm6
01da72eb  lea      r8, [rbp - 9]
01da72ef  xor      r9d, r9d
01da72f2  movsd    qword ptr [rbp - 9], xmm7
01da72f7  mov      rdx, rsi
01da72fa  movss    dword ptr [rbp - 1], xmm1
01da72ff  lea      rcx, [rbp + 7]
01da7303  mov      qword ptr [rsp + 0x20], 0
01da730c  call     0x1ce6750 ; Vector3 InGameManager::GetSkyRootPosition(Vector3,Boolean)
01da7311  test     rdi, rdi
01da7314  je       0x1da747b
01da731a  movsd    xmm0, qword ptr [rax]
01da731e  lea      r8, [rbp - 9]
01da7322  mov      eax, dword ptr [rax + 8]
01da7325  lea      rcx, [rbp + 7]
01da7329  xor      r9d, r9d
01da732c  movsd    qword ptr [rbp - 9], xmm0
01da7331  mov      rdx, rdi
01da7334  mov      dword ptr [rbp - 1], eax
01da7337  call     0x308ea00 ; Vector3 Transform::InverseTransformPoint(Vector3)
01da733c  movsd    xmm0, qword ptr [rbx + 0x1f0]
01da7344  lea      r8, [rbp - 9]
01da7348  xor      r9d, r9d
01da734b  movsd    qword ptr [rbp - 9], xmm0
01da7350  mov      rdx, rdi
01da7353  lea      rcx, [rbp + 7]
01da7357  movsd    xmm6, qword ptr [rax]
01da735b  mov      esi, dword ptr [rax + 8]
01da735e  mov      eax, dword ptr [rbx + 0x1f8]
01da7364  mov      dword ptr [rbp - 1], eax
01da7367  call     0x308ea00 ; Vector3 Transform::InverseTransformPoint(Vector3)
01da736c  mov      rcx, qword ptr [rip + 0x2631bbd] ; [43d8f30] TypeInfo#40031
01da7373  movsd    xmm7, qword ptr [rax]
01da7377  cmp      dword ptr [rcx + 0xe4], 0
01da737e  mov      edi, dword ptr [rax + 8]
01da7381  jne      0x1da7388
01da7383  call     0x4e0d90 ; il2cpp_class_init
01da7388  xor      r8d, r8d
01da738b  movsd    qword ptr [rbp - 9], xmm6
01da7390  lea      rdx, [rbp - 9]
01da7394  mov      dword ptr [rbp - 1], esi
01da7397  lea      rcx, [rbp + 7]
01da739b  movsd    qword ptr [rbp + 7], xmm7
01da73a0  mov      dword ptr [rbp + 0xf], edi
01da73a3  call     0x1ccb620 ; Single InGameBulletManager::GetTargetBulletArc(Vector3,Vector3)
01da73a8  movss    dword ptr [rbx + 0x334], xmm0
01da73b0  mov      rdx, qword ptr [rbx + 0x2b0]
01da73b7  test     rdx, rdx
01da73ba  je       0x1da747b
01da73c0  xor      r8d, r8d
01da73c3  lea      rcx, [rbp + 7]
01da73c7  call     0x30937f0 ; Quaternion Transform::get_localRotation()
01da73cc  xor      r8d, r8d
01da73cf  lea      rdx, [rbp + 0x17]
01da73d3  lea      rcx, [rbp + 7]
01da73d7  movups   xmm0, xmmword ptr [rax]
01da73da  movups   xmmword ptr [rbp + 0x17], xmm0
01da73de  call     0x304dee0 ; Vector3 Quaternion::Internal_ToEulerRad(Quaternion&)
01da73e3  movss    xmm2, dword ptr [rip + 0x17397f5] ; [34e0be0] f=57.295780181884766 d=52776566835805.76 v4=(57.29578, 100.0, 180.0, 2000.0)
01da73eb  lea      rdx, [rbp + 7]
01da73ef  xor      r8d, r8d
01da73f2  lea      rcx, [rbp - 9]
01da73f6  movsd    xmm0, qword ptr [rax]
01da73fa  movss    xmm1, dword ptr [rax + 8]
01da73ff  movaps   xmm4, xmm0
01da7402  movaps   xmm3, xmm0
01da7405  mulss    xmm4, xmm2
01da7409  shufps   xmm3, xmm3, 0x55
01da740d  mulss    xmm3, xmm2
01da7411  mulss    xmm1, xmm2
01da7415  unpcklps xmm4, xmm3
01da7418  movsd    qword ptr [rbp + 7], xmm4
01da741d  movss    dword ptr [rbp + 0xf], xmm1
01da7422  movsd    qword ptr [rbp - 9], xmm0
01da7427  call     0x304dbe0 ; Vector3 Quaternion::Internal_MakePositive(Vector3)
01da742c  movss    xmm0, dword ptr [rax + 4]
01da7431  movss    dword ptr [rbx + 0x330], xmm0
01da7439  movss    dword ptr [rbx + 0x33c], xmm8
01da7442  mov      dword ptr [rbx + 0x338], 0
01da744c  movaps   xmm7, xmmword ptr [rsp + 0x70]
01da7451  lea      r11, [rsp + 0x90]
01da7459  mov      rbx, qword ptr [r11 + 0x18]
01da745d  mov      rsi, qword ptr [r11 + 0x20]
01da7461  movaps   xmm8, xmmword ptr [r11 - 0x30]
01da7466  movaps   xmm6, xmmword ptr [rsp + 0x80]
01da746e  mov      rdi, qword ptr [rsp + 0xa0]
01da7476  mov      rsp, r11
01da7479  pop      rbp
01da747a  ret      
01da747b  call     0x4e0d00 ; ThrowNullRef
01da7480  int3     
01da7481  int3     
01da7482  int3     
01da7483  int3     
01da7484  int3     
01da7485  int3     
01da7486  int3     
01da7487  int3     
01da7488  int3     
01da7489  int3     
01da748a  int3     
01da748b  int3     
01da748c  int3     
01da748d  int3     
01da748e  int3     
01da748f  int3     

### Void Enemy.Ene_Bos07::<PatternMove6>g__HomingBody|131_2(Single)  RVA=0x1DA7060 len=0xD0
01da7060  mov      qword ptr [rsp + 8], rbx
01da7065  push     rdi
01da7066  sub      rsp, 0x40
01da706a  addss    xmm1, dword ptr [rcx + 0x338]
01da7072  xorps    xmm0, xmm0
01da7075  mov      rbx, rcx
01da7078  comiss   xmm0, xmm1
01da707b  ja       0x1da708f
01da707d  movss    xmm0, dword ptr [rcx + 0x33c]
01da7085  comiss   xmm1, xmm0
01da7088  jbe      0x1da7092
01da708a  movaps   xmm1, xmm0
01da708d  jmp      0x1da7092
01da708f  xorps    xmm1, xmm1
01da7092  movss    dword ptr [rcx + 0x338], xmm1
01da709a  xor      edx, edx
01da709c  divss    xmm1, dword ptr [rcx + 0x33c]
01da70a4  movaps   xmm0, xmm1
01da70a7  call     0x1de8650 ; Single KANAI.Kernel.EasingUtility::InOutQuad01(Single)
01da70ac  movss    xmm1, dword ptr [rbx + 0x334]
01da70b4  movaps   xmm2, xmm0
01da70b7  movss    xmm0, dword ptr [rbx + 0x330]
01da70bf  xor      r9d, r9d
01da70c2  mov      rdi, qword ptr [rbx + 0x2b0]
01da70c9  mov      dword ptr [rsp + 0x20], 0
01da70d1  call     0x1cfa430 ; Single Mathf::LerpAngle(Single,Single,Single)
01da70d6  mulss    xmm0, dword ptr [rip + 0x1739ae2] ; [34e0bc0] f=0.01745329238474369 d=2.0463635523047694e-13 v4=(0.017453, 0.05, 0.5, 1.0)
01da70de  lea      rdx, [rsp + 0x20]
01da70e3  xor      r8d, r8d
01da70e6  mov      dword ptr [rsp + 0x28], 0
01da70ee  lea      rcx, [rsp + 0x30]
01da70f3  movss    dword ptr [rsp + 0x24], xmm0
01da70f9  call     0x304d890 ; Quaternion Quaternion::Internal_FromEulerRad(Vector3&)
01da70fe  test     rdi, rdi
01da7101  je       0x1da7126
01da7103  movups   xmm0, xmmword ptr [rax]
01da7106  xor      r8d, r8d
01da7109  lea      rdx, [rsp + 0x20]
01da710e  mov      rcx, rdi
01da7111  movaps   xmmword ptr [rsp + 0x20], xmm0
01da7116  call     0x3094650 ; Void Transform::set_localRotation(Quaternion)
01da711b  mov      rbx, qword ptr [rsp + 0x50]
01da7120  add      rsp, 0x40
01da7124  pop      rdi
01da7125  ret      
01da7126  call     0x4e0d00 ; ThrowNullRef
01da712b  int3     
01da712c  int3     
01da712d  int3     
01da712e  int3     
01da712f  int3     

