namespace InGame.Kernel.Player;

[CreateAssetMenu(menuName = "KANAI/PlayerDefinedFighterOptions")]
[Token(Token = "0x2000118")]
public class PlayerDefinedFighterOptions : ScriptableObject
{
	[Token(Token = "0x2000119")]
	internal enum ScreenEdge : int
	{
		LeftBottom = 0,
		RightUp = 1,
	}

	[Token(Token = "0x4000802")]
	private const float OptionRotateSpeedFactor = 16; //Field offset: 0x0
	[FieldOffset(Offset = "0x18")]
	[Range(0, 64)]
	[SerializeField]
	[Token(Token = "0x40007F8")]
	[Tooltip("停止時の回転速度\r\n(フレーム毎の角度設定")]
	public float OptionStayRotateSpeed; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Range(0, 64)]
	[SerializeField]
	[Token(Token = "0x40007F9")]
	[Tooltip("横移動時の回転速度\r\n(フレーム毎の角度設定")]
	public float OptionMovingRotateSpeed; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x40007FA")]
	[Tooltip("内側オプション：画面端あそび位置")]
	public Vector3 InSideEdgePosition; //Field offset: 0x20
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	[Token(Token = "0x40007FB")]
	[Tooltip("外側オプション：画面端あそび位置")]
	public Vector3 OutSideEdgePosition; //Field offset: 0x2C
	[FieldOffset(Offset = "0x38")]
	[Range(1, 500)]
	[SerializeField]
	[Token(Token = "0x40007FC")]
	[Tooltip("内側オプション：画面端あそび移動時間(ms)")]
	public float InSideMoveTime; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Range(1, 500)]
	[SerializeField]
	[Token(Token = "0x40007FD")]
	[Tooltip("外側オプション：画面端あそび移動時間(ms)")]
	public float OutSideMoveTime; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	[Token(Token = "0x40007FE")]
	[Tooltip("内側オプション：左と下の画面判定オフセット")]
	public Vector3 InSideOptionClampScreenLeftBottomOffset; //Field offset: 0x40
	[FieldOffset(Offset = "0x4C")]
	[SerializeField]
	[Token(Token = "0x40007FF")]
	[Tooltip("内側オプション：右と上の画面判定オフセット")]
	public Vector3 InSideOptionClampScreenRightUpOffset; //Field offset: 0x4C
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	[Token(Token = "0x4000800")]
	[Tooltip("外側オプション：左と下の画面判定オフセット")]
	public Vector3 OutSideOptionClampScreenLeftBottomOffset; //Field offset: 0x58
	[FieldOffset(Offset = "0x64")]
	[SerializeField]
	[Token(Token = "0x4000801")]
	[Tooltip("外側オプション：右と上の画面判定オフセット")]
	public Vector3 OutSideOptionClampScreenRightUpOffset; //Field offset: 0x64

	[Address(RVA = "0x1D4E7A0", Offset = "0x1D4DBA0", Length = "0x155")]
	[Token(Token = "0x60008EA")]
	public PlayerDefinedFighterOptions() { }

	[Address(RVA = "0x1D4E6C0", Offset = "0x1D4DAC0", Length = "0x5D")]
	[Token(Token = "0x60008E7")]
	public Vector3 GetClampScreenOffset(int optionsIndex, ScreenEdge edge) { }

	[Address(RVA = "0x1D4E720", Offset = "0x1D4DB20", Length = "0x2B")]
	[Token(Token = "0x60008E9")]
	public Vector3 GetEdgeMoveFactor(int optionIndex) { }

	[Address(RVA = "0x1D4E750", Offset = "0x1D4DB50", Length = "0x21")]
	[Token(Token = "0x60008E8")]
	public float GetMoveTime(int optionIndex) { }

	[Address(RVA = "0x1D4E780", Offset = "0x1D4DB80", Length = "0x14")]
	[Token(Token = "0x60008E6")]
	public float GetRoteteSpeed(bool isMoving) { }

}

