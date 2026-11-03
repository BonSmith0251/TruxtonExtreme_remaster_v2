namespace InGame.Kernel.Player;

[Token(Token = "0x200011C")]
public class PlayerEffects : MonoBehaviour
{
	[Token(Token = "0x200011D")]
	internal enum EffectKind : int
	{
		SpeedUp = 0,
		SpeedDown = 1,
		PowerUp = 2,
		Shield = 3,
		Charge = 4,
		Damaged = 5,
		WeaponTop = 6,
		normalShot = 6,
		thunderLaser = 7,
		tatsujinBeam = 8,
		goldLaser = 9,
		hormingShot = 10,
		starmShot = 11,
		blackLaser = 12,
		Max = 13,
	}

	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x4000809")]
	private ParticleSystem[] _effectParticles; //Field offset: 0x20

	[Address(RVA = "0x5B7910", Offset = "0x5B6D10", Length = "0x7")]
	[Token(Token = "0x60008F5")]
	public PlayerEffects() { }

	[Address(RVA = "0x1D4EBB0", Offset = "0x1D4DFB0", Length = "0x75")]
	[Token(Token = "0x60008F0")]
	public void EntryInGame(InGameParticleSystemManager pm) { }

	[Address(RVA = "0x1D4EC30", Offset = "0x1D4E030", Length = "0xFA")]
	[Token(Token = "0x60008EF")]
	public void Initialize() { }

	[Address(RVA = "0x1D4ED30", Offset = "0x1D4E130", Length = "0x93")]
	[Token(Token = "0x60008F1")]
	public void RemoveInGame(InGameParticleSystemManager pm) { }

	[Address(RVA = "0x1D4EDD0", Offset = "0x1D4E1D0", Length = "0x8A")]
	[Token(Token = "0x60008F2")]
	public void StartEffect(EffectKind ekind) { }

	[Address(RVA = "0x1D4EE60", Offset = "0x1D4E260", Length = "0x90")]
	[Token(Token = "0x60008F3")]
	public void StopEffect(EffectKind ekind) { }

	[Address(RVA = "0x1D4EF00", Offset = "0x1D4E300", Length = "0x6E")]
	[Token(Token = "0x60008F4")]
	public void StopEffects() { }

}

