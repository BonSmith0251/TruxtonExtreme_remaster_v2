namespace InGame.Kernel.Enemy;

[Token(Token = "0x20001DA")]
public class Ene_EneBox01 : PawnEnemyGround
{
	[Token(Token = "0x4001065")]
	private static readonly Int32[] DropItems; //Field offset: 0x0
	[Token(Token = "0x4001066")]
	private static readonly int DropItemsMax; //Field offset: 0x8
	[Token(Token = "0x4001067")]
	private static readonly Vector3 DropItemOffset; //Field offset: 0xC
	[FieldOffset(Offset = "0x200")]
	[SerializeField]
	[Token(Token = "0x4001068")]
	protected string _callEnemyStr; //Field offset: 0x200
	[FieldOffset(Offset = "0x208")]
	[SerializeField]
	[Token(Token = "0x4001069")]
	private bool _callEnemyIsGround; //Field offset: 0x208

	[Address(RVA = "0x1DBC390", Offset = "0x1DBB790", Length = "0xDE")]
	[Token(Token = "0x6000E5C")]
	private static Ene_EneBox01() { }

	[Address(RVA = "0x1DBC470", Offset = "0x1DBB870", Length = "0x6D")]
	[Token(Token = "0x6000E5B")]
	public Ene_EneBox01() { }

	[Address(RVA = "0x1DBBA10", Offset = "0x1DBAE10", Length = "0x49F")]
	[Token(Token = "0x6000E59")]
	private void DropSomething(Vector3 wpos) { }

	[Address(RVA = "0x1DBBEB0", Offset = "0x1DBB2B0", Length = "0x104")]
	[Token(Token = "0x6000E5A")]
	private int GetDropSomething() { }

	[Address(RVA = "0x1DBBFC0", Offset = "0x1DBB3C0", Length = "0x26E")]
	[Token(Token = "0x6000E57")]
	public virtual EnemyChildData[] SubEnemys() { }

	[Address(RVA = "0x1DBC230", Offset = "0x1DBB630", Length = "0x155")]
	[Token(Token = "0x6000E58")]
	public virtual void ToDestroid() { }

}

