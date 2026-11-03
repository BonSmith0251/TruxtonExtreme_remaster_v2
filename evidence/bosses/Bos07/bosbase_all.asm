### Enemy.PawnEnemy/EnemyChildData[] Enemy.Ene_BosBase::SubEnemys()  RVA=0x1DBA8A0 len=0x320
01dba8a0  push     rbx
01dba8a2  push     rdi
01dba8a3  sub      rsp, 0xa8
01dba8aa  cmp      byte ptr [rip + 0x28a8fc5], 0 ; [4663876] bss
01dba8b1  mov      rdi, rcx
01dba8b4  jne      0x1dba911
01dba8b6  lea      rcx, [rip + 0x25d712b] ; [43919e8] MethodRef#205594
01dba8bd  call     0x4e0a50 ; il2cpp_init_metadata
01dba8c2  lea      rcx, [rip + 0x25e8d57] ; [43a3620] MethodRef#91905
01dba8c9  call     0x4e0a50 ; il2cpp_init_metadata
01dba8ce  lea      rcx, [rip + 0x25e8c93] ; [43a3568] MethodRef#91903
01dba8d5  call     0x4e0a50 ; il2cpp_init_metadata
01dba8da  lea      rcx, [rip + 0x25e8def] ; [43a36d0] MethodRef#91955
01dba8e1  call     0x4e0a50 ; il2cpp_init_metadata
01dba8e6  lea      rcx, [rip + 0x25e8bcb] ; [43a34b8] MethodRef#91900
01dba8ed  call     0x4e0a50 ; il2cpp_init_metadata
01dba8f2  lea      rcx, [rip + 0x2601957] ; [43bc250] TypeInfo#67450
01dba8f9  call     0x4e0a50 ; il2cpp_init_metadata
01dba8fe  lea      rcx, [rip + 0x25fd6fb] ; [43b8000] MethodRef#202981
01dba905  call     0x4e0a50 ; il2cpp_init_metadata
01dba90a  mov      byte ptr [rip + 0x28a8f65], 1 ; [4663876] bss
01dba911  xor      edx, edx
01dba913  mov      rcx, rdi
01dba916  call     0x79b610 ; Int32 InGameDestuctible::GetDamageScore() || Int32 InGameDestuctible::GetDeathScore() || TXEKernel.TXEKernelHybridCollisions/toleType InGameDestuctible::GetTolerance(TXEKernel.TXEKernelHybridCollisions/attackType)
01dba91b  mov      rdx, qword ptr [rdi]
01dba91e  mov      rcx, rdi
01dba921  mov      rbx, rax
01dba924  mov      r8, qword ptr [rdx + 0x6b8]
01dba92b  mov      rdx, qword ptr [rdx + 0x6c0]
01dba932  call     r8
01dba935  mov      qword ptr [rsp + 0x30], rax
01dba93a  mov      rdi, rax
01dba93d  test     rax, rax
01dba940  je       0x1dbab98
01dba946  mov      rdx, qword ptr [rip + 0x25d709b] ; [43919e8] MethodRef#205594
01dba94d  mov      rcx, rax
01dba950  call     0x7d5180 ; Boolean Linq.Enumerable::Any(Collections.Generic.IEnumerable`1<TSource>)
01dba955  test     al, al
01dba957  je       0x1dbab98
01dba95d  mov      qword ptr [rsp + 0x80], r15
01dba965  mov      qword ptr [rsp + 0xc8], rbp
01dba96d  mov      qword ptr [rsp + 0xa0], rsi
01dba975  mov      qword ptr [rsp + 0x98], r12
01dba97d  mov      qword ptr [rsp + 0x90], r13
01dba985  mov      qword ptr [rsp + 0x88], r14
01dba98d  mov      rcx, qword ptr [rip + 0x26018bc] ; [43bc250] TypeInfo#67450
01dba994  call     0x4e0cb0 ; ?
01dba999  mov      rdx, qword ptr [rip + 0x25e8b18] ; [43a34b8] MethodRef#91900
01dba9a0  mov      rcx, rax
01dba9a3  mov      r15, rax
01dba9a6  call     0xb16050 ; Void Collections.Generic.List`1::.ctor() || Void Collections.Generic.LowLevelList`1::.ctor()
01dba9ab  test     rbx, rbx
01dba9ae  je       0x1dba9cb
01dba9b0  test     r15, r15
01dba9b3  je       0x1dbabb1
01dba9b9  mov      r8, qword ptr [rip + 0x25e8c60] ; [43a3620] MethodRef#91905
01dba9c0  mov      rdx, rbx
01dba9c3  mov      rcx, r15
01dba9c6  call     0xc8d890 ; ?
01dba9cb  mov      rcx, qword ptr [rip + 0x25fd62e] ; [43b8000] MethodRef#202981
01dba9d2  call     0x27540 ; ?
01dba9d7  test     rax, rax
01dba9da  je       0x1dbabb1
01dba9e0  mov      rcx, qword ptr [rax + 0x138]
01dba9e7  xor      r13d, r13d
01dba9ea  movsxd   rax, dword ptr [rdi + 0x18]
01dba9ee  mov      qword ptr [rsp + 0x38], rcx
01dba9f3  test     eax, eax
01dba9f5  jle      0x1dbab4b
01dba9fb  mov      qword ptr [rsp + 0xd8], rax
01dbaa03  lea      rax, [rdi + 0x20]
01dbaa07  mov      qword ptr [rsp + 0xd0], rax
01dbaa0f  mov      qword ptr [rsp + 0xc0], r13
01dbaa17  nop      word ptr [rax + rax]
01dbaa20  cmp      r13d, dword ptr [rdi + 0x18]
01dbaa24  jae      0x1dbabab
01dbaa2a  test     rcx, rcx
01dbaa2d  je       0x1dbabb1
01dbaa33  mov      rdx, qword ptr [rax]
01dbaa36  xor      r8d, r8d
01dbaa39  call     0x1cd2f00 ; Timeline.EnemyData InGameEnemyClipsManager::GetData(String)
01dbaa3e  mov      rbp, rax
01dbaa41  test     rax, rax
01dbaa44  je       0x1dbabb1
01dbaa4a  xor      edx, edx
01dbaa4c  mov      rcx, rax
01dbaa4f  call     0x1d33100 ; Int32 Timeline.EnemyData::get_RepeatDataSum()
01dbaa54  mov      rsi, qword ptr [rbp + 0x50]
01dbaa58  mov      r12d, eax
01dbaa5b  nop      dword ptr [rax + rax]
01dbaa60  xor      edi, edi
01dbaa62  lea      r14, [rsi + 0x20]
01dbaa66  test     rsi, rsi
01dbaa69  je       0x1dbabb1
01dbaa6f  nop      
01dbaa70  cmp      edi, dword ptr [rsi + 0x18]
01dbaa73  jge      0x1dbab08
01dbaa79  jae      0x1dbabab
01dbaa7f  mov      rbx, qword ptr [r14]
01dbaa82  test     rbx, rbx
01dbaa85  je       0x1dbabb1
01dbaa8b  mov      rcx, qword ptr [rbx + 0x10]
01dbaa8f  xor      edx, edx
01dbaa91  call     0x1e83800 ; Boolean String::IsNullOrEmpty(String)
01dbaa96  test     al, al
01dbaa98  je       0x1dbaaa0
01dbaa9a  mov      rdx, qword ptr [rbp + 0x20]
01dbaa9e  jmp      0x1dbaaa4
01dbaaa0  mov      rdx, qword ptr [rbx + 0x10]
01dbaaa4  xor      eax, eax
01dbaaa6  lea      r9d, [r12 + 1]
01dbaaab  xorps    xmm0, xmm0
01dbaaae  mov      qword ptr [rsp + 0x50], rax
01dbaab3  xor      r8d, r8d
01dbaab6  mov      qword ptr [rsp + 0x20], rax
01dbaabb  lea      rcx, [rsp + 0x40]
01dbaac0  movups   xmmword ptr [rsp + 0x40], xmm0
01dbaac5  call     0x1311700 ; Void Enemy.PawnEnemy/EnemyChildData::.ctor(String,Transform,Int32)
01dbaaca  test     r15, r15
01dbaacd  je       0x1dbaba5
01dbaad3  movups   xmm0, xmmword ptr [rsp + 0x40]
01dbaad8  lea      rdx, [rsp + 0x60]
01dbaadd  mov      r8, qword ptr [rip + 0x25e8a84] ; [43a3568] MethodRef#91903
01dbaae4  movsd    xmm1, qword ptr [rsp + 0x50]
01dbaaea  mov      rcx, r15
01dbaaed  movaps   xmmword ptr [rsp + 0x60], xmm0
01dbaaf2  movsd    qword ptr [rsp + 0x70], xmm1
01dbaaf8  call     0x19f90 ; ?
01dbaafd  inc      edi
01dbaaff  add      r14, 8
01dbab03  jmp      0x1dbaa70
01dbab08  mov      rbx, qword ptr [rsp + 0xc0]
01dbab10  inc      r13d
01dbab13  mov      rax, qword ptr [rsp + 0xd0]
01dbab1b  inc      rbx
01dbab1e  add      rax, 8
01dbab22  mov      qword ptr [rsp + 0xc0], rbx
01dbab2a  mov      qword ptr [rsp + 0xd0], rax
01dbab32  cmp      rbx, qword ptr [rsp + 0xd8]
01dbab3a  jge      0x1dbab4b
01dbab3c  mov      rdi, qword ptr [rsp + 0x30]
01dbab41  mov      rcx, qword ptr [rsp + 0x38]
01dbab46  jmp      0x1dbaa20
01dbab4b  test     r15, r15
01dbab4e  je       0x1dbabb1
01dbab50  mov      rdx, qword ptr [rip + 0x25e8b79] ; [43a36d0] MethodRef#91955
01dbab57  mov      rcx, r15
01dbab5a  mov      r14, qword ptr [rsp + 0x88]
01dbab62  mov      r13, qword ptr [rsp + 0x90]
01dbab6a  mov      r12, qword ptr [rsp + 0x98]
01dbab72  mov      rsi, qword ptr [rsp + 0xa0]
01dbab7a  mov      rbp, qword ptr [rsp + 0xc8]
01dbab82  mov      r15, qword ptr [rsp + 0x80]
01dbab8a  add      rsp, 0xa8
01dbab91  pop      rdi
01dbab92  pop      rbx
01dbab93  jmp      0xb15e40 ; T[] Collections.Generic.List`1::ToArray()
01dbab98  mov      rax, rbx
01dbab9b  add      rsp, 0xa8
01dbaba2  pop      rdi
01dbaba3  pop      rbx
01dbaba4  ret      
01dbaba5  call     0x4e0d00 ; ThrowNullRef
01dbabaa  int3     
01dbabab  call     0x4e0cf0 ; ?
01dbabb0  int3     
01dbabb1  call     0x4e0d00 ; ThrowNullRef
01dbabb6  int3     
01dbabb7  int3     
01dbabb8  int3     
01dbabb9  int3     
01dbabba  int3     
01dbabbb  int3     
01dbabbc  int3     
01dbabbd  int3     
01dbabbe  int3     
01dbabbf  int3     

### Void Enemy.Ene_BosBase::InitializeToPlay()  RVA=0x1DB9A90 len=0x3D0
01db9a90  push     rsi
01db9a92  push     r12
01db9a94  push     r13
01db9a96  push     r14
01db9a98  push     r15
01db9a9a  sub      rsp, 0x20
01db9a9e  cmp      byte ptr [rip + 0x28a9dd2], 0 ; [4663877] bss
01db9aa5  mov      r14, rcx
01db9aa8  jne      0x1db9af9
01db9aaa  lea      rcx, [rip + 0x25ae24f] ; [4367d00] TypeInfo#72245
01db9ab1  call     0x4e0a50 ; il2cpp_init_metadata
01db9ab6  lea      rcx, [rip + 0x25b0c9b] ; [436a758] TypeInfo#72265
01db9abd  call     0x4e0a50 ; il2cpp_init_metadata
01db9ac2  lea      rcx, [rip + 0x25d7f1f] ; [43919e8] MethodRef#205594
01db9ac9  call     0x4e0a50 ; il2cpp_init_metadata
01db9ace  lea      rcx, [rip + 0x25fe7fb] ; [43b82d0] MethodRef#202985
01db9ad5  call     0x4e0a50 ; il2cpp_init_metadata
01db9ada  lea      rcx, [rip + 0x25fe89f] ; [43b8380] MethodRef#202986
01db9ae1  call     0x4e0a50 ; il2cpp_init_metadata
01db9ae6  lea      rcx, [rip + 0x25fe513] ; [43b8000] MethodRef#202981
01db9aed  call     0x4e0a50 ; il2cpp_init_metadata
01db9af2  mov      byte ptr [rip + 0x28a9d7e], 1 ; [4663877] bss
01db9af9  mov      rax, qword ptr [rip + 0x25fe500] ; [43b8000] MethodRef#202981
01db9b00  mov      rax, qword ptr [rax + 0x20]
01db9b04  test     byte ptr [rax + 0x135], 1
01db9b0b  jne      0x1db9b15
01db9b0d  mov      rcx, rax
01db9b10  call     0x4de1e0 ; ?
01db9b15  mov      rax, qword ptr [rax + 0xc0]
01db9b1c  mov      rax, qword ptr [rax + 0x10]
01db9b20  test     byte ptr [rax + 0x135], 1
01db9b27  jne      0x1db9b31
01db9b29  mov      rcx, rax
01db9b2c  call     0x4de1e0 ; ?
01db9b31  mov      rax, qword ptr [rax + 0xb8]
01db9b38  mov      rcx, r14
01db9b3b  mov      rdx, qword ptr [r14]
01db9b3e  mov      qword ptr [rsp + 0x50], rbx
01db9b43  mov      qword ptr [rsp + 0x58], rbp
01db9b48  mov      r13, qword ptr [rax]
01db9b4b  mov      rax, qword ptr [rdx + 0x6a8]
01db9b52  mov      rdx, qword ptr [rdx + 0x6b0]
01db9b59  mov      qword ptr [rsp + 0x60], rdi
01db9b5e  call     rax
01db9b60  xor      esi, esi
01db9b62  mov      r12, rax
01db9b65  mov      r15d, 0x20
01db9b6b  test     rax, rax
01db9b6e  je       0x1db9c97
01db9b74  mov      rdx, qword ptr [rip + 0x25d7e6d] ; [43919e8] MethodRef#205594
01db9b7b  mov      rcx, rax
01db9b7e  call     0x7d5180 ; Boolean Linq.Enumerable::Any(Collections.Generic.IEnumerable`1<TSource>)
01db9b83  test     al, al
01db9b85  je       0x1db9c97
01db9b8b  mov      edx, dword ptr [r12 + 0x18]
01db9b90  mov      ebx, esi
01db9b92  mov      rcx, qword ptr [rip + 0x25ae167] ; [4367d00] TypeInfo#72245
01db9b99  call     0x4dfe00 ; ?
01db9b9e  lea      rcx, [r14 + 0x208]
01db9ba5  mov      qword ptr [r14 + 0x208], rax
01db9bac  mov      rdx, rax
01db9baf  call     0x4dfd80 ; ?
01db9bb4  mov      eax, esi
01db9bb6  nop      word ptr [rax + rax]
01db9bc0  cmp      eax, dword ptr [r12 + 0x18]
01db9bc5  jge      0x1db9c91
01db9bcb  cmp      ebx, dword ptr [r12 + 0x18]
01db9bd0  jae      0x1db9e57
01db9bd6  mov      rdi, qword ptr [r14 + 0x208]
01db9bdd  test     r13, r13
01db9be0  je       0x1db9e31
01db9be6  mov      rcx, qword ptr [r13 + 0xf0]
01db9bed  test     rcx, rcx
01db9bf0  je       0x1db9e31
01db9bf6  mov      rdx, qword ptr [r12 + r15]
01db9bfa  xor      r8d, r8d
01db9bfd  call     0x1ccb7b0 ; Enemy.BulletTemplate InGameBulletManager::GetTemplate(String)
01db9c02  mov      rbp, rax
01db9c05  test     rdi, rdi
01db9c08  je       0x1db9e31
01db9c0e  test     rax, rax
01db9c11  je       0x1db9c2b
01db9c13  mov      rdx, qword ptr [rdi]
01db9c16  mov      rcx, rax
01db9c19  mov      rdx, qword ptr [rdx + 0x40]
01db9c1d  call     0x4dfda0 ; ?
01db9c22  test     rax, rax
01db9c25  je       0x1db9e37
01db9c2b  cmp      ebx, dword ptr [rdi + 0x18]
01db9c2e  jae      0x1db9e57
01db9c34  movsxd   rax, ebx
01db9c37  mov      rdx, rbp
01db9c3a  add      rax, 4
01db9c3e  mov      qword ptr [r15 + rdi], rbp
01db9c42  lea      rcx, [rdi + rax*8]
01db9c46  call     0x4dfd80 ; ?
01db9c4b  mov      rax, qword ptr [r14 + 0x208]
01db9c52  test     rax, rax
01db9c55  je       0x1db9e31
01db9c5b  cmp      ebx, dword ptr [rax + 0x18]
01db9c5e  jae      0x1db9e57
01db9c64  mov      rcx, qword ptr [r15 + rax]
01db9c68  test     rcx, rcx
01db9c6b  je       0x1db9e31
01db9c71  xor      r9d, r9d
01db9c74  mov      edx, 4
01db9c79  mov      r8d, 0x6a
01db9c7f  call     0x1d614a0 ; Void Enemy.BulletTemplate::ChangeSE(BulletKind,TXEKernel.Sound.SoundUtility/ID)
01db9c84  inc      ebx
01db9c86  add      r15, 8
01db9c8a  mov      eax, ebx
01db9c8c  jmp      0x1db9bc0
01db9c91  mov      r15d, 0x20
01db9c97  mov      rdx, qword ptr [r14]
01db9c9a  mov      rcx, r14
01db9c9d  mov      rax, qword ptr [rdx + 0x6b8]
01db9ca4  mov      rdx, qword ptr [rdx + 0x6c0]
01db9cab  call     rax
01db9cad  mov      rbp, rax
01db9cb0  test     rax, rax
01db9cb3  je       0x1db9d92
01db9cb9  mov      rdx, qword ptr [rip + 0x25d7d28] ; [43919e8] MethodRef#205594
01db9cc0  mov      rcx, rax
01db9cc3  call     0x7d5180 ; Boolean Linq.Enumerable::Any(Collections.Generic.IEnumerable`1<TSource>)
01db9cc8  test     al, al
01db9cca  je       0x1db9d92
01db9cd0  mov      edx, dword ptr [rbp + 0x18]
01db9cd3  mov      dword ptr [r14 + 0x1fc], edx
01db9cda  mov      rcx, qword ptr [rip + 0x25b0a77] ; [436a758] TypeInfo#72265
01db9ce1  call     0x4dfe00 ; ?
01db9ce6  lea      rcx, [r14 + 0x200]
01db9ced  mov      qword ptr [r14 + 0x200], rax
01db9cf4  mov      rdx, rax
01db9cf7  call     0x4dfd80 ; ?
01db9cfc  mov      eax, esi
01db9cfe  nop      
01db9d00  cmp      eax, dword ptr [rbp + 0x18]
01db9d03  jge      0x1db9d92
01db9d09  cmp      esi, dword ptr [rbp + 0x18]
01db9d0c  jae      0x1db9e57
01db9d12  mov      rbx, qword ptr [r14 + 0x200]
01db9d19  test     r13, r13
01db9d1c  je       0x1db9e31
01db9d22  mov      rcx, qword ptr [r13 + 0x138]
01db9d29  test     rcx, rcx
01db9d2c  je       0x1db9e31
01db9d32  mov      rdx, qword ptr [r15 + rbp]
01db9d36  xor      r8d, r8d
01db9d39  call     0x1cd2f00 ; Timeline.EnemyData InGameEnemyClipsManager::GetData(String)
01db9d3e  mov      rdi, rax
01db9d41  test     rbx, rbx
01db9d44  je       0x1db9e31
01db9d4a  test     rax, rax
01db9d4d  je       0x1db9d67
01db9d4f  mov      rdx, qword ptr [rbx]
01db9d52  mov      rcx, rax
01db9d55  mov      rdx, qword ptr [rdx + 0x40]
01db9d59  call     0x4dfda0 ; ?
01db9d5e  test     rax, rax
01db9d61  je       0x1db9e47
01db9d67  cmp      esi, dword ptr [rbx + 0x18]
01db9d6a  jae      0x1db9e57
01db9d70  movsxd   rax, esi
01db9d73  mov      rdx, rdi
01db9d76  add      rax, 4
01db9d7a  mov      qword ptr [rbx + r15], rdi
01db9d7e  lea      rcx, [rbx + rax*8]
01db9d82  call     0x4dfd80 ; ?
01db9d87  inc      esi
01db9d89  add      r15, 8
01db9d8d  jmp      0x1db9cfc
01db9d92  mov      rcx, qword ptr [rip + 0x25fe537] ; [43b82d0] MethodRef#202985
01db9d99  call     0xd102f0 ; Boolean KANAI.Kernel.MonoBehaviourSingleton`1::IsInstanceNull() || Boolean KANAI.Kernel.SimpleSingleton`1::IsInstanceNull()
01db9d9e  test     al, al
01db9da0  jne      0x1db9e0b
01db9da2  mov      rax, qword ptr [rip + 0x25fe5d7] ; [43b8380] MethodRef#202986
01db9da9  mov      rax, qword ptr [rax + 0x20]
01db9dad  test     byte ptr [rax + 0x135], 1
01db9db4  jne      0x1db9dbe
01db9db6  mov      rcx, rax
01db9db9  call     0x4de1e0 ; ?
01db9dbe  mov      rax, qword ptr [rax + 0xc0]
01db9dc5  mov      rax, qword ptr [rax + 0x10]
01db9dc9  test     byte ptr [rax + 0x135], 1
01db9dd0  jne      0x1db9dda
01db9dd2  mov      rcx, rax
01db9dd5  call     0x4de1e0 ; ?
01db9dda  mov      rax, qword ptr [rax + 0xb8]
01db9de1  mov      rcx, qword ptr [rax]
01db9de4  test     rcx, rcx
01db9de7  je       0x1db9e31
01db9de9  mov      eax, dword ptr [rcx + 0x28]
01db9dec  mov      dword ptr [r14 + 0x210], eax
01db9df3  mov      eax, dword ptr [rcx + 0x2c]
01db9df6  mov      dword ptr [r14 + 0x214], eax
01db9dfd  movzx    eax, byte ptr [rcx + 0xc8]
01db9e04  mov      byte ptr [r14 + 0x218], al
01db9e0b  xor      edx, edx
01db9e0d  mov      rcx, r14
01db9e10  mov      rdi, qword ptr [rsp + 0x60]
01db9e15  mov      rbp, qword ptr [rsp + 0x58]
01db9e1a  mov      rbx, qword ptr [rsp + 0x50]
01db9e1f  add      rsp, 0x20
01db9e23  pop      r15
01db9e25  pop      r14
01db9e27  pop      r13
01db9e29  pop      r12
01db9e2b  pop      rsi
01db9e2c  jmp      0x1d0de30 ; Void Enemy.PawnEnemy::InitializeToPlay()
01db9e31  call     0x4e0d00 ; ThrowNullRef
01db9e36  int3     
01db9e37  call     0x4e0670 ; ?
01db9e3c  mov      rcx, rax
01db9e3f  xor      edx, edx
01db9e41  call     0x4e0cc0 ; ?
01db9e46  int3     
01db9e47  call     0x4e0670 ; ?
01db9e4c  mov      rcx, rax
01db9e4f  xor      edx, edx
01db9e51  call     0x4e0cc0 ; ?
01db9e56  int3     
01db9e57  call     0x4e0cf0 ; ?
01db9e5c  int3     
01db9e5d  int3     
01db9e5e  int3     
01db9e5f  int3     

### Collections.Generic.List`1<String> Enemy.Ene_BosBase::GetBulletTemplates()  RVA=0x1DB98C0 len=0x160
01db98c0  mov      qword ptr [rsp + 0x20], rbx
01db98c5  push     rsi
01db98c6  sub      rsp, 0x20
01db98ca  cmp      byte ptr [rip + 0x28a9fa7], 0 ; [4663878] bss
01db98d1  mov      rbx, rcx
01db98d4  jne      0x1db9901
01db98d6  lea      rcx, [rip + 0x25d810b] ; [43919e8] MethodRef#205594
01db98dd  call     0x4e0a50 ; il2cpp_init_metadata
01db98e2  lea      rcx, [rip + 0x25bbb8f] ; [4375478] MethodRef#202061
01db98e9  call     0x4e0a50 ; il2cpp_init_metadata
01db98ee  lea      rcx, [rip + 0x25fe70b] ; [43b8000] MethodRef#202981
01db98f5  call     0x4e0a50 ; il2cpp_init_metadata
01db98fa  mov      byte ptr [rip + 0x28a9f77], 1 ; [4663878] bss
01db9901  mov      qword ptr [rsp + 0x30], rbp
01db9906  xor      edx, edx
01db9908  mov      qword ptr [rsp + 0x38], rdi
01db990d  mov      rcx, rbx
01db9910  mov      qword ptr [rsp + 0x40], r14
01db9915  call     0x1d0d650 ; Collections.Generic.List`1<String> Enemy.PawnEnemy::GetBulletTemplates()
01db991a  mov      rdx, qword ptr [rbx]
01db991d  mov      rcx, rbx
01db9920  mov      rsi, rax
01db9923  mov      r8, qword ptr [rdx + 0x6a8]
01db992a  mov      rdx, qword ptr [rdx + 0x6b0]
01db9931  call     r8
01db9934  test     rax, rax
01db9937  je       0x1db9954
01db9939  test     rsi, rsi
01db993c  je       0x1db9a11
01db9942  mov      r8, qword ptr [rip + 0x25bbb2f] ; [4375478] MethodRef#202061
01db9949  mov      rdx, rax
01db994c  mov      rcx, rsi
01db994f  call     0xbc80e0 ; ?
01db9954  mov      rdx, qword ptr [rbx]
01db9957  mov      rcx, rbx
01db995a  mov      rax, qword ptr [rdx + 0x6b8]
01db9961  mov      rdx, qword ptr [rdx + 0x6c0]
01db9968  call     rax
01db996a  mov      rdi, rax
01db996d  test     rax, rax
01db9970  je       0x1db99f4
01db9976  mov      rdx, qword ptr [rip + 0x25d806b] ; [43919e8] MethodRef#205594
01db997d  mov      rcx, rax
01db9980  call     0x7d5180 ; Boolean Linq.Enumerable::Any(Collections.Generic.IEnumerable`1<TSource>)
01db9985  test     al, al
01db9987  je       0x1db99f4
01db9989  mov      rcx, qword ptr [rip + 0x25fe670] ; [43b8000] MethodRef#202981
01db9990  call     0x27540 ; ?
01db9995  mov      rbp, rax
01db9998  lea      r14, [rdi + 0x20]
01db999c  xor      ebx, ebx
01db999e  mov      ecx, ebx
01db99a0  cmp      ebx, dword ptr [rdi + 0x18]
01db99a3  jge      0x1db99f4
01db99a5  cmp      ebx, dword ptr [rdi + 0x18]
01db99a8  jae      0x1db9a17
01db99aa  test     rbp, rbp
01db99ad  je       0x1db9a11
01db99af  mov      rcx, qword ptr [rbp + 0x138]
01db99b6  test     rcx, rcx
01db99b9  je       0x1db9a11
01db99bb  mov      rdx, qword ptr [r14]
01db99be  xor      r8d, r8d
01db99c1  call     0x1cd2f00 ; Timeline.EnemyData InGameEnemyClipsManager::GetData(String)
01db99c6  test     rax, rax
01db99c9  je       0x1db9a11
01db99cb  xor      edx, edx
01db99cd  mov      rcx, rax
01db99d0  call     0x1d322f0 ; Collections.Generic.List`1<String> Timeline.EnemyData::GetBulletTemplateNames()
01db99d5  test     rsi, rsi
01db99d8  je       0x1db9a11
01db99da  mov      r8, qword ptr [rip + 0x25bba97] ; [4375478] MethodRef#202061
01db99e1  mov      rdx, rax
01db99e4  mov      rcx, rsi
01db99e7  call     0xbc80e0 ; ?
01db99ec  inc      ebx
01db99ee  add      r14, 8
01db99f2  jmp      0x1db999e
01db99f4  mov      r14, qword ptr [rsp + 0x40]
01db99f9  mov      rax, rsi
01db99fc  mov      rdi, qword ptr [rsp + 0x38]
01db9a01  mov      rbp, qword ptr [rsp + 0x30]
01db9a06  mov      rbx, qword ptr [rsp + 0x48]
01db9a0b  add      rsp, 0x20
01db9a0f  pop      rsi
01db9a10  ret      
01db9a11  call     0x4e0d00 ; ThrowNullRef
01db9a16  int3     
01db9a17  call     0x4e0cf0 ; ?
01db9a1c  int3     
01db9a1d  int3     
01db9a1e  int3     
01db9a1f  int3     

### Void Enemy.Ene_BosBase::ReStart(Boolean)  RVA=0x1DBA390 len=0xA0
01dba390  mov      qword ptr [rsp + 8], rbx
01dba395  mov      qword ptr [rsp + 0x10], rsi
01dba39a  push     rdi
01dba39b  sub      rsp, 0x30
01dba39f  xor      esi, esi
01dba3a1  mov      dword ptr [rcx + 0x1b0], 0
01dba3ab  movzx    edi, dl
01dba3ae  mov      dword ptr [rcx + 0x1ec], esi
01dba3b4  mov      rdx, qword ptr [rcx + 0x50]
01dba3b8  mov      rbx, rcx
01dba3bb  mov      qword ptr [rcx + 0x21c], rsi
01dba3c2  mov      dword ptr [rcx + 0x1bc], esi
01dba3c8  mov      byte ptr [rcx + 0x1b4], sil
01dba3cf  test     rdx, rdx
01dba3d2  je       0x1dba424
01dba3d4  xor      r8d, r8d
01dba3d7  lea      rcx, [rsp + 0x20]
01dba3dc  call     0x3093700 ; Vector3 Transform::get_localPosition()
01dba3e1  xor      r8d, r8d
01dba3e4  movzx    edx, dil
01dba3e8  mov      ecx, dword ptr [rax + 8]
01dba3eb  movsd    xmm0, qword ptr [rax]
01dba3ef  movsd    qword ptr [rbx + 0x228], xmm0
01dba3f7  mov      dword ptr [rbx + 0x230], ecx
01dba3fd  mov      rcx, rbx
01dba400  mov      dword ptr [rbx + 0x224], esi
01dba406  mov      dword ptr [rbx + 0x1c0], 0x41200000
01dba410  mov      rbx, qword ptr [rsp + 0x40]
01dba415  mov      rsi, qword ptr [rsp + 0x48]
01dba41a  add      rsp, 0x30
01dba41e  pop      rdi
01dba41f  jmp      0x1d0f040 ; Void Enemy.PawnEnemy::ReStart(Boolean)
01dba424  call     0x4e0d00 ; ThrowNullRef
01dba429  int3     
01dba42a  int3     
01dba42b  int3     
01dba42c  int3     
01dba42d  int3     
01dba42e  int3     
01dba42f  int3     

### Boolean Enemy.Ene_BosBase::IsBossType()  RVA=0x60A0D0 len=0x10
0060a0d0  mov      al, 1
0060a0d2  ret      
0060a0d3  int3     
0060a0d4  int3     
0060a0d5  int3     
0060a0d6  int3     
0060a0d7  int3     
0060a0d8  int3     
0060a0d9  int3     
0060a0da  int3     
0060a0db  int3     
0060a0dc  int3     
0060a0dd  int3     
0060a0de  int3     
0060a0df  int3     

### Void Enemy.Ene_BosBase::LocalLateUpdate(Single)  RVA=0x1DB9FF0 len=0x1E0
01db9ff0  mov      qword ptr [rsp + 0x10], rbx
01db9ff5  push     rdi
01db9ff6  sub      rsp, 0x60
01db9ffa  cmp      byte ptr [rip + 0x28a9878], 0 ; [4663879] bss
01dba001  mov      rbx, rcx
01dba004  movaps   xmmword ptr [rsp + 0x50], xmm6
01dba009  movaps   xmm6, xmm1
01dba00c  movaps   xmmword ptr [rsp + 0x40], xmm7
01dba011  jne      0x1dba026
01dba013  lea      rcx, [rip + 0x25fdfe6] ; [43b8000] MethodRef#202981
01dba01a  call     0x4e0a50 ; il2cpp_init_metadata
01dba01f  mov      byte ptr [rip + 0x28a9853], 1 ; [4663879] bss
01dba026  mov      rax, qword ptr [rip + 0x25fdfd3] ; [43b8000] MethodRef#202981
01dba02d  mov      rax, qword ptr [rax + 0x20]
01dba031  test     byte ptr [rax + 0x135], 1
01dba038  jne      0x1dba042
01dba03a  mov      rcx, rax
01dba03d  call     0x4de1e0 ; ?
01dba042  mov      rax, qword ptr [rax + 0xc0]
01dba049  mov      rax, qword ptr [rax + 0x10]
01dba04d  test     byte ptr [rax + 0x135], 1
01dba054  jne      0x1dba05e
01dba056  mov      rcx, rax
01dba059  call     0x4de1e0 ; ?
01dba05e  mov      rax, qword ptr [rax + 0xb8]
01dba065  xorps    xmm7, xmm7
01dba068  comiss   xmm6, xmm7
01dba06b  mov      qword ptr [rsp + 0x70], rsi
01dba070  mov      rdi, qword ptr [rax]
01dba073  movaps   xmmword ptr [rsp + 0x30], xmm8
01dba079  jbe      0x1dba19d
01dba07f  mov      rdx, qword ptr [rbx]
01dba082  mov      rcx, rbx
01dba085  mov      rax, qword ptr [rdx + 0x368]
01dba08c  mov      rdx, qword ptr [rdx + 0x370]
01dba093  call     rax
01dba095  test     al, al
01dba097  je       0x1dba19d
01dba09d  mov      rdx, qword ptr [rbx + 0x50]
01dba0a1  test     rdx, rdx
01dba0a4  je       0x1dba1ca
01dba0aa  xor      r8d, r8d
01dba0ad  lea      rcx, [rsp + 0x20]
01dba0b2  call     0x3093ba0 ; Vector3 Transform::get_position()
01dba0b7  mov      rdx, qword ptr [rbx]
01dba0ba  mov      rcx, rbx
01dba0bd  movsd    xmm8, qword ptr [rax]
01dba0c2  mov      esi, dword ptr [rax + 8]
01dba0c5  mov      rax, qword ptr [rdx + 0x238]
01dba0cc  mov      rdx, qword ptr [rdx + 0x240]
01dba0d3  call     rax
01dba0d5  test     rdi, rdi
01dba0d8  je       0x1dba1ca
01dba0de  xor      r9d, r9d
01dba0e1  movsd    qword ptr [rsp + 0x20], xmm8
01dba0e8  movzx    r8d, al
01dba0ec  mov      dword ptr [rsp + 0x28], esi
01dba0f0  lea      rdx, [rsp + 0x20]
01dba0f5  mov      rcx, rdi
01dba0f8  call     0x1ce4c30 ; Int32 InGameManager::GetNearestPlayerIndexInWorld(Vector3,Boolean)
01dba0fd  xor      r9d, r9d
01dba100  lea      rcx, [rsp + 0x20]
01dba105  mov      r8d, eax
01dba108  mov      rdx, rdi
01dba10b  call     0x1ce5c90 ; Vector3 InGameManager::GetPlayerSkyPosition(Int32)
01dba110  movss    xmm0, dword ptr [rip + 0x1838b00] ; [35f2c18] f=-20.0 d=-206158529344.0 v4=(-20.0, -50.0, -200.0, 0.0)
01dba118  movsd    xmm2, qword ptr [rax]
01dba11c  mov      edx, dword ptr [rax + 8]
01dba11f  comiss   xmm7, xmm2
01dba122  movd     xmm1, edx
01dba126  movsd    qword ptr [rbx + 0x1f0], xmm2
01dba12e  seta     al
01dba131  mov      dword ptr [rbx + 0x1f8], edx
01dba137  comiss   xmm7, xmm1
01dba13a  mov      byte ptr [rbx + 0x1b5], al
01dba140  seta     al
01dba143  comiss   xmm0, xmm1
01dba146  mov      byte ptr [rbx + 0x1b6], al
01dba14c  seta     al
01dba14f  comiss   xmm2, dword ptr [rip + 0x1838a72] ; [35f2bc8] f=-100.0 d=-7.673848961291161e+21 v4=(-100.0, -1000.0, 0.5, 0.5)
01dba156  mov      byte ptr [rbx + 0x1b8], al
01dba15c  ja       0x1dba162
01dba15e  xor      eax, eax
01dba160  jmp      0x1dba170
01dba162  movss    xmm0, dword ptr [rip + 0x1726a7a] ; [34e0be4] f=100.0 d=5629500654616576.0 v4=(100.0, 180.0, 2000.0, -0.0001)
01dba16a  comiss   xmm0, xmm2
01dba16d  seta     al
01dba170  xor      r8d, r8d
01dba173  mov      byte ptr [rbx + 0x1b7], al
01dba179  movaps   xmm1, xmm6
01dba17c  mov      rcx, rbx
01dba17f  call     0x1dba1d0 ; Void Enemy.Ene_BosBase::ProgressBossTimer(Single)
01dba184  mov      r8, qword ptr [rbx]
01dba187  movaps   xmm1, xmm6
01dba18a  mov      rcx, rbx
01dba18d  mov      rax, qword ptr [r8 + 0x688]
01dba194  mov      r8, qword ptr [r8 + 0x690]
01dba19b  call     rax
01dba19d  xor      r8d, r8d
01dba1a0  movaps   xmm1, xmm6
01dba1a3  mov      rcx, rbx
01dba1a6  movaps   xmm8, xmmword ptr [rsp + 0x30]
01dba1ac  mov      rsi, qword ptr [rsp + 0x70]
01dba1b1  mov      rbx, qword ptr [rsp + 0x78]
01dba1b6  movaps   xmm6, xmmword ptr [rsp + 0x50]
01dba1bb  movaps   xmm7, xmmword ptr [rsp + 0x40]
01dba1c0  add      rsp, 0x60
01dba1c4  pop      rdi
01dba1c5  jmp      0x1d0e790 ; Void Enemy.PawnEnemy::LocalLateUpdate(Single)
01dba1ca  call     0x4e0d00 ; ThrowNullRef
01dba1cf  int3     

### Void Enemy.Ene_BosBase::ResetBossTimer(Boolean)  RVA=0x1DBA430 len=0x80
01dba430  push     rbx
01dba432  sub      rsp, 0x30
01dba436  mov      byte ptr [rcx + 0x1b2], dl
01dba43c  mov      rbx, rcx
01dba43f  mov      rdx, qword ptr [rcx + 0x50]
01dba443  mov      dword ptr [rcx + 0x1bc], 0
01dba44d  mov      word ptr [rcx + 0x1b3], 0
01dba456  mov      dword ptr [rcx + 0x21c], 0
01dba460  test     rdx, rdx
01dba463  je       0x1dba4a1
01dba465  xor      r8d, r8d
01dba468  lea      rcx, [rsp + 0x20]
01dba46d  call     0x3093700 ; Vector3 Transform::get_localPosition()
01dba472  movsd    xmm0, qword ptr [rax]
01dba476  mov      ecx, dword ptr [rax + 8]
01dba479  movsd    qword ptr [rbx + 0x228], xmm0
01dba481  mov      dword ptr [rbx + 0x230], ecx
01dba487  mov      dword ptr [rbx + 0x224], 0
01dba491  mov      dword ptr [rbx + 0x1c0], 0x41200000
01dba49b  add      rsp, 0x30
01dba49f  pop      rbx
01dba4a0  ret      
01dba4a1  call     0x4e0d00 ; ThrowNullRef
01dba4a6  int3     
01dba4a7  int3     
01dba4a8  int3     
01dba4a9  int3     
01dba4aa  int3     
01dba4ab  int3     
01dba4ac  int3     
01dba4ad  int3     
01dba4ae  int3     
01dba4af  int3     

### Void Enemy.Ene_BosBase::UpdatePlayerPositionFlag(Vector3)  RVA=0x1DBAE10 len=0x80
01dbae10  movsd    xmm0, qword ptr [rdx]
01dbae14  mov      eax, dword ptr [rdx + 8]
01dbae17  movsd    qword ptr [rcx + 0x1f0], xmm0
01dbae1f  xorps    xmm0, xmm0
01dbae22  comiss   xmm0, dword ptr [rdx]
01dbae25  mov      dword ptr [rcx + 0x1f8], eax
01dbae2b  seta     al
01dbae2e  comiss   xmm0, dword ptr [rdx + 8]
01dbae32  mov      byte ptr [rcx + 0x1b5], al
01dbae38  movss    xmm0, dword ptr [rip + 0x1837dd8] ; [35f2c18] f=-20.0 d=-206158529344.0 v4=(-20.0, -50.0, -200.0, 0.0)
01dbae40  seta     al
01dbae43  comiss   xmm0, dword ptr [rdx + 8]
01dbae47  mov      byte ptr [rcx + 0x1b6], al
01dbae4d  movss    xmm0, dword ptr [rdx]
01dbae51  seta     al
01dbae54  comiss   xmm0, dword ptr [rip + 0x1837d6d] ; [35f2bc8] f=-100.0 d=-7.673848961291161e+21 v4=(-100.0, -1000.0, 0.5, 0.5)
01dbae5b  mov      byte ptr [rcx + 0x1b8], al
01dbae61  ja       0x1dbae6c
01dbae63  xor      eax, eax
01dbae65  mov      byte ptr [rcx + 0x1b7], al
01dbae6b  ret      
01dbae6c  movss    xmm0, dword ptr [rip + 0x1725d70] ; [34e0be4] f=100.0 d=5629500654616576.0 v4=(100.0, 180.0, 2000.0, -0.0001)
01dbae74  comiss   xmm0, dword ptr [rdx]
01dbae77  seta     al
01dbae7a  mov      byte ptr [rcx + 0x1b7], al
01dbae80  ret      
01dbae81  int3     
01dbae82  int3     
01dbae83  int3     
01dbae84  int3     
01dbae85  int3     
01dbae86  int3     
01dbae87  int3     
01dbae88  int3     
01dbae89  int3     
01dbae8a  int3     
01dbae8b  int3     
01dbae8c  int3     
01dbae8d  int3     
01dbae8e  int3     
01dbae8f  int3     

### Void Enemy.Ene_BosBase::ProgressBossTimer(Single)  RVA=0x1DBA1D0 len=0x1C0
01dba1d0  push     rbx
01dba1d2  sub      rsp, 0x60
01dba1d6  cmp      byte ptr [rcx + 0x1b2], 0
01dba1dd  mov      rbx, rcx
01dba1e0  movaps   xmmword ptr [rsp + 0x50], xmm6
01dba1e5  movaps   xmm6, xmm1
01dba1e8  movaps   xmmword ptr [rsp + 0x40], xmm7
01dba1ed  movaps   xmmword ptr [rsp + 0x30], xmm8
01dba1f3  xorps    xmm8, xmm8
01dba1f7  movaps   xmmword ptr [rsp + 0x20], xmm9
01dba1fd  movss    xmm9, dword ptr [rip + 0x1838c9e] ; [35f2ea4] f=86400.0 d=-281475051850752.0 v4=(86400.0, -120.0, -1920.0, 0.25)
01dba206  je       0x1dba2cf
01dba20c  movaps   xmm7, xmm1
01dba20f  addss    xmm7, dword ptr [rcx + 0x1bc]
01dba217  comiss   xmm8, xmm7
01dba21b  ja       0x1dba229
01dba21d  comiss   xmm7, xmm9
01dba221  jbe      0x1dba22c
01dba223  movaps   xmm7, xmm9
01dba227  jmp      0x1dba22c
01dba229  xorps    xmm7, xmm7
01dba22c  cmp      dword ptr [rcx + 0x224], 0x12
01dba233  movss    dword ptr [rcx + 0x1bc], xmm7
01dba23b  je       0x1dba2b9
01dba23d  mov      rdx, qword ptr [rcx]
01dba240  mov      rax, qword ptr [rdx + 0x698]
01dba247  mov      rdx, qword ptr [rdx + 0x6a0]
01dba24e  call     rax
01dba250  comiss   xmm7, xmm0
01dba253  jae      0x1dba290
01dba255  movss    xmm0, dword ptr [rbx + 0x1c0]
01dba25d  subss    xmm0, xmm6
01dba261  comiss   xmm8, xmm0
01dba265  movss    dword ptr [rbx + 0x1c0], xmm0
01dba26d  jb       0x1dba29a
01dba26f  cmp      dword ptr [rbx + 0x224], 0x12
01dba276  jge      0x1dba2a1
01dba278  addss    xmm0, dword ptr [rip + 0x1726958] ; [34e0bd8] f=10.0 d=134217760.5625 v4=(10.0, 20.0, 57.29578, 100.0)
01dba280  inc      dword ptr [rbx + 0x224]
01dba286  movss    dword ptr [rbx + 0x1c0], xmm0
01dba28e  jmp      0x1dba29a
01dba290  mov      dword ptr [rbx + 0x224], 0x12
01dba29a  cmp      dword ptr [rbx + 0x224], 0x12
01dba2a1  jne      0x1dba2b9
01dba2a3  mov      rdx, qword ptr [rbx]
01dba2a6  mov      rcx, rbx
01dba2a9  mov      rax, qword ptr [rdx + 0x6d8]
01dba2b0  mov      rdx, qword ptr [rdx + 0x6e0]
01dba2b7  call     rax
01dba2b9  mov      rdx, qword ptr [rbx]
01dba2bc  mov      rcx, rbx
01dba2bf  mov      rax, qword ptr [rdx + 0x6c8]
01dba2c6  mov      rdx, qword ptr [rdx + 0x6d0]
01dba2cd  call     rax
01dba2cf  cmp      byte ptr [rbx + 0x1b4], 0
01dba2d6  jne      0x1dba308
01dba2d8  movaps   xmm0, xmm6
01dba2db  mulss    xmm0, dword ptr [rbx + 0x1cc]
01dba2e3  addss    xmm0, dword ptr [rbx + 0x1c8]
01dba2eb  comiss   xmm8, xmm0
01dba2ef  ja       0x1dba2fd
01dba2f1  comiss   xmm0, xmm9
01dba2f5  jbe      0x1dba300
01dba2f7  movaps   xmm0, xmm9
01dba2fb  jmp      0x1dba300
01dba2fd  xorps    xmm0, xmm0
01dba300  movss    dword ptr [rbx + 0x1c8], xmm0
01dba308  movss    xmm0, dword ptr [rbx + 0x1d0]
01dba310  comiss   xmm0, xmm8
01dba314  movaps   xmm9, xmmword ptr [rsp + 0x20]
01dba31a  jbe      0x1dba374
01dba31c  addss    xmm6, dword ptr [rbx + 0x1d4]
01dba324  comiss   xmm6, xmm0
01dba327  movss    dword ptr [rbx + 0x1d4], xmm6
01dba32f  setae    al
01dba332  mov      byte ptr [rbx + 0x1dc], al
01dba338  test     al, al
01dba33a  je       0x1dba374
01dba33c  movaps   xmm7, xmm0
01dba33f  movaps   xmm0, xmm6
01dba342  divss    xmm0, xmm7
01dba346  call     0x578740 ; ?
01dba34b  mulss    xmm0, xmm7
01dba34f  subss    xmm6, xmm0
01dba353  comiss   xmm8, xmm6
01dba357  ja       0x1dba363
01dba359  comiss   xmm6, xmm7
01dba35c  jbe      0x1dba366
01dba35e  movaps   xmm6, xmm7
01dba361  jmp      0x1dba366
01dba363  xorps    xmm6, xmm6
01dba366  inc      dword ptr [rbx + 0x1d8]
01dba36c  movss    dword ptr [rbx + 0x1d4], xmm6
01dba374  movaps   xmm6, xmmword ptr [rsp + 0x50]
01dba379  movaps   xmm7, xmmword ptr [rsp + 0x40]
01dba37e  movaps   xmm8, xmmword ptr [rsp + 0x30]
01dba384  add      rsp, 0x60
01dba388  pop      rbx
01dba389  ret      
01dba38a  int3     
01dba38b  int3     
01dba38c  int3     
01dba38d  int3     
01dba38e  int3     
01dba38f  int3     

### Void Enemy.Ene_BosBase::StopBossTimer()  RVA=0x1DBA790 len=0x110
01dba790  push     rbx
01dba792  sub      rsp, 0x20
01dba796  cmp      byte ptr [rip + 0x28a90dd], 0 ; [466387a] bss
01dba79d  mov      rbx, rcx
01dba7a0  jne      0x1dba7c1
01dba7a2  lea      rcx, [rip + 0x25fd857] ; [43b8000] MethodRef#202981
01dba7a9  call     0x4e0a50 ; il2cpp_init_metadata
01dba7ae  lea      rcx, [rip + 0x25e7bb3] ; [43a2368] TypeInfo#45781
01dba7b5  call     0x4e0a50 ; il2cpp_init_metadata
01dba7ba  mov      byte ptr [rip + 0x28a90b9], 1 ; [466387a] bss
01dba7c1  xor      edx, edx
01dba7c3  mov      qword ptr [rsp + 0x30], rdi
01dba7c8  mov      rcx, rbx
01dba7cb  call     0x1d0d580 ; Void Enemy.PawnEnemy::DisabledAllParts()
01dba7d0  cmp      byte ptr [rbx + 0x1b2], 0
01dba7d7  je       0x1dba872
01dba7dd  mov      rax, qword ptr [rip + 0x25fd81c] ; [43b8000] MethodRef#202981
01dba7e4  mov      rax, qword ptr [rax + 0x20]
01dba7e8  test     byte ptr [rax + 0x135], 1
01dba7ef  jne      0x1dba7f9
01dba7f1  mov      rcx, rax
01dba7f4  call     0x4de1e0 ; ?
01dba7f9  mov      rax, qword ptr [rax + 0xc0]
01dba800  mov      rax, qword ptr [rax + 0x10]
01dba804  test     byte ptr [rax + 0x135], 1
01dba80b  jne      0x1dba815
01dba80d  mov      rcx, rax
01dba810  call     0x4de1e0 ; ?
01dba815  mov      rax, qword ptr [rax + 0xb8]
01dba81c  mov      rdi, qword ptr [rax]
01dba81f  test     rdi, rdi
01dba822  je       0x1dba88d
01dba824  xor      edx, edx
01dba826  mov      rcx, rdi
01dba829  call     0x1ce2150 ; Void InGameManager::AddDiPoint_BossDestroy()
01dba82e  mov      rdx, qword ptr [rbx]
01dba831  mov      rcx, rbx
01dba834  mov      rax, qword ptr [rdx + 0x6e8]
01dba83b  mov      rdx, qword ptr [rdx + 0x6f0]
01dba842  call     rax
01dba844  xor      r8d, r8d
01dba847  mov      edx, eax
01dba849  mov      rcx, rdi
01dba84c  call     0x1cea790 ; Void InGameManager::SetBossTime(Int32)
01dba851  mov      rcx, qword ptr [rip + 0x25e7b10] ; [43a2368] TypeInfo#45781
01dba858  cmp      dword ptr [rcx + 0xe4], 0
01dba85f  jne      0x1dba866
01dba861  call     0x4e0d90 ; il2cpp_class_init
01dba866  xor      edx, edx
01dba868  mov      ecx, 0xb1
01dba86d  call     0x2723de0 ; Void TXEKernel.Sound.SoundUtility::PlayQue(TXEKernel.Sound.SoundUtility/ID)
01dba872  xor      edx, edx
01dba874  mov      byte ptr [rbx + 0x1b2], 0
01dba87b  mov      rcx, rbx
01dba87e  mov      rdi, qword ptr [rsp + 0x30]
01dba883  add      rsp, 0x20
01dba887  pop      rbx
01dba888  jmp      0x1d0d200 ; Void Enemy.PawnEnemy::DeadResultUpdate()
01dba88d  call     0x4e0d00 ; ThrowNullRef
01dba892  int3     
01dba893  int3     
01dba894  int3     
01dba895  int3     
01dba896  int3     
01dba897  int3     
01dba898  int3     
01dba899  int3     
01dba89a  int3     
01dba89b  int3     
01dba89c  int3     
01dba89d  int3     
01dba89e  int3     
01dba89f  int3     

### Single Enemy.Ene_BosBase::GetBattileTime()  RVA=0x1DB9870 len=0x50
01db9870  sub      rsp, 0x28
01db9874  cmp      byte ptr [rip + 0x28aa000], 0 ; [466387b] bss
01db987b  jne      0x1db9890
01db987d  lea      rcx, [rip + 0x25fff8c] ; [43b9810] TypeInfo#47822
01db9884  call     0x4e0a50 ; il2cpp_init_metadata
01db9889  mov      byte ptr [rip + 0x28a9feb], 1 ; [466387b] bss
01db9890  mov      rax, qword ptr [rip + 0x25fff79] ; [43b9810] TypeInfo#47822
01db9897  cmp      dword ptr [rax + 0xe4], 0
01db989e  jne      0x1db98af
01db98a0  mov      rcx, rax
01db98a3  call     0x4e0d90 ; il2cpp_class_init
01db98a8  mov      rax, qword ptr [rip + 0x25fff61] ; [43b9810] TypeInfo#47822
01db98af  mov      rcx, qword ptr [rax + 0xb8]
01db98b6  movss    xmm0, dword ptr [rcx]
01db98ba  add      rsp, 0x28
01db98be  ret      
01db98bf  int3     

### Collections.Generic.List`1<Enemy.PawnEnemy> Enemy.Ene_BosBase::CallEnemyClip(Int32,Vector3,Enemy.PawnEnemy/poolEventFunction)  RVA=0x1DB8F70 len=0x230
01db8f70  mov      qword ptr [rsp + 8], rbx
01db8f75  mov      qword ptr [rsp + 0x10], rsi
01db8f7a  mov      qword ptr [rsp + 0x18], rdi
01db8f7f  push     r14
01db8f81  sub      rsp, 0x90
01db8f88  mov      r14, r9
01db8f8b  mov      rsi, r8
01db8f8e  movsxd   rbx, edx
01db8f91  mov      rdi, rcx
01db8f94  cmp      byte ptr [rip + 0x28aa8e1], 0 ; [466387c] bss
01db8f9b  jne      0x1db8fe0
01db8f9d  lea      rcx, [rip + 0x260213c] ; [43bb0e0] MethodRef#199176
01db8fa4  call     0x4e0a50 ; il2cpp_init_metadata
01db8fa9  lea      rcx, [rip + 0x26021e8] ; [43bb198] MethodRef#199177
01db8fb0  call     0x4e0a50 ; il2cpp_init_metadata
01db8fb5  lea      rcx, [rip + 0x2602294] ; [43bb250] MethodRef#199178
01db8fbc  call     0x4e0a50 ; il2cpp_init_metadata
01db8fc1  lea      rcx, [rip + 0x25a9e38] ; [4362e00] MethodRef#201786
01db8fc8  call     0x4e0a50 ; il2cpp_init_metadata
01db8fcd  lea      rcx, [rip + 0x25ff02c] ; [43b8000] MethodRef#202981
01db8fd4  call     0x4e0a50 ; il2cpp_init_metadata
01db8fd9  mov      byte ptr [rip + 0x28aa89c], 1 ; [466387c] bss
01db8fe0  xorps    xmm0, xmm0
01db8fe3  xor      eax, eax
01db8fe5  movups   xmmword ptr [rsp + 0x70], xmm0
01db8fea  mov      qword ptr [rsp + 0x80], rax
01db8ff2  test     ebx, ebx
01db8ff4  js       0x1db9163
01db8ffa  cmp      ebx, dword ptr [rdi + 0x1fc]
01db9000  jge      0x1db9163
01db9006  mov      rcx, qword ptr [rip + 0x25feff3] ; [43b8000] MethodRef#202981
01db900d  call     0x27540 ; ?
01db9012  mov      r10, rax
01db9015  mov      rcx, qword ptr [rdi + 0x200]
01db901c  test     rcx, rcx
01db901f  je       0x1db9197
01db9025  cmp      ebx, dword ptr [rcx + 0x18]
01db9028  jae      0x1db917f
01db902e  mov      rdx, qword ptr [rcx + rbx*8 + 0x20]
01db9033  test     r10, r10
01db9036  je       0x1db9197
01db903c  movsd    xmm0, qword ptr [rsi]
01db9040  movsd    qword ptr [rsp + 0x40], xmm0
01db9046  mov      eax, dword ptr [rsi + 8]
01db9049  mov      dword ptr [rsp + 0x48], eax
01db904d  xor      ebx, ebx
01db904f  mov      qword ptr [rsp + 0x30], rbx
01db9054  mov      dword ptr [rsp + 0x28], ebx
01db9058  mov      dword ptr [rsp + 0x20], 2
01db9060  lea      r9, [rsp + 0x40]
01db9065  mov      r8, qword ptr [r10 + 0x98]
01db906c  mov      rcx, r10
01db906f  call     0x1ce38d0 ; Collections.Generic.List`1<Enemy.PawnEnemy> InGameManager::EntryEnemyNoRate(Timeline.EnemyData,Transform,Vector3,Enemy.PawnEnemy/Division,Int32)
01db9074  mov      rsi, rax
01db9077  mov      qword ptr [rsp + 0x40], rax
01db907c  test     rax, rax
01db907f  je       0x1db9163
01db9085  mov      r8, qword ptr [rip + 0x25a9d74] ; [4362e00] MethodRef#201786
01db908c  mov      rdx, rax
01db908f  lea      rcx, [rsp + 0x58]
01db9094  call     0xb11790 ; ?
01db9099  movups   xmm0, xmmword ptr [rsp + 0x58]
01db909e  movups   xmmword ptr [rsp + 0x70], xmm0
01db90a3  movsd    xmm1, qword ptr [rsp + 0x68]
01db90a9  movsd    qword ptr [rsp + 0x80], xmm1
01db90b2  mov      qword ptr [rsp + 0x58], rbx
01db90b7  lea      rbx, [rsp + 0x70]
01db90bc  mov      qword ptr [rsp + 0x60], rbx
01db90c1  mov      rdx, qword ptr [rip + 0x26020d0] ; [43bb198] MethodRef#199177
01db90c8  lea      rcx, [rsp + 0x70]
01db90cd  call     0x198e510 ; ?
01db90d2  test     al, al
01db90d4  je       0x1db912d
01db90d6  mov      rdi, qword ptr [rsp + 0x80]
01db90de  test     rdi, rdi
01db90e1  je       0x1db918b
01db90e7  xor      r8d, r8d
01db90ea  mov      rdx, r14
01db90ed  mov      rcx, rdi
01db90f0  call     0x1d11b00 ; Void Enemy.PawnEnemy::add_PoolEvent(Enemy.PawnEnemy/poolEventFunction)
01db90f5  xor      edx, edx
01db90f7  mov      rcx, rdi
01db90fa  call     0x1d0e5b0 ; Boolean Enemy.PawnEnemy::IsDelayed()
01db90ff  test     al, al
01db9101  jne      0x1db90c1
01db9103  mov      rax, qword ptr [rdi + 0xb8]
01db910a  test     rax, rax
01db910d  je       0x1db9185
01db910f  cmp      byte ptr [rax + 0x51], 0
01db9113  jne      0x1db90c1
01db9115  mov      rcx, rax
01db9118  mov      rdx, qword ptr [rax]
01db911b  mov      rax, qword ptr [rdx + 0x1a8]
01db9122  mov      rdx, qword ptr [rdx + 0x1b0]
01db9129  call     rax
01db912b  jmp      0x1db90c1
01db912d  mov      rdx, qword ptr [rip + 0x2601fac] ; [43bb0e0] MethodRef#199176
01db9134  mov      rcx, rbx
01db9137  call     0x5bcdb0 ; Void AEAsAnimation.AEAsAnimationRoot/<ShowAsync>d__21::IDisposable.Dispose() || Void AEAsAnimation.AEComposition/<AttachAsync>d__9::IDisposable.Dispose() || Void AEAsAnimation.AELayerReflection/<AttachAsync>d__14::IDisposable.Dispose()
01db913c  jmp      0x1db915e
01db913e  mov      rdx, qword ptr [rip + 0x2601f9b] ; [43bb0e0] MethodRef#199176
01db9145  mov      rcx, qword ptr [rsp + 0x60]
01db914a  call     0x5bcdb0 ; Void AEAsAnimation.AEAsAnimationRoot/<ShowAsync>d__21::IDisposable.Dispose() || Void AEAsAnimation.AEComposition/<AttachAsync>d__9::IDisposable.Dispose() || Void AEAsAnimation.AELayerReflection/<AttachAsync>d__14::IDisposable.Dispose()
01db914f  mov      rcx, qword ptr [rsp + 0x58]
01db9154  test     rcx, rcx
01db9157  jne      0x1db9191
01db9159  mov      rsi, qword ptr [rsp + 0x40]
01db915e  mov      rax, rsi
01db9161  jmp      0x1db9165
01db9163  xor      eax, eax
01db9165  lea      r11, [rsp + 0x90]
01db916d  mov      rbx, qword ptr [r11 + 0x10]
01db9171  mov      rsi, qword ptr [r11 + 0x18]
01db9175  mov      rdi, qword ptr [r11 + 0x20]
01db9179  mov      rsp, r11
01db917c  pop      r14
01db917e  ret      
01db917f  call     0x4e0cf0 ; ?
01db9184  nop      
01db9185  call     0x4e0d00 ; ThrowNullRef
01db918a  nop      
01db918b  call     0x4e0d00 ; ThrowNullRef
01db9190  nop      
01db9191  call     0x4dc9e0 ; ?
01db9196  int3     
01db9197  call     0x4e0d00 ; ThrowNullRef
01db919c  int3     
01db919d  int3     
01db919e  int3     
01db919f  int3     

### Enemy.BulletTemplate Enemy.Ene_BosBase::GetBT(Int32)  RVA=0x1DB9840 len=0x30
01db9840  sub      rsp, 0x28
01db9844  mov      r8, qword ptr [rcx + 0x208]
01db984b  test     r8, r8
01db984e  je       0x1db9863
01db9850  cmp      edx, dword ptr [r8 + 0x18]
01db9854  jae      0x1db9869
01db9856  movsxd   rax, edx
01db9859  mov      rax, qword ptr [r8 + rax*8 + 0x20]
01db985e  add      rsp, 0x28
01db9862  ret      
01db9863  call     0x4e0d00 ; ThrowNullRef
01db9868  int3     
01db9869  call     0x4e0cf0 ; ?
01db986e  int3     
01db986f  int3     

### String[] Enemy.Ene_BosBase::GetBossBT()  RVA=0x79B610 len=0x10
0079b610  xor      eax, eax
0079b612  ret      
0079b613  int3     
0079b614  int3     
0079b615  int3     
0079b616  int3     
0079b617  int3     
0079b618  int3     
0079b619  int3     
0079b61a  int3     
0079b61b  int3     
0079b61c  int3     
0079b61d  int3     
0079b61e  int3     
0079b61f  int3     

### String[] Enemy.Ene_BosBase::GetBossCD()  RVA=0x79B610 len=0x10
0079b610  xor      eax, eax
0079b612  ret      
0079b613  int3     
0079b614  int3     
0079b615  int3     
0079b616  int3     
0079b617  int3     
0079b618  int3     
0079b619  int3     
0079b61a  int3     
0079b61b  int3     
0079b61c  int3     
0079b61d  int3     
0079b61e  int3     
0079b61f  int3     

### Boolean Enemy.Ene_BosBase::UptoHpStep(Enemy.Ene_BosBase/HitPState)  RVA=0x1DBAE90 len=0x20
01dbae90  mov      eax, dword ptr [rcx + 0x21c]
01dbae96  cmp      eax, edx
01dbae98  mov      dword ptr [rcx + 0x21c], edx
01dbae9e  setl     al
01dbaea1  ret      
01dbaea2  int3     
01dbaea3  int3     
01dbaea4  int3     
01dbaea5  int3     
01dbaea6  int3     
01dbaea7  int3     
01dbaea8  int3     
01dbaea9  int3     
01dbaeaa  int3     
01dbaeab  int3     
01dbaeac  int3     
01dbaead  int3     
01dbaeae  int3     
01dbaeaf  int3     

### Boolean Enemy.Ene_BosBase::IsOverHP(Enemy.Ene_BosBase/HitPState)  RVA=0x1DB9FD0 len=0x10
01db9fd0  cmp      dword ptr [rcx + 0x21c], edx
01db9fd6  setge    al
01db9fd9  ret      
01db9fda  int3     
01db9fdb  int3     
01db9fdc  int3     
01db9fdd  int3     
01db9fde  int3     
01db9fdf  int3     

### Boolean Enemy.Ene_BosBase::IsOverStep(Enemy.Ene_BosBase/TimeSteps)  RVA=0x1DB9FE0 len=0x10
01db9fe0  cmp      dword ptr [rcx + 0x224], edx
01db9fe6  setge    al
01db9fe9  ret      
01db9fea  int3     
01db9feb  int3     
01db9fec  int3     
01db9fed  int3     
01db9fee  int3     
01db9fef  int3     

### Boolean Enemy.Ene_BosBase::IsOverAorB(Enemy.Ene_BosBase/HitPState,Enemy.Ene_BosBase/TimeSteps)  RVA=0x1DB9FB0 len=0x20
01db9fb0  cmp      dword ptr [rcx + 0x21c], edx
01db9fb6  jl       0x1db9fbb
01db9fb8  mov      al, 1
01db9fba  ret      
01db9fbb  cmp      dword ptr [rcx + 0x224], r8d
01db9fc2  setge    al
01db9fc5  ret      
01db9fc6  int3     
01db9fc7  int3     
01db9fc8  int3     
01db9fc9  int3     
01db9fca  int3     
01db9fcb  int3     
01db9fcc  int3     
01db9fcd  int3     
01db9fce  int3     
01db9fcf  int3     

### Void Enemy.Ene_BosBase::CountupBossTimer(Single)  RVA=0x1DB9460 len=0xF0
01db9460  push     rbx
01db9462  sub      rsp, 0x50
01db9466  movaps   xmmword ptr [rsp + 0x40], xmm6
01db946b  mov      rbx, rcx
01db946e  movaps   xmmword ptr [rsp + 0x30], xmm7
01db9473  movaps   xmm6, xmm1
01db9476  addss    xmm6, dword ptr [rcx + 0x1bc]
01db947e  xorps    xmm7, xmm7
01db9481  movaps   xmmword ptr [rsp + 0x20], xmm8
01db9487  movaps   xmm8, xmm1
01db948b  comiss   xmm7, xmm6
01db948e  ja       0x1db94a2
01db9490  movss    xmm0, dword ptr [rip + 0x1839a0c] ; [35f2ea4] f=86400.0 d=-281475051850752.0 v4=(86400.0, -120.0, -1920.0, 0.25)
01db9498  comiss   xmm6, xmm0
01db949b  jbe      0x1db94a5
01db949d  movaps   xmm6, xmm0
01db94a0  jmp      0x1db94a5
01db94a2  xorps    xmm6, xmm6
01db94a5  cmp      dword ptr [rcx + 0x224], 0x12
01db94ac  movss    dword ptr [rcx + 0x1bc], xmm6
01db94b4  je       0x1db9532
01db94b6  mov      rdx, qword ptr [rcx]
01db94b9  mov      rax, qword ptr [rdx + 0x698]
01db94c0  mov      rdx, qword ptr [rdx + 0x6a0]
01db94c7  call     rax
01db94c9  comiss   xmm6, xmm0
01db94cc  jae      0x1db9509
01db94ce  movss    xmm0, dword ptr [rbx + 0x1c0]
01db94d6  subss    xmm0, xmm8
01db94db  comiss   xmm7, xmm0
01db94de  movss    dword ptr [rbx + 0x1c0], xmm0
01db94e6  jb       0x1db9513
01db94e8  cmp      dword ptr [rbx + 0x224], 0x12
01db94ef  jge      0x1db951a
01db94f1  addss    xmm0, dword ptr [rip + 0x17276df] ; [34e0bd8] f=10.0 d=134217760.5625 v4=(10.0, 20.0, 57.29578, 100.0)
01db94f9  inc      dword ptr [rbx + 0x224]
01db94ff  movss    dword ptr [rbx + 0x1c0], xmm0
01db9507  jmp      0x1db9513
01db9509  mov      dword ptr [rbx + 0x224], 0x12
01db9513  cmp      dword ptr [rbx + 0x224], 0x12
01db951a  jne      0x1db9532
01db951c  mov      rdx, qword ptr [rbx]
01db951f  mov      rcx, rbx
01db9522  mov      rax, qword ptr [rdx + 0x6d8]
01db9529  mov      rdx, qword ptr [rdx + 0x6e0]
01db9530  call     rax
01db9532  movaps   xmm6, xmmword ptr [rsp + 0x40]
01db9537  movaps   xmm7, xmmword ptr [rsp + 0x30]
01db953c  movaps   xmm8, xmmword ptr [rsp + 0x20]
01db9542  add      rsp, 0x50
01db9546  pop      rbx
01db9547  ret      
01db9548  int3     
01db9549  int3     
01db954a  int3     
01db954b  int3     
01db954c  int3     
01db954d  int3     
01db954e  int3     
01db954f  int3     

### Boolean Enemy.Ene_BosBase::UpdateHPState()  RVA=0x1DBAD20 len=0xF0
01dbad20  mov      qword ptr [rsp + 8], rbx
01dbad25  mov      qword ptr [rsp + 0x10], rbp
01dbad2a  mov      qword ptr [rsp + 0x18], rsi
01dbad2f  push     rdi
01dbad30  sub      rsp, 0x30
01dbad34  cmp      byte ptr [rip + 0x28a8b42], 0 ; [466387d] bss
01dbad3b  mov      rsi, rcx
01dbad3e  movaps   xmmword ptr [rsp + 0x20], xmm6
01dbad43  jne      0x1dbad58
01dbad45  lea      rcx, [rip + 0x25f70fc] ; [43b1e48] TypeInfo#37321
01dbad4c  call     0x4e0a50 ; il2cpp_init_metadata
01dbad51  mov      byte ptr [rip + 0x28a8b25], 1 ; [466387d] bss
01dbad58  xor      edx, edx
01dbad5a  mov      rcx, rsi
01dbad5d  call     0x1de14e0 ; Single KANAI.HybridCollision.HybridCollisions::get_HitPointRate()
01dbad62  mov      rcx, qword ptr [rip + 0x25f70df] ; [43b1e48] TypeInfo#37321
01dbad69  xor      bpl, bpl
01dbad6c  xor      ebx, ebx
01dbad6e  movaps   xmm6, xmm0
01dbad71  mov      edi, 0x20
01dbad76  cmp      dword ptr [rcx + 0xe4], 0
01dbad7d  jne      0x1dbad8b
01dbad7f  call     0x4e0d90 ; il2cpp_class_init
01dbad84  mov      rcx, qword ptr [rip + 0x25f70bd] ; [43b1e48] TypeInfo#37321
01dbad8b  mov      rax, qword ptr [rcx + 0xb8]
01dbad92  cmp      ebx, dword ptr [rax + 8]
01dbad95  jge      0x1dbade0
01dbad97  cmp      dword ptr [rcx + 0xe4], 0
01dbad9e  jne      0x1dbadac
01dbada0  call     0x4e0d90 ; il2cpp_class_init
01dbada5  mov      rcx, qword ptr [rip + 0x25f709c] ; [43b1e48] TypeInfo#37321
01dbadac  mov      rax, qword ptr [rcx + 0xb8]
01dbadb3  mov      rdx, qword ptr [rax]
01dbadb6  test     rdx, rdx
01dbadb9  je       0x1dbadfe
01dbadbb  cmp      ebx, dword ptr [rdx + 0x18]
01dbadbe  jae      0x1dbae04
01dbadc0  comiss   xmm6, dword ptr [rdi + rdx]
01dbadc4  ja       0x1dbadce
01dbadc6  inc      ebx
01dbadc8  add      rdi, 4
01dbadcc  jmp      0x1dbad76
01dbadce  mov      eax, dword ptr [rsi + 0x21c]
01dbadd4  cmp      eax, ebx
01dbadd6  mov      dword ptr [rsi + 0x21c], ebx
01dbaddc  setl     bpl
01dbade0  mov      rbx, qword ptr [rsp + 0x40]
01dbade5  movzx    eax, bpl
01dbade9  mov      rbp, qword ptr [rsp + 0x48]
01dbadee  mov      rsi, qword ptr [rsp + 0x50]
01dbadf3  movaps   xmm6, xmmword ptr [rsp + 0x20]
01dbadf8  add      rsp, 0x30
01dbadfc  pop      rdi
01dbadfd  ret      
01dbadfe  call     0x4e0d00 ; ThrowNullRef
01dbae03  int3     
01dbae04  call     0x4e0cf0 ; ?
01dbae09  int3     
01dbae0a  int3     
01dbae0b  int3     
01dbae0c  int3     
01dbae0d  int3     
01dbae0e  int3     
01dbae0f  int3     

### Void Enemy.Ene_BosBase::_callDeadEffect()  RVA=0x1DBAEB0 len=0x140
01dbaeb0  push     rbx
01dbaeb2  sub      rsp, 0x30
01dbaeb6  cmp      byte ptr [rip + 0x28a89c1], 0 ; [466387e] bss
01dbaebd  mov      rbx, rcx
01dbaec0  jne      0x1dbaee1
01dbaec2  lea      rcx, [rip + 0x25fc6a7] ; [43b7570] MethodRef#202966
01dbaec9  call     0x4e0a50 ; il2cpp_init_metadata
01dbaece  lea      rcx, [rip + 0x25fd12b] ; [43b8000] MethodRef#202981
01dbaed5  call     0x4e0a50 ; il2cpp_init_metadata
01dbaeda  mov      byte ptr [rip + 0x28a899d], 1 ; [466387e] bss
01dbaee1  cmp      byte ptr [rbx + 0x1b3], 0
01dbaee8  jne      0x1dbafd9
01dbaeee  mov      rax, qword ptr [rip + 0x25fc67b] ; [43b7570] MethodRef#202966
01dbaef5  mov      rax, qword ptr [rax + 0x20]
01dbaef9  test     byte ptr [rax + 0x135], 1
01dbaf00  jne      0x1dbaf0a
01dbaf02  mov      rcx, rax
01dbaf05  call     0x4de1e0 ; ?
01dbaf0a  mov      rax, qword ptr [rax + 0xc0]
01dbaf11  mov      rax, qword ptr [rax + 0x10]
01dbaf15  test     byte ptr [rax + 0x135], 1
01dbaf1c  jne      0x1dbaf26
01dbaf1e  mov      rcx, rax
01dbaf21  call     0x4de1e0 ; ?
01dbaf26  mov      rax, qword ptr [rax + 0xb8]
01dbaf2d  mov      rcx, qword ptr [rax]
01dbaf30  test     rcx, rcx
01dbaf33  je       0x1dbaf56
01dbaf35  movss    xmm1, dword ptr [rip + 0x1725c8f] ; [34e0bcc] f=1.0 d=50.12387841939926 v4=(1.0, 3.141593, 4.0, 10.0)
01dbaf3d  movss    xmm2, dword ptr [rip + 0x17319cf] ; [34ec914] f=3.0 d=1.4411521567102075e+18 v4=(3.0, 360.0, inf, nan)
01dbaf45  movaps   xmm3, xmm1
01dbaf48  mov      qword ptr [rsp + 0x20], 0
01dbaf51  call     0x1cc6330 ; Void CinemachineMan::ShakeCamera(Single,Single,Single)
01dbaf56  mov      rax, qword ptr [rip + 0x25fd0a3] ; [43b8000] MethodRef#202981
01dbaf5d  mov      rax, qword ptr [rax + 0x20]
01dbaf61  test     byte ptr [rax + 0x135], 1
01dbaf68  jne      0x1dbaf72
01dbaf6a  mov      rcx, rax
01dbaf6d  call     0x4de1e0 ; ?
01dbaf72  mov      rax, qword ptr [rax + 0xc0]
01dbaf79  mov      rax, qword ptr [rax + 0x10]
01dbaf7d  test     byte ptr [rax + 0x135], 1
01dbaf84  jne      0x1dbaf8e
01dbaf86  mov      rcx, rax
01dbaf89  call     0x4de1e0 ; ?
01dbaf8e  mov      rax, qword ptr [rax + 0xb8]
01dbaf95  mov      rcx, qword ptr [rax]
01dbaf98  test     rcx, rcx
01dbaf9b  je       0x1dbafdf
01dbaf9d  movss    xmm3, dword ptr [rip + 0x1731a67] ; [34eca0c] f=2.0 d=5.304989477e-315 v4=(2.0, 0.0, 2.0, 6.283185)
01dbafa5  movss    xmm2, dword ptr [rip + 0x1837d1b] ; [35f2cc8] f=0.800000011920929 d=0.003671875684085535 v4=(0.8, 0.93, 0.95, 0.999999)
01dbafad  movss    xmm1, dword ptr [rip + 0x1725c13] ; [34e0bc8] f=0.5 d=0.007812501833541319 v4=(0.5, 1.0, 3.141593, 4.0)
01dbafb5  mov      qword ptr [rsp + 0x20], 0
01dbafbe  call     0x1cee560 ; Void InGameManager::VibrationPlayer(Single,Single,Single)
01dbafc3  xor      edx, edx
01dbafc5  mov      byte ptr [rbx + 0x1b3], 1
01dbafcc  mov      rcx, rbx
01dbafcf  add      rsp, 0x30
01dbafd3  pop      rbx
01dbafd4  jmp      0x1d10e20 ; Void Enemy.PawnEnemy::_callDeadEffect()
01dbafd9  add      rsp, 0x30
01dbafdd  pop      rbx
01dbafde  ret      
01dbafdf  call     0x4e0d00 ; ThrowNullRef
01dbafe4  int3     
01dbafe5  int3     
01dbafe6  int3     
01dbafe7  int3     
01dbafe8  int3     
01dbafe9  int3     
01dbafea  int3     
01dbafeb  int3     
01dbafec  int3     
01dbafed  int3     
01dbafee  int3     
01dbafef  int3     

### Void Enemy.Ene_BosBase::ToDestroidVib()  RVA=0x1DBABC0 len=0xA0
01dbabc0  push     rbx
01dbabc2  sub      rsp, 0x30
01dbabc6  cmp      byte ptr [rip + 0x28a8cb2], 0 ; [466387f] bss
01dbabcd  mov      rbx, rcx
01dbabd0  jne      0x1dbabf1
01dbabd2  lea      rcx, [rip + 0x25fd2bf] ; [43b7e98] MethodRef#202979
01dbabd9  call     0x4e0a50 ; il2cpp_init_metadata
01dbabde  lea      rcx, [rip + 0x25fd41b] ; [43b8000] MethodRef#202981
01dbabe5  call     0x4e0a50 ; il2cpp_init_metadata
01dbabea  mov      byte ptr [rip + 0x28a8c8e], 1 ; [466387f] bss
01dbabf1  cmp      byte ptr [rbx + 0x1b0], 0
01dbabf8  jne      0x1dbac4b
01dbabfa  mov      rcx, qword ptr [rip + 0x25fd297] ; [43b7e98] MethodRef#202979
01dbac01  call     0xd102f0 ; Boolean KANAI.Kernel.MonoBehaviourSingleton`1::IsInstanceNull() || Boolean KANAI.Kernel.SimpleSingleton`1::IsInstanceNull()
01dbac06  test     al, al
01dbac08  jne      0x1dbac44
01dbac0a  mov      rcx, qword ptr [rip + 0x25fd3ef] ; [43b8000] MethodRef#202981
01dbac11  call     0x27540 ; ?
01dbac16  test     rax, rax
01dbac19  je       0x1dbac51
01dbac1b  movss    xmm3, dword ptr [rip + 0x1731de9] ; [34eca0c] f=2.0 d=5.304989477e-315 v4=(2.0, 0.0, 2.0, 6.283185)
01dbac23  mov      rcx, rax
01dbac26  movss    xmm2, dword ptr [rip + 0x1725f9e] ; [34e0bcc] f=1.0 d=50.12387841939926 v4=(1.0, 3.141593, 4.0, 10.0)
01dbac2e  movss    xmm1, dword ptr [rip + 0x1838092] ; [35f2cc8] f=0.800000011920929 d=0.003671875684085535 v4=(0.8, 0.93, 0.95, 0.999999)
01dbac36  mov      qword ptr [rsp + 0x20], 0
01dbac3f  call     0x1cee560 ; Void InGameManager::VibrationPlayer(Single,Single,Single)
01dbac44  mov      byte ptr [rbx + 0x1b0], 1
01dbac4b  add      rsp, 0x30
01dbac4f  pop      rbx
01dbac50  ret      
01dbac51  call     0x4e0d00 ; ThrowNullRef
01dbac56  int3     
01dbac57  int3     
01dbac58  int3     
01dbac59  int3     
01dbac5a  int3     
01dbac5b  int3     
01dbac5c  int3     
01dbac5d  int3     
01dbac5e  int3     
01dbac5f  int3     

### Void Enemy.Ene_BosBase::TimeupAction()  RVA=0x5BCDB0 len=0x10
005bcdb0  ret      0
005bcdb3  int3     
005bcdb4  int3     
005bcdb5  int3     
005bcdb6  int3     
005bcdb7  int3     
005bcdb8  int3     
005bcdb9  int3     
005bcdba  int3     
005bcdbb  int3     
005bcdbc  int3     
005bcdbd  int3     
005bcdbe  int3     
005bcdbf  int3     

### Int32 Enemy.Ene_BosBase::GetBonusTimeKind()  RVA=0x79B610 len=0x10
0079b610  xor      eax, eax
0079b612  ret      
0079b613  int3     
0079b614  int3     
0079b615  int3     
0079b616  int3     
0079b617  int3     
0079b618  int3     
0079b619  int3     
0079b61a  int3     
0079b61b  int3     
0079b61c  int3     
0079b61d  int3     
0079b61e  int3     
0079b61f  int3     

### Void Enemy.Ene_BosBase::ToDestroid()  RVA=0x1DBAC60 len=0xC0
01dbac60  push     rbx
01dbac62  sub      rsp, 0x30
01dbac66  mov      rdx, qword ptr [rcx]
01dbac69  mov      rbx, rcx
01dbac6c  mov      rax, qword ptr [rdx + 0x1b8]
01dbac73  mov      rdx, qword ptr [rdx + 0x1c0]
01dbac7a  call     rax
01dbac7c  test     al, al
01dbac7e  jne      0x1dbad05
01dbac84  cmp      byte ptr [rip + 0x28a8bf5], al ; [466387f] bss
01dbac8a  jne      0x1dbacab
01dbac8c  lea      rcx, [rip + 0x25fd205] ; [43b7e98] MethodRef#202979
01dbac93  call     0x4e0a50 ; il2cpp_init_metadata
01dbac98  lea      rcx, [rip + 0x25fd361] ; [43b8000] MethodRef#202981
01dbac9f  call     0x4e0a50 ; il2cpp_init_metadata
01dbaca4  mov      byte ptr [rip + 0x28a8bd4], 1 ; [466387f] bss
01dbacab  cmp      byte ptr [rbx + 0x1b0], 0
01dbacb2  jne      0x1dbad05
01dbacb4  mov      rcx, qword ptr [rip + 0x25fd1dd] ; [43b7e98] MethodRef#202979
01dbacbb  call     0xd102f0 ; Boolean KANAI.Kernel.MonoBehaviourSingleton`1::IsInstanceNull() || Boolean KANAI.Kernel.SimpleSingleton`1::IsInstanceNull()
01dbacc0  test     al, al
01dbacc2  jne      0x1dbacfe
01dbacc4  mov      rcx, qword ptr [rip + 0x25fd335] ; [43b8000] MethodRef#202981
01dbaccb  call     0x27540 ; ?
01dbacd0  test     rax, rax
01dbacd3  je       0x1dbad14
01dbacd5  movss    xmm3, dword ptr [rip + 0x1731d2f] ; [34eca0c] f=2.0 d=5.304989477e-315 v4=(2.0, 0.0, 2.0, 6.283185)
01dbacdd  mov      rcx, rax
01dbace0  movss    xmm2, dword ptr [rip + 0x1725ee4] ; [34e0bcc] f=1.0 d=50.12387841939926 v4=(1.0, 3.141593, 4.0, 10.0)
01dbace8  movss    xmm1, dword ptr [rip + 0x1837fd8] ; [35f2cc8] f=0.800000011920929 d=0.003671875684085535 v4=(0.8, 0.93, 0.95, 0.999999)
01dbacf0  mov      qword ptr [rsp + 0x20], 0
01dbacf9  call     0x1cee560 ; Void InGameManager::VibrationPlayer(Single,Single,Single)
01dbacfe  mov      byte ptr [rbx + 0x1b0], 1
01dbad05  xor      edx, edx
01dbad07  mov      rcx, rbx
01dbad0a  add      rsp, 0x30
01dbad0e  pop      rbx
01dbad0f  jmp      0x1d108c0 ; Void Enemy.PawnEnemy::ToDestroid()
01dbad14  call     0x4e0d00 ; ThrowNullRef
01dbad19  int3     
01dbad1a  int3     
01dbad1b  int3     
01dbad1c  int3     
01dbad1d  int3     
01dbad1e  int3     
01dbad1f  int3     

### Boolean Enemy.Ene_BosBase::IsGamePlayArea()  RVA=0x1DB9F90 len=0x20
01db9f90  cmp      byte ptr [rcx + 0x1b0], 0
01db9f97  je       0x1db9fad
01db9f99  mov      rdx, qword ptr [rcx]
01db9f9c  mov      rax, qword ptr [rdx + 0x1b8]
01db9fa3  mov      rdx, qword ptr [rdx + 0x1c0]
01db9faa  jmp      rax
01db9fad  mov      al, 1
01db9faf  ret      

### Void Enemy.Ene_BosBase::SkyExplosionEffect(Int32,Vector3,Int32,TXEKernel.Sound.SoundUtility/ID)  RVA=0x1DBA5C0 len=0x1D0
01dba5c0  mov      qword ptr [rsp + 0x10], rbx
01dba5c5  mov      qword ptr [rsp + 0x18], rbp
01dba5ca  mov      qword ptr [rsp + 0x20], rsi
01dba5cf  push     r14
01dba5d1  sub      rsp, 0x70
01dba5d5  cmp      byte ptr [rip + 0x28a92a4], 0 ; [4663880] bss
01dba5dc  mov      ebp, r9d
01dba5df  mov      rsi, r8
01dba5e2  mov      r14d, edx
01dba5e5  jne      0x1dba606
01dba5e7  lea      rcx, [rip + 0x25fda12] ; [43b8000] MethodRef#202981
01dba5ee  call     0x4e0a50 ; il2cpp_init_metadata
01dba5f3  lea      rcx, [rip + 0x25e7d6e] ; [43a2368] TypeInfo#45781
01dba5fa  call     0x4e0a50 ; il2cpp_init_metadata
01dba5ff  mov      byte ptr [rip + 0x28a927a], 1 ; [4663880] bss
01dba606  mov      rax, qword ptr [rip + 0x25fd9f3] ; [43b8000] MethodRef#202981
01dba60d  mov      rax, qword ptr [rax + 0x20]
01dba611  test     byte ptr [rax + 0x135], 1
01dba618  jne      0x1dba622
01dba61a  mov      rcx, rax
01dba61d  call     0x4de1e0 ; ?
01dba622  mov      rax, qword ptr [rax + 0xc0]
01dba629  mov      rax, qword ptr [rax + 0x10]
01dba62d  test     byte ptr [rax + 0x135], 1
01dba634  jne      0x1dba63e
01dba636  mov      rcx, rax
01dba639  call     0x4de1e0 ; ?
01dba63e  mov      rax, qword ptr [rax + 0xb8]
01dba645  mov      qword ptr [rsp + 0x80], rdi
01dba64d  mov      rbx, qword ptr [rax]
01dba650  test     rbx, rbx
01dba653  je       0x1dba77d
01dba659  mov      rdi, qword ptr [rbx + 0x98]
01dba660  test     rdi, rdi
01dba663  je       0x1dba77d
01dba669  movsd    xmm0, qword ptr [rsi]
01dba66d  lea      r8, [rsp + 0x50]
01dba672  mov      eax, dword ptr [rsi + 8]
01dba675  lea      rcx, [rsp + 0x60]
01dba67a  xor      r9d, r9d
01dba67d  movsd    qword ptr [rsp + 0x50], xmm0
01dba683  mov      rdx, rdi
01dba686  mov      dword ptr [rsp + 0x58], eax
01dba68a  call     0x308ea00 ; Vector3 Transform::InverseTransformPoint(Vector3)
01dba68f  cmp      byte ptr [rip + 0x28a1dc7], 0 ; [465c45d] bss
01dba696  mov      rsi, qword ptr [rbx + 0x108]
01dba69d  movsd    xmm1, qword ptr [rax]
01dba6a1  mov      ebx, dword ptr [rax + 8]
01dba6a4  movsd    qword ptr [rsp + 0x50], xmm1
01dba6aa  jne      0x1dba6c5
01dba6ac  lea      rcx, [rip + 0x2607025] ; [43c16d8] TypeInfo#48704
01dba6b3  call     0x4e0a50 ; il2cpp_init_metadata
01dba6b8  movsd    xmm1, qword ptr [rsp + 0x50]
01dba6be  mov      byte ptr [rip + 0x28a1d98], 1 ; [465c45d] bss
01dba6c5  mov      rax, qword ptr [rip + 0x260700c] ; [43c16d8] TypeInfo#48704
01dba6cc  mov      rax, qword ptr [rax + 0xb8]
01dba6d3  test     rsi, rsi
01dba6d6  je       0x1dba77d
01dba6dc  movsd    xmm0, qword ptr [rax]
01dba6e0  mov      r9d, ebp
01dba6e3  mov      eax, dword ptr [rax + 8]
01dba6e6  mov      r8d, r14d
01dba6e9  mov      dword ptr [rsp + 0x58], eax
01dba6ed  mov      rdx, rdi
01dba6f0  mov      qword ptr [rsp + 0x40], 0
01dba6f9  mov      rcx, rsi
01dba6fc  mov      dword ptr [rsp + 0x68], ebx
01dba700  mov      ebx, dword ptr [rsp + 0xa0]
01dba707  cmp      ebx, -1
01dba70a  movsd    qword ptr [rsp + 0x50], xmm0
01dba710  sete     al
01dba713  movsd    qword ptr [rsp + 0x60], xmm1
01dba719  mov      byte ptr [rsp + 0x38], al
01dba71d  lea      rax, [rsp + 0x50]
01dba722  mov      byte ptr [rsp + 0x30], 0
01dba727  mov      qword ptr [rsp + 0x28], rax
01dba72c  lea      rax, [rsp + 0x60]
01dba731  mov      qword ptr [rsp + 0x20], rax
01dba736  call     0x1cd0040 ; Void InGameEffectManager::ExplosionQue(Transform,Int32,Int32,Vector3,Vector3,Boolean,Boolean)
01dba73b  cmp      ebx, -1
01dba73e  je       0x1dba75e
01dba740  mov      rcx, qword ptr [rip + 0x25e7c21] ; [43a2368] TypeInfo#45781
01dba747  cmp      dword ptr [rcx + 0xe4], 0
01dba74e  jne      0x1dba755
01dba750  call     0x4e0d90 ; il2cpp_class_init
01dba755  xor      edx, edx
01dba757  mov      ecx, ebx
01dba759  call     0x2723de0 ; Void TXEKernel.Sound.SoundUtility::PlayQue(TXEKernel.Sound.SoundUtility/ID)
01dba75e  mov      rdi, qword ptr [rsp + 0x80]
01dba766  lea      r11, [rsp + 0x70]
01dba76b  mov      rbx, qword ptr [r11 + 0x18]
01dba76f  mov      rbp, qword ptr [r11 + 0x20]
01dba773  mov      rsi, qword ptr [r11 + 0x28]
01dba777  mov      rsp, r11
01dba77a  pop      r14
01dba77c  ret      
01dba77d  call     0x4e0d00 ; ThrowNullRef
01dba782  int3     
01dba783  int3     
01dba784  int3     
01dba785  int3     
01dba786  int3     
01dba787  int3     
01dba788  int3     
01dba789  int3     
01dba78a  int3     
01dba78b  int3     
01dba78c  int3     
01dba78d  int3     
01dba78e  int3     
01dba78f  int3     

### Void Enemy.Ene_BosBase::SetSmallBombSecond(Single)  RVA=0x1DBA5A0 len=0x20
01dba5a0  movss    dword ptr [rcx + 0x1e0], xmm1
01dba5a8  mov      dword ptr [rcx + 0x1e4], 0
01dba5b2  ret      
01dba5b3  int3     
01dba5b4  int3     
01dba5b5  int3     
01dba5b6  int3     
01dba5b7  int3     
01dba5b8  int3     
01dba5b9  int3     
01dba5ba  int3     
01dba5bb  int3     
01dba5bc  int3     
01dba5bd  int3     
01dba5be  int3     
01dba5bf  int3     

### Boolean Enemy.Ene_BosBase::IsCallSmallBomb(Single)  RVA=0x1DB9E90 len=0xF0
01db9e90  push     rbx
01db9e92  sub      rsp, 0x40
01db9e96  cmp      byte ptr [rip + 0x28a99e4], 0 ; [4663881] bss
01db9e9d  mov      rbx, rcx
01db9ea0  movaps   xmmword ptr [rsp + 0x30], xmm6
01db9ea5  movaps   xmm6, xmm1
01db9ea8  jne      0x1db9ebd
01db9eaa  lea      rcx, [rip + 0x25fe14f] ; [43b8000] MethodRef#202981
01db9eb1  call     0x4e0a50 ; il2cpp_init_metadata
01db9eb6  mov      byte ptr [rip + 0x28a99c4], 1 ; [4663881] bss
01db9ebd  movss    xmm2, dword ptr [rbx + 0x1e4]
01db9ec5  xorps    xmm0, xmm0
01db9ec8  subss    xmm2, xmm6
01db9ecc  comiss   xmm0, xmm2
01db9ecf  movss    dword ptr [rbx + 0x1e4], xmm2
01db9ed7  jae      0x1db9ee6
01db9ed9  xor      al, al
01db9edb  movaps   xmm6, xmmword ptr [rsp + 0x30]
01db9ee0  add      rsp, 0x40
01db9ee4  pop      rbx
01db9ee5  ret      
01db9ee6  xor      ecx, ecx
01db9ee8  call     0x1df1220 ; Single KANAI.Kernel.RandomUtility::Make01()
01db9eed  cmp      byte ptr [rbx + 0x1b3], 0
01db9ef4  movss    xmm6, dword ptr [rip + 0x1726d28] ; [34e0c24] f=0.10000000149011612 d=1.0681151189828597e-05 v4=(0.1, 0.45, 0.0, 0.0)
01db9efc  mulss    xmm0, xmm6
01db9f00  addss    xmm0, dword ptr [rbx + 0x1e0]
01db9f08  movss    dword ptr [rbx + 0x1e4], xmm0
01db9f10  movss    xmm0, dword ptr [rbx + 0x1e0]
01db9f18  mulss    xmm0, dword ptr [rip + 0x1838e48] ; [35f2d68] f=0.8999999761581421 d=-6047314991513.6 v4=(0.9, -75.0, -400.0, 0.03)
01db9f20  movss    dword ptr [rbx + 0x1e0], xmm0
01db9f28  jne      0x1db9f5f
01db9f2a  mov      rcx, qword ptr [rip + 0x25fe0cf] ; [43b8000] MethodRef#202981
01db9f31  call     0x27540 ; ?
01db9f36  test     rax, rax
01db9f39  je       0x1db9f6c
01db9f3b  movss    xmm3, dword ptr [rbx + 0x1e0]
01db9f43  movaps   xmm2, xmm6
01db9f46  movss    xmm1, dword ptr [rip + 0x1838e32] ; [35f2d80] f=0.4000000059604645 d=0.00020214848282193998 v4=(0.4, 0.666, 1.2, 1.8)
01db9f4e  mov      rcx, rax
01db9f51  mov      qword ptr [rsp + 0x20], 0
01db9f5a  call     0x1cee560 ; Void InGameManager::VibrationPlayer(Single,Single,Single)
01db9f5f  movaps   xmm6, xmmword ptr [rsp + 0x30]
01db9f64  mov      al, 1
01db9f66  add      rsp, 0x40
01db9f6a  pop      rbx
01db9f6b  ret      
01db9f6c  call     0x4e0d00 ; ThrowNullRef
01db9f71  int3     
01db9f72  int3     
01db9f73  int3     
01db9f74  int3     
01db9f75  int3     
01db9f76  int3     
01db9f77  int3     
01db9f78  int3     
01db9f79  int3     
01db9f7a  int3     
01db9f7b  int3     
01db9f7c  int3     
01db9f7d  int3     
01db9f7e  int3     
01db9f7f  int3     

### Vector3 Enemy.Ene_BosBase::GetSmallBombPosition()  RVA=0x1D11D20 len=0x40
01d11d20  push     rbx
01d11d22  sub      rsp, 0x30
01d11d26  mov      rdx, qword ptr [rdx + 0x50]
01d11d2a  mov      rbx, rcx
01d11d2d  test     rdx, rdx
01d11d30  je       0x1d11d56
01d11d32  xor      r8d, r8d
01d11d35  lea      rcx, [rsp + 0x20]
01d11d3a  call     0x3093ba0 ; Vector3 Transform::get_position()
01d11d3f  movsd    xmm0, qword ptr [rax]
01d11d43  mov      eax, dword ptr [rax + 8]
01d11d46  movsd    qword ptr [rbx], xmm0
01d11d4a  mov      dword ptr [rbx + 8], eax
01d11d4d  mov      rax, rbx
01d11d50  add      rsp, 0x30
01d11d54  pop      rbx
01d11d55  ret      
01d11d56  call     0x4e0d00 ; ThrowNullRef
01d11d5b  int3     
01d11d5c  int3     
01d11d5d  int3     
01d11d5e  int3     
01d11d5f  int3     

### Void Enemy.Ene_BosBase::SetDirectionTime(Single,Single)  RVA=0x1DBA4D0 len=0x20
01dba4d0  movss    dword ptr [rcx + 0x1c4], xmm1
01dba4d8  movss    dword ptr [rcx + 0x1cc], xmm2
01dba4e0  mov      dword ptr [rcx + 0x1c8], 0
01dba4ea  ret      
01dba4eb  int3     
01dba4ec  int3     
01dba4ed  int3     
01dba4ee  int3     
01dba4ef  int3     

### Void Enemy.Ene_BosBase::SetDirectionScale(Single)  RVA=0x1DBA4C0 len=0x10
01dba4c0  movss    dword ptr [rcx + 0x1cc], xmm1
01dba4c8  ret      
01dba4c9  int3     
01dba4ca  int3     
01dba4cb  int3     
01dba4cc  int3     
01dba4cd  int3     
01dba4ce  int3     
01dba4cf  int3     

### Single Enemy.Ene_BosBase::GetDirectionRate()  RVA=0x1DB9A20 len=0x40
01db9a20  movss    xmm1, dword ptr [rcx + 0x1c4]
01db9a28  xorps    xmm2, xmm2
01db9a2b  comiss   xmm1, xmm2
01db9a2e  jbe      0x1db9a52
01db9a30  movss    xmm0, dword ptr [rcx + 0x1c8]
01db9a38  divss    xmm0, xmm1
01db9a3c  comiss   xmm2, xmm0
01db9a3f  ja       0x1db9a52
01db9a41  movss    xmm1, dword ptr [rip + 0x1727183] ; [34e0bcc] f=1.0 d=50.12387841939926 v4=(1.0, 3.141593, 4.0, 10.0)
01db9a49  comiss   xmm0, xmm1
01db9a4c  jbe      0x1db9a55
01db9a4e  movaps   xmm0, xmm1
01db9a51  ret      
01db9a52  xorps    xmm0, xmm0
01db9a55  ret      
01db9a56  int3     
01db9a57  int3     
01db9a58  int3     
01db9a59  int3     
01db9a5a  int3     
01db9a5b  int3     
01db9a5c  int3     
01db9a5d  int3     
01db9a5e  int3     
01db9a5f  int3     

### Void Enemy.Ene_BosBase::SetDirectionPause(Boolean)  RVA=0x1DBA4B0 len=0x10
01dba4b0  mov      byte ptr [rcx + 0x1b4], dl
01dba4b6  ret      
01dba4b7  int3     
01dba4b8  int3     
01dba4b9  int3     
01dba4ba  int3     
01dba4bb  int3     
01dba4bc  int3     
01dba4bd  int3     
01dba4be  int3     
01dba4bf  int3     

### Void Enemy.Ene_BosBase::SetRepeatTime(Single)  RVA=0x1DBA580 len=0x20
01dba580  xor      eax, eax
01dba582  movss    dword ptr [rcx + 0x1d0], xmm1
01dba58a  mov      qword ptr [rcx + 0x1d4], rax
01dba591  mov      byte ptr [rcx + 0x1dc], al
01dba597  ret      
01dba598  int3     
01dba599  int3     
01dba59a  int3     
01dba59b  int3     
01dba59c  int3     
01dba59d  int3     
01dba59e  int3     
01dba59f  int3     

### Void Enemy.Ene_BosBase::AddRepeatTime(Single)  RVA=0x1DB8EC0 len=0xA0
01db8ec0  push     rbx
01db8ec2  sub      rsp, 0x50
01db8ec6  movss    xmm0, dword ptr [rcx + 0x1d0]
01db8ece  mov      rbx, rcx
01db8ed1  movaps   xmmword ptr [rsp + 0x40], xmm6
01db8ed6  movaps   xmm6, xmm1
01db8ed9  movaps   xmmword ptr [rsp + 0x20], xmm8
01db8edf  xorps    xmm8, xmm8
01db8ee3  comiss   xmm0, xmm8
01db8ee7  jbe      0x1db8f4b
01db8ee9  addss    xmm6, dword ptr [rcx + 0x1d4]
01db8ef1  comiss   xmm6, xmm0
01db8ef4  movss    dword ptr [rcx + 0x1d4], xmm6
01db8efc  setae    al
01db8eff  mov      byte ptr [rcx + 0x1dc], al
01db8f05  test     al, al
01db8f07  je       0x1db8f4b
01db8f09  movaps   xmmword ptr [rsp + 0x30], xmm7
01db8f0e  movaps   xmm7, xmm0
01db8f11  movaps   xmm0, xmm6
01db8f14  divss    xmm0, xmm7
01db8f18  call     0x578740 ; ?
01db8f1d  mulss    xmm0, xmm7
01db8f21  subss    xmm6, xmm0
01db8f25  comiss   xmm8, xmm6
01db8f29  ja       0x1db8f35
01db8f2b  comiss   xmm6, xmm7
01db8f2e  jbe      0x1db8f38
01db8f30  movaps   xmm6, xmm7
01db8f33  jmp      0x1db8f38
01db8f35  xorps    xmm6, xmm6
01db8f38  inc      dword ptr [rbx + 0x1d8]
01db8f3e  movaps   xmm7, xmmword ptr [rsp + 0x30]
01db8f43  movss    dword ptr [rbx + 0x1d4], xmm6
01db8f4b  movaps   xmm6, xmmword ptr [rsp + 0x40]
01db8f50  movaps   xmm8, xmmword ptr [rsp + 0x20]
01db8f56  add      rsp, 0x50
01db8f5a  pop      rbx
01db8f5b  ret      
01db8f5c  int3     
01db8f5d  int3     
01db8f5e  int3     
01db8f5f  int3     

### Single Enemy.Ene_BosBase::GetRepeatRate()  RVA=0x1DB9A60 len=0x30
01db9a60  movss    xmm0, dword ptr [rcx + 0x1d4]
01db9a68  xorps    xmm1, xmm1
01db9a6b  divss    xmm0, dword ptr [rcx + 0x1d0]
01db9a73  comiss   xmm1, xmm0
01db9a76  ja       0x1db9a89
01db9a78  movss    xmm1, dword ptr [rip + 0x172714c] ; [34e0bcc] f=1.0 d=50.12387841939926 v4=(1.0, 3.141593, 4.0, 10.0)
01db9a80  comiss   xmm0, xmm1
01db9a83  jbe      0x1db9a8c
01db9a85  movaps   xmm0, xmm1
01db9a88  ret      
01db9a89  xorps    xmm0, xmm0
01db9a8c  ret      
01db9a8d  int3     
01db9a8e  int3     
01db9a8f  int3     

### Void Enemy.Ene_BosBase::SetLoopCount(Int32)  RVA=0x1DBA500 len=0x30
01dba500  mov      qword ptr [rsp + 8], rbx
01dba505  push     rdi
01dba506  sub      rsp, 0x20
01dba50a  mov      rdi, rcx
01dba50d  mov      ebx, edx
01dba50f  xor      ecx, ecx
01dba511  call     0x1df1350 ; Int32 KANAI.Kernel.RandomUtility::Make()
01dba516  cdq      
01dba517  idiv     ebx
01dba519  mov      rbx, qword ptr [rsp + 0x30]
01dba51e  inc      edx
01dba520  mov      dword ptr [rdi + 0x1e8], edx
01dba526  add      rsp, 0x20
01dba52a  pop      rdi
01dba52b  ret      
01dba52c  int3     
01dba52d  int3     
01dba52e  int3     
01dba52f  int3     

### Void Enemy.Ene_BosBase::SetLoopCountDirect(Int32)  RVA=0x1DBA4F0 len=0x10
01dba4f0  mov      dword ptr [rcx + 0x1e8], edx
01dba4f6  ret      
01dba4f7  int3     
01dba4f8  int3     
01dba4f9  int3     
01dba4fa  int3     
01dba4fb  int3     
01dba4fc  int3     
01dba4fd  int3     
01dba4fe  int3     
01dba4ff  int3     

### Void Enemy.Ene_BosBase::SetLoopCount(Int32,Int32)  RVA=0x1DBA530 len=0x40
01dba530  mov      qword ptr [rsp + 8], rbx
01dba535  mov      qword ptr [rsp + 0x10], rsi
01dba53a  push     rdi
01dba53b  sub      rsp, 0x20
01dba53f  mov      rsi, rcx
01dba542  mov      ebx, r8d
01dba545  xor      ecx, ecx
01dba547  mov      edi, edx
01dba549  call     0x1df1350 ; Int32 KANAI.Kernel.RandomUtility::Make()
01dba54e  cdq      
01dba54f  sub      ebx, edi
01dba551  idiv     ebx
01dba553  mov      rbx, qword ptr [rsp + 0x30]
01dba558  lea      eax, [rdi + 1]
01dba55b  add      eax, edx
01dba55d  mov      dword ptr [rsi + 0x1e8], eax
01dba563  mov      rsi, qword ptr [rsp + 0x38]
01dba568  add      rsp, 0x20
01dba56c  pop      rdi
01dba56d  ret      
01dba56e  int3     
01dba56f  int3     

### Boolean Enemy.Ene_BosBase::IsAttackLoop()  RVA=0x1DB9E60 len=0x30
01db9e60  mov      eax, dword ptr [rcx + 0x1e8]
01db9e66  dec      eax
01db9e68  mov      dword ptr [rcx + 0x1e8], eax
01db9e6e  test     eax, eax
01db9e70  jle      0x1db9e75
01db9e72  mov      al, 1
01db9e74  ret      
01db9e75  mov      dword ptr [rcx + 0x1e8], 0
01db9e7f  xor      al, al
01db9e81  ret      
01db9e82  int3     
01db9e83  int3     
01db9e84  int3     
01db9e85  int3     
01db9e86  int3     
01db9e87  int3     
01db9e88  int3     
01db9e89  int3     
01db9e8a  int3     
01db9e8b  int3     
01db9e8c  int3     
01db9e8d  int3     
01db9e8e  int3     
01db9e8f  int3     

### Void Enemy.Ene_BosBase::ConsumeAttackLoop(Int32)  RVA=0x1DB93F0 len=0x70
01db93f0  mov      qword ptr [rsp + 8], rbx
01db93f5  mov      qword ptr [rsp + 0x10], rsi
01db93fa  push     rdi
01db93fb  sub      rsp, 0x20
01db93ff  cmp      byte ptr [rip + 0x28aa47c], 0 ; [4663882] bss
01db9406  mov      esi, edx
01db9408  mov      rdi, rcx
01db940b  jne      0x1db9420
01db940d  lea      rcx, [rip + 0x25b97b4] ; [4372bc8] TypeInfo#41713
01db9414  call     0x4e0a50 ; il2cpp_init_metadata
01db9419  mov      byte ptr [rip + 0x28aa462], 1 ; [4663882] bss
01db9420  mov      rcx, qword ptr [rip + 0x25b97a1] ; [4372bc8] TypeInfo#41713
01db9427  mov      ebx, dword ptr [rdi + 0x1e8]
01db942d  cmp      dword ptr [rcx + 0xe4], 0
01db9434  jne      0x1db943b
01db9436  call     0x4e0d90 ; il2cpp_class_init
01db943b  sub      ebx, esi
01db943d  xor      r8d, r8d
01db9440  mov      edx, ebx
01db9442  xor      ecx, ecx
01db9444  call     0x202aa40 ; Int32 Math::Max(Int32,Int32)
01db9449  mov      rbx, qword ptr [rsp + 0x30]
01db944e  mov      rsi, qword ptr [rsp + 0x38]
01db9453  mov      dword ptr [rdi + 0x1e8], eax
01db9459  add      rsp, 0x20
01db945d  pop      rdi
01db945e  ret      
01db945f  int3     

### Int32 Enemy.Ene_BosBase::AttackLoopCount()  RVA=0x1DB8F60 len=0x10
01db8f60  mov      eax, dword ptr [rcx + 0x1e8]
01db8f66  ret      
01db8f67  int3     
01db8f68  int3     
01db8f69  int3     
01db8f6a  int3     
01db8f6b  int3     
01db8f6c  int3     
01db8f6d  int3     
01db8f6e  int3     
01db8f6f  int3     

### Void Enemy.Ene_BosBase::SetOldState()  RVA=0x1DBA570 len=0x10
01dba570  mov      eax, dword ptr [rcx + 0x21c]
01dba576  mov      dword ptr [rcx + 0x220], eax
01dba57c  ret      
01dba57d  int3     
01dba57e  int3     
01dba57f  int3     

### Boolean Enemy.Ene_BosBase::IsChangeHpState()  RVA=0x1DB9F80 len=0x10
01db9f80  mov      eax, dword ptr [rcx + 0x21c]
01db9f86  cmp      dword ptr [rcx + 0x220], eax
01db9f8c  setne    al
01db9f8f  ret      

### Cysharp.Threading.Tasks.UniTask Enemy.Ene_BosBase::ChangeBaseColor(Boolean,Color,Single,Single)  RVA=0x1DB91A0 len=0x120
01db91a0  mov      qword ptr [rsp + 8], rbx
01db91a5  mov      qword ptr [rsp + 0x10], rbp
01db91aa  mov      qword ptr [rsp + 0x18], rsi
01db91af  push     rdi
01db91b0  sub      rsp, 0x90
01db91b7  cmp      byte ptr [rip + 0x28aa6c5], 0 ; [4663883] bss
01db91be  mov      rsi, r9
01db91c1  movzx    ebp, r8b
01db91c5  mov      rbx, rdx
01db91c8  mov      rdi, rcx
01db91cb  jne      0x1db91e0
01db91cd  lea      rcx, [rip + 0x25eb7c4] ; [43a4998] MethodRef#179826
01db91d4  call     0x4e0a50 ; il2cpp_init_metadata
01db91d9  mov      byte ptr [rip + 0x28aa6a3], 1 ; [4663883] bss
01db91e0  xorps    xmm0, xmm0
01db91e3  lea      rcx, [rsp + 0x38]
01db91e8  xor      eax, eax
01db91ea  xor      edx, edx
01db91ec  movups   xmmword ptr [rsp + 0x30], xmm0
01db91f1  mov      qword ptr [rsp + 0x80], rax
01db91f9  movups   xmmword ptr [rsp + 0x40], xmm0
01db91fe  movups   xmmword ptr [rsp + 0x38], xmm0
01db9203  movups   xmmword ptr [rsp + 0x50], xmm0
01db9208  movups   xmmword ptr [rsp + 0x60], xmm0
01db920d  movups   xmmword ptr [rsp + 0x70], xmm0
01db9212  call     0x4dfd80 ; ?
01db9217  mov      rdx, rbx
01db921a  mov      qword ptr [rsp + 0x48], rbx
01db921f  lea      rcx, [rsp + 0x48]
01db9224  call     0x4dfd80 ; ?
01db9229  movups   xmm0, xmmword ptr [rsi]
01db922c  mov      rbx, qword ptr [rip + 0x25eb765] ; [43a4998] MethodRef#179826
01db9233  movss    xmm1, dword ptr [rsp + 0xc0]
01db923c  movups   xmmword ptr [rsp + 0x5c], xmm0
01db9241  mov      byte ptr [rsp + 0x58], bpl
01db9246  movss    xmm0, dword ptr [rsp + 0xc8]
01db924f  movss    dword ptr [rsp + 0x50], xmm0
01db9255  movss    dword ptr [rsp + 0x54], xmm1
01db925b  mov      dword ptr [rsp + 0x30], 0xffffffff
01db9263  cmp      qword ptr [rbx + 0x38], 0
01db9268  jne      0x1db9272
01db926a  mov      rcx, rbx
01db926d  call     0x4de260 ; ?
01db9272  mov      rdx, qword ptr [rbx + 0x38]
01db9276  lea      rcx, [rsp + 0x30]
01db927b  mov      rdx, qword ptr [rdx + 0x10]
01db927f  call     0x1dd0930 ; Void Enemy.Ene_BosBase/<ChangeBaseColor>d__47::MoveNext()
01db9284  xor      r8d, r8d
01db9287  lea      rdx, [rsp + 0x38]
01db928c  lea      rcx, [rsp + 0x20]
01db9291  call     0x71b540 ; ?
01db9296  lea      r11, [rsp + 0x90]
01db929e  mov      rbx, qword ptr [r11 + 0x10]
01db92a2  mov      rbp, qword ptr [r11 + 0x18]
01db92a6  movups   xmm0, xmmword ptr [rax]
01db92a9  mov      rsi, qword ptr [r11 + 0x20]
01db92ad  mov      rax, rdi
01db92b0  movups   xmmword ptr [rdi], xmm0
01db92b3  mov      rsp, r11
01db92b6  pop      rdi
01db92b7  ret      
01db92b8  int3     
01db92b9  int3     
01db92ba  int3     
01db92bb  int3     
01db92bc  int3     
01db92bd  int3     
01db92be  int3     
01db92bf  int3     

### Void Enemy.Ene_BosBase::ChangeDarkMode(Boolean,Single,Single)  RVA=0x1DB9320 len=0xD0
01db9320  mov      qword ptr [rsp + 8], rbx
01db9325  push     rdi
01db9326  sub      rsp, 0x80
01db932d  cmp      byte ptr [rip + 0x28aa550], 0 ; [4663884] bss
01db9334  movzx    ebx, dl
01db9337  movaps   xmmword ptr [rsp + 0x70], xmm6
01db933c  mov      rdi, rcx
01db933f  movaps   xmmword ptr [rsp + 0x60], xmm7
01db9344  movaps   xmm6, xmm3
01db9347  movaps   xmm7, xmm2
01db934a  jne      0x1db935f
01db934c  lea      rcx, [rip + 0x25c960d] ; [4382960] TypeInfo#43058
01db9353  call     0x4e0a50 ; il2cpp_init_metadata
01db9358  mov      byte ptr [rip + 0x28aa525], 1 ; [4663884] bss
01db935f  mov      rax, qword ptr [rip + 0x25c95fa] ; [4382960] TypeInfo#43058
01db9366  cmp      dword ptr [rax + 0xe4], 0
01db936d  jne      0x1db937e
01db936f  mov      rcx, rax
01db9372  call     0x4e0d90 ; il2cpp_class_init
01db9377  mov      rax, qword ptr [rip + 0x25c95e2] ; [4382960] TypeInfo#43058
01db937e  mov      rax, qword ptr [rax + 0xb8]
01db9385  lea      r9, [rsp + 0x40]
01db938a  mov      qword ptr [rsp + 0x30], 0
01db9393  lea      rcx, [rsp + 0x50]
01db9398  movss    dword ptr [rsp + 0x28], xmm6
01db939e  movzx    r8d, bl
01db93a2  mov      rdx, rdi
01db93a5  movss    dword ptr [rsp + 0x20], xmm7
01db93ab  movups   xmm0, xmmword ptr [rax + 0x20]
01db93af  movaps   xmmword ptr [rsp + 0x40], xmm0
01db93b4  call     0x1db91a0 ; Cysharp.Threading.Tasks.UniTask Enemy.Ene_BosBase::ChangeBaseColor(Boolean,Color,Single,Single)
01db93b9  xor      edx, edx
01db93bb  lea      rcx, [rsp + 0x40]
01db93c0  movups   xmm0, xmmword ptr [rax]
01db93c3  movaps   xmmword ptr [rsp + 0x40], xmm0
01db93c8  call     0x2742890 ; Void Cysharp.Threading.Tasks.UniTaskExtensions::Forget(Cysharp.Threading.Tasks.UniTask)
01db93cd  mov      rbx, qword ptr [rsp + 0x90]
01db93d5  movaps   xmm6, xmmword ptr [rsp + 0x70]
01db93da  movaps   xmm7, xmmword ptr [rsp + 0x60]
01db93df  add      rsp, 0x80
01db93e6  pop      rdi
01db93e7  ret      
01db93e8  int3     
01db93e9  int3     
01db93ea  int3     
01db93eb  int3     
01db93ec  int3     
01db93ed  int3     
01db93ee  int3     
01db93ef  int3     

### Void Enemy.Ene_BosBase::ChangeColorMode(Boolean,Color,Single,Single)  RVA=0x1DB92C0 len=0x60
01db92c0  sub      rsp, 0x68
01db92c4  movups   xmm0, xmmword ptr [r8]
01db92c8  lea      r9, [rsp + 0x40]
01db92cd  movzx    r8d, dl
01db92d1  movss    xmm1, dword ptr [rsp + 0x90]
01db92da  mov      rdx, rcx
01db92dd  mov      qword ptr [rsp + 0x30], 0
01db92e6  lea      rcx, [rsp + 0x50]
01db92eb  movss    dword ptr [rsp + 0x28], xmm1
01db92f1  movaps   xmmword ptr [rsp + 0x40], xmm0
01db92f6  movss    dword ptr [rsp + 0x20], xmm3
01db92fc  call     0x1db91a0 ; Cysharp.Threading.Tasks.UniTask Enemy.Ene_BosBase::ChangeBaseColor(Boolean,Color,Single,Single)
01db9301  xor      edx, edx
01db9303  lea      rcx, [rsp + 0x40]
01db9308  movups   xmm0, xmmword ptr [rax]
01db930b  movaps   xmmword ptr [rsp + 0x40], xmm0
01db9310  call     0x2742890 ; Void Cysharp.Threading.Tasks.UniTaskExtensions::Forget(Cysharp.Threading.Tasks.UniTask)
01db9315  add      rsp, 0x68
01db9319  ret      
01db931a  int3     
01db931b  int3     
01db931c  int3     
01db931d  int3     
01db931e  int3     
01db931f  int3     

### Cysharp.Threading.Tasks.UniTask Enemy.Ene_BosBase::DamageTurn(Quaternion,Single,Action)  RVA=0x1DB9720 len=0x120
01db9720  mov      qword ptr [rsp + 8], rbx
01db9725  mov      qword ptr [rsp + 0x10], rsi
01db972a  push     rdi
01db972b  sub      rsp, 0xb0
01db9732  cmp      byte ptr [rip + 0x28aa14c], 0 ; [4663885] bss
01db9739  mov      rsi, r8
01db973c  movaps   xmmword ptr [rsp + 0xa0], xmm6
01db9744  mov      rbx, rdx
01db9747  movaps   xmm6, xmm3
01db974a  mov      rdi, rcx
01db974d  jne      0x1db9762
01db974f  lea      rcx, [rip + 0x25eb2fa] ; [43a4a50] MethodRef#179827
01db9756  call     0x4e0a50 ; il2cpp_init_metadata
01db975b  mov      byte ptr [rip + 0x28aa123], 1 ; [4663885] bss
01db9762  xorps    xmm0, xmm0
01db9765  lea      rcx, [rsp + 0x38]
01db976a  xor      eax, eax
01db976c  xor      edx, edx
01db976e  movups   xmmword ptr [rsp + 0x30], xmm0
01db9773  mov      qword ptr [rsp + 0x90], rax
01db977b  movups   xmmword ptr [rsp + 0x40], xmm0
01db9780  movups   xmmword ptr [rsp + 0x38], xmm0
01db9785  movups   xmmword ptr [rsp + 0x50], xmm0
01db978a  movups   xmmword ptr [rsp + 0x60], xmm0
01db978f  movups   xmmword ptr [rsp + 0x70], xmm0
01db9794  movups   xmmword ptr [rsp + 0x80], xmm0
01db979c  call     0x4dfd80 ; ?
01db97a1  mov      rdx, rbx
01db97a4  mov      qword ptr [rsp + 0x48], rbx
01db97a9  lea      rcx, [rsp + 0x48]
01db97ae  call     0x4dfd80 ; ?
01db97b3  movups   xmm0, xmmword ptr [rsi]
01db97b6  mov      rdx, qword ptr [rsp + 0xe0]
01db97be  lea      rcx, [rsp + 0x68]
01db97c3  movss    dword ptr [rsp + 0x60], xmm6
01db97c9  movaps   xmmword ptr [rsp + 0x50], xmm0
01db97ce  mov      qword ptr [rsp + 0x68], rdx
01db97d3  call     0x4dfd80 ; ?
01db97d8  mov      rbx, qword ptr [rip + 0x25eb271] ; [43a4a50] MethodRef#179827
01db97df  mov      dword ptr [rsp + 0x30], 0xffffffff
01db97e7  cmp      qword ptr [rbx + 0x38], 0
01db97ec  jne      0x1db97f6
01db97ee  mov      rcx, rbx
01db97f1  call     0x4de260 ; ?
01db97f6  mov      rdx, qword ptr [rbx + 0x38]
01db97fa  lea      rcx, [rsp + 0x30]
01db97ff  mov      rdx, qword ptr [rdx + 0x10]
01db9803  call     0x1dd0e40 ; Void Enemy.Ene_BosBase/<DamageTurn>d__50::MoveNext()
01db9808  xor      r8d, r8d
01db980b  lea      rdx, [rsp + 0x38]
01db9810  lea      rcx, [rsp + 0x20]
01db9815  call     0x71b540 ; ?
01db981a  lea      r11, [rsp + 0xb0]
01db9822  mov      rbx, qword ptr [r11 + 0x10]
01db9826  mov      rsi, qword ptr [r11 + 0x18]
01db982a  movups   xmm0, xmmword ptr [rax]
01db982d  mov      rax, rdi
01db9830  movaps   xmm6, xmmword ptr [r11 - 0x10]
01db9835  movups   xmmword ptr [rdi], xmm0
01db9838  mov      rsp, r11
01db983b  pop      rdi
01db983c  ret      
01db983d  int3     
01db983e  int3     
01db983f  int3     

### Boolean Enemy.Ene_BosBase::get_IsDamageTurned()  RVA=0x1DBB170 len=0x10
01dbb170  movzx    eax, byte ptr [rcx + 0x1b1]
01dbb177  ret      
01dbb178  int3     
01dbb179  int3     
01dbb17a  int3     
01dbb17b  int3     
01dbb17c  int3     
01dbb17d  int3     
01dbb17e  int3     
01dbb17f  int3     

### Boolean Enemy.Ene_BosBase::get_IsDeadEffectCalled()  RVA=0x1DBB180 len=0x10
01dbb180  movzx    eax, byte ptr [rcx + 0x1b3]
01dbb187  ret      
01dbb188  int3     
01dbb189  int3     
01dbb18a  int3     
01dbb18b  int3     
01dbb18c  int3     
01dbb18d  int3     
01dbb18e  int3     
01dbb18f  int3     

### Boolean Enemy.Ene_BosBase::get_IsPlayerSideLeft()  RVA=0x1DBB1D0 len=0x10
01dbb1d0  movzx    eax, byte ptr [rcx + 0x1b5]
01dbb1d7  ret      
01dbb1d8  int3     
01dbb1d9  int3     
01dbb1da  int3     
01dbb1db  int3     
01dbb1dc  int3     
01dbb1dd  int3     
01dbb1de  int3     
01dbb1df  int3     

### Boolean Enemy.Ene_BosBase::get_IsPlayerSideRight()  RVA=0x1DBB1E0 len=0x10
01dbb1e0  cmp      byte ptr [rcx + 0x1b5], 0
01dbb1e7  sete     al
01dbb1ea  ret      
01dbb1eb  int3     
01dbb1ec  int3     
01dbb1ed  int3     
01dbb1ee  int3     
01dbb1ef  int3     

### Boolean Enemy.Ene_BosBase::get_IsPlayerSideDown()  RVA=0x1DBB1C0 len=0x10
01dbb1c0  movzx    eax, byte ptr [rcx + 0x1b6]
01dbb1c7  ret      
01dbb1c8  int3     
01dbb1c9  int3     
01dbb1ca  int3     
01dbb1cb  int3     
01dbb1cc  int3     
01dbb1cd  int3     
01dbb1ce  int3     
01dbb1cf  int3     

### Boolean Enemy.Ene_BosBase::get_IsPlayerSideCenter()  RVA=0x1DBB1B0 len=0x10
01dbb1b0  movzx    eax, byte ptr [rcx + 0x1b7]
01dbb1b7  ret      
01dbb1b8  int3     
01dbb1b9  int3     
01dbb1ba  int3     
01dbb1bb  int3     
01dbb1bc  int3     
01dbb1bd  int3     
01dbb1be  int3     
01dbb1bf  int3     

### Boolean Enemy.Ene_BosBase::get_IsPlayerSideBottom()  RVA=0x1D39AB0 len=0x10
01d39ab0  movzx    eax, byte ptr [rcx + 0x1b8]
01d39ab7  ret      
01d39ab8  int3     
01d39ab9  int3     
01d39aba  int3     
01d39abb  int3     
01d39abc  int3     
01d39abd  int3     
01d39abe  int3     
01d39abf  int3     

### Single Enemy.Ene_BosBase::get_BossAliveTime()  RVA=0x1DBB130 len=0x10
01dbb130  movss    xmm0, dword ptr [rcx + 0x1bc]
01dbb138  ret      
01dbb139  int3     
01dbb13a  int3     
01dbb13b  int3     
01dbb13c  int3     
01dbb13d  int3     
01dbb13e  int3     
01dbb13f  int3     

### Int32 Enemy.Ene_BosBase::get_RepeatTimes()  RVA=0x1DBB2B0 len=0x10
01dbb2b0  mov      eax, dword ptr [rcx + 0x1d8]
01dbb2b6  ret      
01dbb2b7  int3     
01dbb2b8  int3     
01dbb2b9  int3     
01dbb2ba  int3     
01dbb2bb  int3     
01dbb2bc  int3     
01dbb2bd  int3     
01dbb2be  int3     
01dbb2bf  int3     

### Boolean Enemy.Ene_BosBase::get_IsRepeatLaped()  RVA=0x1DBB1F0 len=0x10
01dbb1f0  movzx    eax, byte ptr [rcx + 0x1dc]
01dbb1f7  ret      
01dbb1f8  int3     
01dbb1f9  int3     
01dbb1fa  int3     
01dbb1fb  int3     
01dbb1fc  int3     
01dbb1fd  int3     
01dbb1fe  int3     
01dbb1ff  int3     

### Vector3 Enemy.Ene_BosBase::get_BaseTargetSkyPosition()  RVA=0x1DBB110 len=0x20
01dbb110  mov      eax, dword ptr [rdx + 0x1f8]
01dbb116  movsd    xmm0, qword ptr [rdx + 0x1f0]
01dbb11e  movsd    qword ptr [rcx], xmm0
01dbb122  mov      dword ptr [rcx + 8], eax
01dbb125  mov      rax, rcx
01dbb128  ret      
01dbb129  int3     
01dbb12a  int3     
01dbb12b  int3     
01dbb12c  int3     
01dbb12d  int3     
01dbb12e  int3     
01dbb12f  int3     

### Int32 Enemy.Ene_BosBase::get__enemyDataCount()  RVA=0x1DBB2E0 len=0x10
01dbb2e0  mov      eax, dword ptr [rcx + 0x1fc]
01dbb2e6  ret      
01dbb2e7  int3     
01dbb2e8  int3     
01dbb2e9  int3     
01dbb2ea  int3     
01dbb2eb  int3     
01dbb2ec  int3     
01dbb2ed  int3     
01dbb2ee  int3     
01dbb2ef  int3     

### Void Enemy.Ene_BosBase::set__enemyDataCount(Int32)  RVA=0x1D17FD0 len=0x10
01d17fd0  mov      dword ptr [rcx + 0x1fc], edx
01d17fd6  ret      
01d17fd7  int3     
01d17fd8  int3     
01d17fd9  int3     
01d17fda  int3     
01d17fdb  int3     
01d17fdc  int3     
01d17fdd  int3     
01d17fde  int3     
01d17fdf  int3     

### Boolean Enemy.Ene_BosBase::get_IsEasyMode()  RVA=0x1DBB190 len=0x20
01dbb190  cmp      dword ptr [rcx + 0x210], 1
01dbb197  jne      0x1dbb19c
01dbb199  mov      al, 1
01dbb19b  ret      
01dbb19c  cmp      dword ptr [rcx + 0x210], 0x64
01dbb1a3  sete     al
01dbb1a6  ret      
01dbb1a7  int3     
01dbb1a8  int3     
01dbb1a9  int3     
01dbb1aa  int3     
01dbb1ab  int3     
01dbb1ac  int3     
01dbb1ad  int3     
01dbb1ae  int3     
01dbb1af  int3     

### Boolean Enemy.Ene_BosBase::get_IsStoryMode()  RVA=0x1DBB260 len=0x10
01dbb260  cmp      dword ptr [rcx + 0x210], 1
01dbb267  sete     al
01dbb26a  ret      
01dbb26b  int3     
01dbb26c  int3     
01dbb26d  int3     
01dbb26e  int3     
01dbb26f  int3     

### Boolean Enemy.Ene_BosBase::get_IsTutorial()  RVA=0x1DBB2A0 len=0x10
01dbb2a0  cmp      dword ptr [rcx + 0x210], 0x64
01dbb2a7  sete     al
01dbb2aa  ret      
01dbb2ab  int3     
01dbb2ac  int3     
01dbb2ad  int3     
01dbb2ae  int3     
01dbb2af  int3     

### Boolean Enemy.Ene_BosBase::get_IsTrophy()  RVA=0x1DBB280 len=0x20
01dbb280  cmp      dword ptr [rcx + 0x210], 0x64
01dbb287  jne      0x1dbb28c
01dbb289  xor      al, al
01dbb28b  ret      
01dbb28c  cmp      byte ptr [rcx + 0x218], 0
01dbb293  sete     al
01dbb296  ret      
01dbb297  int3     
01dbb298  int3     
01dbb299  int3     
01dbb29a  int3     
01dbb29b  int3     
01dbb29c  int3     
01dbb29d  int3     
01dbb29e  int3     
01dbb29f  int3     

### Boolean Enemy.Ene_BosBase::get_IsStoryA()  RVA=0x1DBB200 len=0x20
01dbb200  cmp      dword ptr [rcx + 0x210], 1
01dbb207  je       0x1dbb20c
01dbb209  xor      al, al
01dbb20b  ret      
01dbb20c  cmp      dword ptr [rcx + 0x214], 0
01dbb213  sete     al
01dbb216  ret      
01dbb217  int3     
01dbb218  int3     
01dbb219  int3     
01dbb21a  int3     
01dbb21b  int3     
01dbb21c  int3     
01dbb21d  int3     
01dbb21e  int3     
01dbb21f  int3     

### Boolean Enemy.Ene_BosBase::get_IsStoryB()  RVA=0x1DBB220 len=0x20
01dbb220  cmp      dword ptr [rcx + 0x210], 1
01dbb227  je       0x1dbb22c
01dbb229  xor      al, al
01dbb22b  ret      
01dbb22c  cmp      dword ptr [rcx + 0x214], 1
01dbb233  sete     al
01dbb236  ret      
01dbb237  int3     
01dbb238  int3     
01dbb239  int3     
01dbb23a  int3     
01dbb23b  int3     
01dbb23c  int3     
01dbb23d  int3     
01dbb23e  int3     
01dbb23f  int3     

### Boolean Enemy.Ene_BosBase::get_IsStoryC()  RVA=0x1DBB240 len=0x20
01dbb240  cmp      dword ptr [rcx + 0x210], 1
01dbb247  je       0x1dbb24c
01dbb249  xor      al, al
01dbb24b  ret      
01dbb24c  cmp      dword ptr [rcx + 0x214], 2
01dbb253  sete     al
01dbb256  ret      
01dbb257  int3     
01dbb258  int3     
01dbb259  int3     
01dbb25a  int3     
01dbb25b  int3     
01dbb25c  int3     
01dbb25d  int3     
01dbb25e  int3     
01dbb25f  int3     

### Boolean Enemy.Ene_BosBase::get_IsArcade()  RVA=0x1DBB160 len=0x10
01dbb160  cmp      dword ptr [rcx + 0x210], 2
01dbb167  sete     al
01dbb16a  ret      
01dbb16b  int3     
01dbb16c  int3     
01dbb16d  int3     
01dbb16e  int3     
01dbb16f  int3     

### Boolean Enemy.Ene_BosBase::get_IsTeam()  RVA=0x1DBB270 len=0x10
01dbb270  cmp      dword ptr [rcx + 0x210], 0xa
01dbb277  sete     al
01dbb27a  ret      
01dbb27b  int3     
01dbb27c  int3     
01dbb27d  int3     
01dbb27e  int3     
01dbb27f  int3     

### TXEKernel.PlayActor Enemy.Ene_BosBase::get_GetPlayActor()  RVA=0x1DBB140 len=0x10
01dbb140  mov      eax, dword ptr [rcx + 0x214]
01dbb146  ret      
01dbb147  int3     
01dbb148  int3     
01dbb149  int3     
01dbb14a  int3     
01dbb14b  int3     
01dbb14c  int3     
01dbb14d  int3     
01dbb14e  int3     
01dbb14f  int3     

### Enemy.Ene_BosBase/HitPState Enemy.Ene_BosBase::get_HpState()  RVA=0x1DBB150 len=0x10
01dbb150  mov      eax, dword ptr [rcx + 0x21c]
01dbb156  ret      
01dbb157  int3     
01dbb158  int3     
01dbb159  int3     
01dbb15a  int3     
01dbb15b  int3     
01dbb15c  int3     
01dbb15d  int3     
01dbb15e  int3     
01dbb15f  int3     

### Vector3 Enemy.Ene_BosBase::get_StartInGamePosition()  RVA=0x1DBB2C0 len=0x20
01dbb2c0  mov      eax, dword ptr [rdx + 0x230]
01dbb2c6  movsd    xmm0, qword ptr [rdx + 0x228]
01dbb2ce  movsd    qword ptr [rcx], xmm0
01dbb2d2  mov      dword ptr [rcx + 8], eax
01dbb2d5  mov      rax, rcx
01dbb2d8  ret      
01dbb2d9  int3     
01dbb2da  int3     
01dbb2db  int3     
01dbb2dc  int3     
01dbb2dd  int3     
01dbb2de  int3     
01dbb2df  int3     

### Vector3 Enemy.Ene_BosBase::CurrentTargetVector(Single,KANAI.Kernel.EasingUtility/EasingType)  RVA=0x1DB9630 len=0xF0
01db9630  mov      qword ptr [rsp + 8], rbx
01db9635  mov      qword ptr [rsp + 0x10], rsi
01db963a  push     rdi
01db963b  sub      rsp, 0x60
01db963f  movaps   xmmword ptr [rsp + 0x50], xmm6
01db9644  mov      rbx, rcx
01db9647  movss    xmm6, dword ptr [rip + 0x172757d] ; [34e0bcc] f=1.0 d=50.12387841939926 v4=(1.0, 3.141593, 4.0, 10.0)
01db964f  movaps   xmmword ptr [rsp + 0x40], xmm7
01db9654  xorps    xmm7, xmm7
01db9657  comiss   xmm7, xmm2
01db965a  ja       0x1db9666
01db965c  comiss   xmm2, xmm6
01db965f  jbe      0x1db9669
01db9661  movaps   xmm2, xmm6
01db9664  jmp      0x1db9669
01db9666  xorps    xmm2, xmm2
01db9669  movsd    xmm1, qword ptr [rdx + 0x240]
01db9671  xor      r8d, r8d
01db9674  mov      edi, dword ptr [rdx + 0x248]
01db967a  movaps   xmm0, xmm2
01db967d  mov      esi, dword ptr [rdx + 0x23c]
01db9683  movsd    qword ptr [rsp + 0x20], xmm1
01db9689  movsd    xmm1, qword ptr [rdx + 0x234]
01db9691  mov      edx, r9d
01db9694  movsd    qword ptr [rsp + 0x30], xmm1
01db969a  call     0x1de8100 ; Single KANAI.Kernel.EasingUtility::Easing01(Single,KANAI.Kernel.EasingUtility/EasingType)
01db969f  comiss   xmm7, xmm0
01db96a2  movaps   xmm4, xmm0
01db96a5  ja       0x1db96b1
01db96a7  comiss   xmm0, xmm6
01db96aa  jbe      0x1db96b4
01db96ac  movaps   xmm4, xmm6
01db96af  jmp      0x1db96b4
01db96b1  xorps    xmm4, xmm4
01db96b4  movss    xmm3, dword ptr [rsp + 0x20]
01db96ba  subss    xmm3, dword ptr [rsp + 0x30]
01db96c0  movss    xmm1, dword ptr [rsp + 0x24]
01db96c6  subss    xmm1, dword ptr [rsp + 0x34]
01db96cc  movd     xmm0, esi
01db96d0  movd     xmm2, edi
01db96d4  subss    xmm2, xmm0
01db96d8  mulss    xmm3, xmm4
01db96dc  mulss    xmm1, xmm4
01db96e0  addss    xmm3, dword ptr [rsp + 0x30]
01db96e6  mulss    xmm2, xmm4
01db96ea  addss    xmm1, dword ptr [rsp + 0x34]
01db96f0  addss    xmm2, xmm0
01db96f4  mov      rsi, qword ptr [rsp + 0x78]
01db96f9  mov      rax, rbx
01db96fc  movaps   xmm6, xmmword ptr [rsp + 0x50]
01db9701  movaps   xmm7, xmmword ptr [rsp + 0x40]
01db9706  unpcklps xmm3, xmm1
01db9709  movsd    qword ptr [rbx], xmm3
01db970d  movss    dword ptr [rbx + 8], xmm2
01db9712  mov      rbx, qword ptr [rsp + 0x70]
01db9717  add      rsp, 0x60
01db971b  pop      rdi
01db971c  ret      
01db971d  int3     
01db971e  int3     
01db971f  int3     

### Quaternion Enemy.Ene_BosBase::CurrentTargetAngle(Single)  RVA=0x1DB95C0 len=0x70
01db95c0  push     rbx
01db95c2  sub      rsp, 0x60
01db95c6  xorps    xmm0, xmm0
01db95c9  mov      rbx, rcx
01db95cc  comiss   xmm0, xmm2
01db95cf  ja       0x1db95e3
01db95d1  movss    xmm0, dword ptr [rip + 0x17275f3] ; [34e0bcc] f=1.0 d=50.12387841939926 v4=(1.0, 3.141593, 4.0, 10.0)
01db95d9  comiss   xmm2, xmm0
01db95dc  jbe      0x1db95e6
01db95de  movaps   xmm2, xmm0
01db95e1  jmp      0x1db95e6
01db95e3  xorps    xmm2, xmm2
01db95e6  movups   xmm0, xmmword ptr [rdx + 0x25c]
01db95ed  lea      r8, [rsp + 0x30]
01db95f2  mov      qword ptr [rsp + 0x20], 0
01db95fb  movups   xmm1, xmmword ptr [rdx + 0x24c]
01db9602  lea      rdx, [rsp + 0x40]
01db9607  movaps   xmm3, xmm2
01db960a  movaps   xmmword ptr [rsp + 0x30], xmm0
01db960f  lea      rcx, [rsp + 0x50]
01db9614  movaps   xmmword ptr [rsp + 0x40], xmm1
01db9619  call     0x304dab0 ; Quaternion Quaternion::Internal_Lerp(Quaternion&,Quaternion&,Single)
01db961e  movups   xmm0, xmmword ptr [rax]
01db9621  mov      rax, rbx
01db9624  movups   xmmword ptr [rbx], xmm0
01db9627  add      rsp, 0x60
01db962b  pop      rbx
01db962c  ret      
01db962d  int3     
01db962e  int3     
01db962f  int3     

### Quaternion Enemy.Ene_BosBase::CurrentTargetAngleSlerp(Single)  RVA=0x1DB9550 len=0x70
01db9550  push     rbx
01db9552  sub      rsp, 0x60
01db9556  xorps    xmm0, xmm0
01db9559  mov      rbx, rcx
01db955c  comiss   xmm0, xmm2
01db955f  ja       0x1db9573
01db9561  movss    xmm0, dword ptr [rip + 0x1727663] ; [34e0bcc] f=1.0 d=50.12387841939926 v4=(1.0, 3.141593, 4.0, 10.0)
01db9569  comiss   xmm2, xmm0
01db956c  jbe      0x1db9576
01db956e  movaps   xmm2, xmm0
01db9571  jmp      0x1db9576
01db9573  xorps    xmm2, xmm2
01db9576  movups   xmm0, xmmword ptr [rdx + 0x25c]
01db957d  lea      r8, [rsp + 0x30]
01db9582  mov      qword ptr [rsp + 0x20], 0
01db958b  movups   xmm1, xmmword ptr [rdx + 0x24c]
01db9592  lea      rdx, [rsp + 0x40]
01db9597  movaps   xmm3, xmm2
01db959a  movaps   xmmword ptr [rsp + 0x30], xmm0
01db959f  lea      rcx, [rsp + 0x50]
01db95a4  movaps   xmmword ptr [rsp + 0x40], xmm1
01db95a9  call     0x304ddc0 ; Quaternion Quaternion::Internal_Slerp(Quaternion&,Quaternion&,Single)
01db95ae  movups   xmm0, xmmword ptr [rax]
01db95b1  mov      rax, rbx
01db95b4  movups   xmmword ptr [rbx], xmm0
01db95b7  add      rsp, 0x60
01db95bb  pop      rbx
01db95bc  ret      
01db95bd  int3     
01db95be  int3     
01db95bf  int3     

### Void Enemy.Ene_BosBase::.ctor()  RVA=0x1DBB0B0 len=0x60
01dbb0b0  push     rbx
01dbb0b2  sub      rsp, 0x20
01dbb0b6  cmp      byte ptr [rip + 0x28a87c9], 0 ; [4663886] bss
01dbb0bd  mov      rbx, rcx
01dbb0c0  jne      0x1dbb0d5
01dbb0c2  lea      rcx, [rip + 0x25c7897] ; [4382960] TypeInfo#43058
01dbb0c9  call     0x4e0a50 ; il2cpp_init_metadata
01dbb0ce  mov      byte ptr [rip + 0x28a87b1], 1 ; [4663886] bss
01dbb0d5  mov      dword ptr [rbx + 0x1cc], 0x3f800000
01dbb0df  mov      dword ptr [rbx + 0x214], 0xffffffff
01dbb0e9  mov      rcx, qword ptr [rip + 0x25c7870] ; [4382960] TypeInfo#43058
01dbb0f0  cmp      dword ptr [rcx + 0xe4], 0
01dbb0f7  jne      0x1dbb0fe
01dbb0f9  call     0x4e0d90 ; il2cpp_class_init
01dbb0fe  xor      edx, edx
01dbb100  mov      rcx, rbx
01dbb103  add      rsp, 0x20
01dbb107  pop      rbx
01dbb108  jmp      0x1d11520 ; Void Enemy.PawnEnemy::.ctor()
01dbb10d  int3     
01dbb10e  int3     
01dbb10f  int3     

### Void Enemy.Ene_BosBase::.cctor()  RVA=0x1DBAFF0 len=0xC0
01dbaff0  push     rbx
01dbaff2  sub      rsp, 0x20
01dbaff6  cmp      byte ptr [rip + 0x28a888a], 0 ; [4663887] bss
01dbaffd  jne      0x1dbb02a
01dbafff  lea      rcx, [rip + 0x25f6e42] ; [43b1e48] TypeInfo#37321
01dbb006  call     0x4e0a50 ; il2cpp_init_metadata
01dbb00b  lea      rcx, [rip + 0x25b7396] ; [43723a8] TypeInfo#31993
01dbb012  call     0x4e0a50 ; il2cpp_init_metadata
01dbb017  lea      rcx, [rip + 0x25d88ba] ; [43938d8] Field#11
01dbb01e  call     0x4e0a50 ; il2cpp_init_metadata
01dbb023  mov      byte ptr [rip + 0x28a885d], 1 ; [4663887] bss
01dbb02a  mov      rcx, qword ptr [rip + 0x25b7377] ; [43723a8] TypeInfo#31993
01dbb031  mov      edx, 8
01dbb036  call     0x4dfe00 ; ?
01dbb03b  mov      rdx, qword ptr [rip + 0x25d8896] ; [43938d8] Field#11
01dbb042  xor      r8d, r8d
01dbb045  mov      rcx, rax
01dbb048  mov      rbx, rax
01dbb04b  call     0x1f40520 ; Void Runtime.CompilerServices.RuntimeHelpers::InitializeArray(Array,RuntimeFieldHandle)
01dbb050  mov      rcx, qword ptr [rip + 0x25f6df1] ; [43b1e48] TypeInfo#37321
01dbb057  mov      rdx, qword ptr [rcx + 0xb8]
01dbb05e  mov      qword ptr [rdx], rbx
01dbb061  mov      rdx, rbx
01dbb064  mov      rcx, qword ptr [rip + 0x25f6ddd] ; [43b1e48] TypeInfo#37321
01dbb06b  mov      rcx, qword ptr [rcx + 0xb8]
01dbb072  call     0x4dfd80 ; ?
01dbb077  mov      rcx, qword ptr [rip + 0x25f6dca] ; [43b1e48] TypeInfo#37321
01dbb07e  mov      rax, qword ptr [rcx + 0xb8]
01dbb085  mov      rax, qword ptr [rax]
01dbb088  test     rax, rax
01dbb08b  je       0x1dbb0a0
01dbb08d  mov      rcx, qword ptr [rcx + 0xb8]
01dbb094  mov      eax, dword ptr [rax + 0x18]
01dbb097  mov      dword ptr [rcx + 8], eax
01dbb09a  add      rsp, 0x20
01dbb09e  pop      rbx
01dbb09f  ret      
01dbb0a0  call     0x4e0d00 ; ThrowNullRef
01dbb0a5  int3     
01dbb0a6  int3     
01dbb0a7  int3     
01dbb0a8  int3     
01dbb0a9  int3     
01dbb0aa  int3     
01dbb0ab  int3     
01dbb0ac  int3     
01dbb0ad  int3     
01dbb0ae  int3     
01dbb0af  int3     

