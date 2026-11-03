namespace OutGame.UI;

[Token(Token = "0x2000105")]
public class AchievementListOne : MonoBehaviour
{
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x4000452")]
	private UIImage _icon; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x4000453")]
	public UITextMeshPro _achievementName; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x4000454")]
	public UITextMeshPro _achievementConditions; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Token(Token = "0x4000455")]
	public UITextMeshPro _unlockDate; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	[Token(Token = "0x4000456")]
	public UITextMeshPro _unlockTime; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	[Token(Token = "0x4000457")]
	public Sprite _disableIcon; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	[Token(Token = "0x4000458")]
	private AchievementData _achievementData; //Field offset: 0x50

	[Address(RVA = "0x5B7910", Offset = "0x5B6D10", Length = "0x7")]
	[Token(Token = "0x600069B")]
	public AchievementListOne() { }

	[Address(RVA = "0x21E6E90", Offset = "0x21E6290", Length = "0x22F")]
	[Token(Token = "0x600069A")]
	public bool set(ID achievementIndex) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000698")]
	private void Start() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000699")]
	private void Update() { }

}

