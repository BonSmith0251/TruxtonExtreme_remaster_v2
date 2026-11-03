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

### Void Enemy.Ene_Bos07/LegArcs::.ctor(Single,Single,Single)  RVA=0x1DB7900 len=0x10
01db7900  movss    dword ptr [rcx], xmm1
01db7904  movss    dword ptr [rcx + 4], xmm2
01db7909  movss    dword ptr [rcx + 8], xmm3
01db790e  ret      
01db790f  int3     

### Single Enemy.Ene_Bos07/LegArcs::get_thigh()  RVA=0x6640D0 len=0x10
006640d0  movss    xmm0, dword ptr [rcx]
006640d4  ret      
006640d5  int3     
006640d6  int3     
006640d7  int3     
006640d8  int3     
006640d9  int3     
006640da  int3     
006640db  int3     
006640dc  int3     
006640dd  int3     
006640de  int3     
006640df  int3     

### Void Enemy.Ene_Bos07/LegArcs::set_thigh(Single)  RVA=0x17CB470 len=0x90
017cb470  movss    dword ptr [rcx], xmm1
017cb474  ret      
017cb475  int3     
017cb476  int3     
017cb477  int3     
017cb478  int3     
017cb479  int3     
017cb47a  int3     
017cb47b  int3     
017cb47c  int3     
017cb47d  int3     
017cb47e  int3     
017cb47f  int3     
017cb480  mov      qword ptr [rsp + 8], rbx
017cb485  push     rdi
017cb486  sub      rsp, 0x30
017cb48a  mov      rax, qword ptr [r8 + 0x20]
017cb48e  mov      rdi, rcx
017cb491  movaps   xmmword ptr [rsp + 0x20], xmm6
017cb496  movaps   xmm6, xmm1
017cb499  test     byte ptr [rax + 0x135], 1
017cb4a0  jne      0x17cb4aa
017cb4a2  mov      rcx, rax
017cb4a5  call     0x4de1e0 ; ?
017cb4aa  mov      rax, qword ptr [rax + 0xc0]
017cb4b1  mov      edx, 4
017cb4b6  mov      rcx, qword ptr [rax]
017cb4b9  mov      rbx, qword ptr [rcx + 0x80]
017cb4c0  mov      rcx, rbx
017cb4c3  call     0x3f50 ; ?
017cb4c8  mov      rdx, rbx
017cb4cb  mov      rcx, rdi
017cb4ce  call     0x4e06a0 ; ?
017cb4d3  xor      r8d, r8d
017cb4d6  mov      rdx, rax
017cb4d9  movss    dword ptr [rax], xmm6
017cb4dd  mov      rcx, qword ptr [rbx + 8]
017cb4e1  mov      rbx, qword ptr [rsp + 0x40]
017cb4e6  movaps   xmm6, xmmword ptr [rsp + 0x20]
017cb4eb  add      rsp, 0x30
017cb4ef  pop      rdi
017cb4f0  jmp      0x4dfd90 ; ?
017cb4f5  int3     
017cb4f6  int3     
017cb4f7  int3     
017cb4f8  int3     
017cb4f9  int3     
017cb4fa  int3     
017cb4fb  int3     
017cb4fc  int3     
017cb4fd  int3     
017cb4fe  int3     
017cb4ff  int3     

