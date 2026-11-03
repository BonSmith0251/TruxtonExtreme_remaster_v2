namespace InGame.Kernel.Enemy;

[CreateAssetMenu(menuName = "KANAI/BulletPallet")]
[Token(Token = "0x200014E")]
public class BulletPalette : ScriptableObject
{
	[FieldOffset(Offset = "0x18")]
	[Header("常駐弾幕テンプレート")]
	[SerializeField]
	[Token(Token = "0x400095E")]
	private String[] names; //Field offset: 0x18

	[Address(RVA = "0x5B3AF0", Offset = "0x5B2EF0", Length = "0x7")]
	[Token(Token = "0x6000A5E")]
	public BulletPalette() { }

	[Address(RVA = "0x1D60840", Offset = "0x1D5FC40", Length = "0xE6")]
	[Token(Token = "0x6000A5D")]
	public Dictionary<String, Int32> GetBulletDict() { }

}

