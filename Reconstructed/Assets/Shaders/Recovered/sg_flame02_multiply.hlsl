// Recovered from Shader Graphs/sg_flame02_multiply (evidence/shader-recovery). Identical graph and vertex program to
// sg_flame02_additive (vs bytecode is byte-identical); only the blend (DstColor Zero) and the multiply-mode output
// rgb = lerp(1, colour, alpha) differ, so it shares that body.
#define TXB_FLAME_MULTIPLY
#include "Assets/Shaders/Recovered/sg_flame02_additive.hlsl"
