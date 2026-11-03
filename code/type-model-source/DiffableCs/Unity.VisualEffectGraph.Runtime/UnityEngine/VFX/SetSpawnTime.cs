namespace UnityEngine.VFX;

[Token(Token = "0x200000C")]
internal class SetSpawnTime : VFXSpawnerCallbacks
{
	[Token(Token = "0x4000023")]
	private static readonly int spawnTimeID; //Field offset: 0x0

	[Address(RVA = "0x2F70170", Offset = "0x2F6F570", Length = "0x4F")]
	[Token(Token = "0x6000017")]
	private static SetSpawnTime() { }

	[Address(RVA = "0x1D308B0", Offset = "0x1D2FCB0", Length = "0x7")]
	[Token(Token = "0x6000016")]
	public SetSpawnTime() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000013")]
	public virtual void OnPlay(VFXSpawnerState state, VFXExpressionValues vfxValues, VisualEffect vfxComponent) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000015")]
	public virtual void OnStop(VFXSpawnerState state, VFXExpressionValues vfxValues, VisualEffect vfxComponent) { }

	[Address(RVA = "0x2F700D0", Offset = "0x2F6F4D0", Length = "0x99")]
	[Token(Token = "0x6000014")]
	public virtual void OnUpdate(VFXSpawnerState state, VFXExpressionValues vfxValues, VisualEffect vfxComponent) { }

}