### Single Enemy.Ene_Bos07/LegArcs::get_knee()  RVA=0x6640E0 len=0x190
006640e0  movss    xmm0, dword ptr [rcx + 4]
006640e5  ret      
006640e6  int3     
006640e7  int3     
006640e8  int3     
006640e9  int3     
006640ea  int3     
006640eb  int3     
006640ec  int3     
006640ed  int3     
006640ee  int3     
006640ef  int3     
006640f0  mov      qword ptr [rsp + 8], rbx
006640f5  push     rdi
006640f6  sub      rsp, 0x50
006640fa  cmp      byte ptr [rip + 0x3ffa74b], 0 ; [465e84c] bss
00664101  mov      rbx, rdx
00664104  movaps   xmmword ptr [rsp + 0x40], xmm6
00664109  mov      rdi, rcx
0066410c  movaps   xmmword ptr [rsp + 0x30], xmm7
00664111  movaps   xmmword ptr [rsp + 0x20], xmm8
00664117  jne      0x66412c
00664119  lea      rcx, [rip + 0x3d0eaa8] ; [4372bc8] TypeInfo#41713
00664120  call     0x4e0a50 ; il2cpp_init_metadata
00664125  mov      byte ptr [rip + 0x3ffa720], 1 ; [465e84c] bss
0066412c  mov      rcx, qword ptr [rip + 0x3d0ea95] ; [4372bc8] TypeInfo#41713
00664133  movss    xmm7, dword ptr [rdi]
00664137  movss    xmm6, dword ptr [rdi + 4]
0066413c  movss    xmm8, dword ptr [rdi + 8]
00664142  cmp      dword ptr [rcx + 0xe4], 0
00664149  subss    xmm7, dword ptr [rbx]
0066414d  subss    xmm6, dword ptr [rbx + 4]
00664152  subss    xmm8, dword ptr [rbx + 8]
00664158  jne      0x66415f
0066415a  call     0x4e0d90 ; il2cpp_class_init
0066415f  mulss    xmm6, xmm6
00664163  xorps    xmm0, xmm0
00664166  mulss    xmm7, xmm7
0066416a  mulss    xmm8, xmm8
0066416f  addss    xmm6, xmm7
00664173  addss    xmm6, xmm8
00664178  cvtps2pd xmm1, xmm6
0066417b  ucomisd  xmm0, xmm1
0066417f  ja       0x66418b
00664181  sqrtpd   xmm0, xmm1
00664185  cvtpd2ps xmm0, xmm0
00664189  jmp      0x664197
0066418b  movaps   xmm0, xmm1
0066418e  call     0x5787d0 ; ?
00664193  cvtsd2ss xmm0, xmm0
00664197  mov      rbx, qword ptr [rsp + 0x60]
0066419c  movaps   xmm6, xmmword ptr [rsp + 0x40]
006641a1  movaps   xmm7, xmmword ptr [rsp + 0x30]
006641a6  movaps   xmm8, xmmword ptr [rsp + 0x20]
006641ac  add      rsp, 0x50
006641b0  pop      rdi
006641b1  ret      
006641b2  int3     
006641b3  int3     
006641b4  int3     
006641b5  int3     
006641b6  int3     
006641b7  int3     
006641b8  int3     
006641b9  int3     
006641ba  int3     
006641bb  int3     
006641bc  int3     
006641bd  int3     
006641be  int3     
006641bf  int3     
006641c0  push     rbx
006641c2  sub      rsp, 0x30
006641c6  cmp      byte ptr [rip + 0x3ffa67e], 0 ; [465e84b] bss
006641cd  mov      rbx, rcx
006641d0  movaps   xmmword ptr [rsp + 0x20], xmm6
006641d5  jne      0x6641ea
006641d7  lea      rcx, [rip + 0x3d0e9ea] ; [4372bc8] TypeInfo#41713
006641de  call     0x4e0a50 ; il2cpp_init_metadata
006641e3  mov      byte ptr [rip + 0x3ffa661], 1 ; [465e84b] bss
006641ea  movss    xmm0, dword ptr [rbx + 4]
006641ef  movss    xmm6, dword ptr [rbx]
006641f3  movss    xmm1, dword ptr [rbx + 8]
006641f8  movss    xmm2, dword ptr [rbx + 0xc]
006641fd  mov      rcx, qword ptr [rip + 0x3d0e9c4] ; [4372bc8] TypeInfo#41713
00664204  mulss    xmm6, xmm6
00664208  mulss    xmm0, xmm0
0066420c  cmp      dword ptr [rcx + 0xe4], 0
00664213  mulss    xmm1, xmm1
00664217  addss    xmm6, xmm0
0066421b  mulss    xmm2, xmm2
0066421f  addss    xmm6, xmm1
00664223  addss    xmm6, xmm2
00664227  jne      0x66422e
00664229  call     0x4e0d90 ; il2cpp_class_init
0066422e  cvtps2pd xmm1, xmm6
00664231  xorps    xmm0, xmm0
00664234  ucomisd  xmm0, xmm1
00664238  ja       0x66424d
0066423a  sqrtpd   xmm0, xmm1
0066423e  cvtpd2ps xmm0, xmm0
00664242  movaps   xmm6, xmmword ptr [rsp + 0x20]
00664247  add      rsp, 0x30
0066424b  pop      rbx
0066424c  ret      
0066424d  movaps   xmm0, xmm1
00664250  call     0x5787d0 ; ?
00664255  movaps   xmm6, xmmword ptr [rsp + 0x20]
0066425a  cvtsd2ss xmm0, xmm0
0066425e  add      rsp, 0x30
00664262  pop      rbx
00664263  ret      
00664264  int3     
00664265  int3     
00664266  int3     
00664267  int3     
00664268  int3     
00664269  int3     
0066426a  int3     
0066426b  int3     
0066426c  int3     
0066426d  int3     
0066426e  int3     
0066426f  int3     

### Void Enemy.Ene_Bos07/LegArcs::set_knee(Single)  RVA=0x17CB500 len=0x10
017cb500  movss    dword ptr [rcx + 4], xmm1
017cb505  ret      
017cb506  int3     
017cb507  int3     
017cb508  int3     
017cb509  int3     
017cb50a  int3     
017cb50b  int3     
017cb50c  int3     
017cb50d  int3     
017cb50e  int3     
017cb50f  int3     

