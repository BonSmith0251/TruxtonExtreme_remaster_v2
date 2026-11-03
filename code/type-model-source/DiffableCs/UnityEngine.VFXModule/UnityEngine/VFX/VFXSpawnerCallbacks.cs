namespace UnityEngine.VFX;

[RequiredByNativeCode]
[Token(Token = "0x200000C")]
public abstract class VFXSpawnerCallbacks : ScriptableObject
{

	[Address(RVA = "0x5B3AF0", Offset = "0x5B2EF0", Length = "0x7")]
	[Token(Token = "0x600004D")]
	protected VFXSpawnerCallbacks() { }

	[Token(Token = "0x600004A")]
	public abstract void OnPlay(VFXSpawnerState state, VFXExpressionValues vfxValues, VisualEffect vfxComponent) { }

	[Token(Token = "0x600004C")]
	public abstract void OnStop(VFXSpawnerState state, VFXExpressionValues vfxValues, VisualEffect vfxComponent) { }

	[Token(Token = "0x600004B")]
	public abstract void OnUpdate(VFXSpawnerState state, VFXExpressionValues vfxValues, VisualEffect vfxComponent) { }

}

