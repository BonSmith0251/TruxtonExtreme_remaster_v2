namespace UnityEngine.VFX.Utility;

[Token(Token = "0x2000045")]
internal abstract class VFXEventBinderBase : MonoBehaviour
{
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x4000166")]
	protected VisualEffect target; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000167")]
	public string EventName; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x4000168")]
	protected VFXEventAttribute eventAttribute; //Field offset: 0x30

	[Address(RVA = "0x2F73560", Offset = "0x2F72960", Length = "0x4F")]
	[Token(Token = "0x6000115")]
	protected VFXEventBinderBase() { }

	[Address(RVA = "0x2F73400", Offset = "0x2F72800", Length = "0x7")]
	[Token(Token = "0x6000110")]
	protected override void OnEnable() { }

	[Address(RVA = "0x2F73400", Offset = "0x2F72800", Length = "0x7")]
	[Token(Token = "0x6000111")]
	private void OnValidate() { }

	[Address(RVA = "0x2F73410", Offset = "0x2F72810", Length = "0xA2")]
	[Token(Token = "0x6000114")]
	protected void SendEventToVisualEffect(Object[] parameters) { }

	[Token(Token = "0x6000113")]
	protected abstract void SetEventAttribute(Object[] parameters = null) { }

	[Address(RVA = "0x2F734C0", Offset = "0x2F728C0", Length = "0x9F")]
	[Token(Token = "0x6000112")]
	private void UpdateCacheEventAttribute() { }

}