### Single Enemy.Ene_Bos07/LegArcs::get_toe()  RVA=0x5AA540 len=0xF0
005aa540  movss    xmm0, dword ptr [rcx + 8]
005aa545  ret      
005aa546  int3     
005aa547  int3     
005aa548  int3     
005aa549  int3     
005aa54a  int3     
005aa54b  int3     
005aa54c  int3     
005aa54d  int3     
005aa54e  int3     
005aa54f  int3     
005aa550  push     rbx
005aa552  sub      rsp, 0x30
005aa556  cmp      byte ptr [rip + 0x40b1f07], 0 ; [465c464] bss
005aa55d  mov      rbx, rcx
005aa560  movaps   xmmword ptr [rsp + 0x20], xmm6
005aa565  movaps   xmm6, xmm1
005aa568  jne      0x5aa57d
005aa56a  lea      rcx, [rip + 0x3de4fe7] ; [438f558] TypeInfo#44160
005aa571  call     0x4e0a50 ; il2cpp_init_metadata
005aa576  mov      byte ptr [rip + 0x40b1ee7], 1 ; [465c464] bss
005aa57d  mov      rcx, qword ptr [rip + 0x3de4fd4] ; [438f558] TypeInfo#44160
005aa584  cmp      dword ptr [rcx + 0xe4], 0
005aa58b  jne      0x5aa592
005aa58d  call     0x4e0d90 ; il2cpp_class_init
005aa592  movss    xmm0, dword ptr [rbx + 8]
005aa597  addss    xmm0, dword ptr [rbx]
005aa59b  movss    dword ptr [rbx], xmm6
005aa59f  subss    xmm0, xmm6
005aa5a3  movaps   xmm6, xmmword ptr [rsp + 0x20]
005aa5a8  movss    dword ptr [rbx + 8], xmm0
005aa5ad  add      rsp, 0x30
005aa5b1  pop      rbx
005aa5b2  ret      
005aa5b3  int3     
005aa5b4  int3     
005aa5b5  int3     
005aa5b6  int3     
005aa5b7  int3     
005aa5b8  int3     
005aa5b9  int3     
005aa5ba  int3     
005aa5bb  int3     
005aa5bc  int3     
005aa5bd  int3     
005aa5be  int3     
005aa5bf  int3     
005aa5c0  push     rbx
005aa5c2  sub      rsp, 0x30
005aa5c6  cmp      byte ptr [rip + 0x40b1e99], 0 ; [465c466] bss
005aa5cd  mov      rbx, rcx
005aa5d0  movaps   xmmword ptr [rsp + 0x20], xmm6
005aa5d5  movaps   xmm6, xmm1
005aa5d8  jne      0x5aa5ed
005aa5da  lea      rcx, [rip + 0x3de4f77] ; [438f558] TypeInfo#44160
005aa5e1  call     0x4e0a50 ; il2cpp_init_metadata
005aa5e6  mov      byte ptr [rip + 0x40b1e79], 1 ; [465c466] bss
005aa5ed  mov      rcx, qword ptr [rip + 0x3de4f64] ; [438f558] TypeInfo#44160
005aa5f4  cmp      dword ptr [rcx + 0xe4], 0
005aa5fb  jne      0x5aa602
005aa5fd  call     0x4e0d90 ; il2cpp_class_init
005aa602  movss    xmm0, dword ptr [rbx + 0xc]
005aa607  addss    xmm0, dword ptr [rbx + 4]
005aa60c  movss    dword ptr [rbx + 4], xmm6
005aa611  subss    xmm0, xmm6
005aa615  movaps   xmm6, xmmword ptr [rsp + 0x20]
005aa61a  movss    dword ptr [rbx + 0xc], xmm0
005aa61f  add      rsp, 0x30
005aa623  pop      rbx
005aa624  ret      
005aa625  int3     
005aa626  int3     
005aa627  int3     
005aa628  int3     
005aa629  int3     
005aa62a  int3     
005aa62b  int3     
005aa62c  int3     
005aa62d  int3     
005aa62e  int3     
005aa62f  int3     

### Void Enemy.Ene_Bos07/LegArcs::set_toe(Single)  RVA=0x1DB7910 len=0x10
01db7910  movss    dword ptr [rcx + 8], xmm1
01db7915  ret      
01db7916  int3     
01db7917  int3     
01db7918  int3     
01db7919  int3     
01db791a  int3     
01db791b  int3     
01db791c  int3     
01db791d  int3     
01db791e  int3     
01db791f  int3     

### Single Enemy.Ene_Bos07/LegArcs::Get(Int32)  RVA=0x1DB78E0 len=0x20
01db78e0  test     edx, edx
01db78e2  jne      0x1db78e9
01db78e4  movss    xmm0, dword ptr [rcx]
01db78e8  ret      
01db78e9  cmp      edx, 1
01db78ec  jne      0x1db78f4
01db78ee  movss    xmm0, dword ptr [rcx + 4]
01db78f3  ret      
01db78f4  movss    xmm0, dword ptr [rcx + 8]
01db78f9  ret      
01db78fa  int3     
01db78fb  int3     
01db78fc  int3     
01db78fd  int3     
01db78fe  int3     
01db78ff  int3     

