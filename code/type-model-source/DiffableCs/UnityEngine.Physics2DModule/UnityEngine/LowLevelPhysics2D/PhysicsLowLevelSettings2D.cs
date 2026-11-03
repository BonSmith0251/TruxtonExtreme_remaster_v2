namespace UnityEngine.LowLevelPhysics2D;

[RequiredByNativeCode]
[Token(Token = "0x2000019")]
public sealed class PhysicsLowLevelSettings2D : ScriptableObject
{
	[FieldOffset(Offset = "0x18")]
	[Header("Layers")]
	[SerializeField]
	[Token(Token = "0x400004B")]
	private LayerNames m_PhysicsLayerNames; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x400004C")]
	private bool m_UseFullLayers; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Header("Default Definitions")]
	[SerializeField]
	[Token(Token = "0x400004D")]
	private PhysicsWorldDefinition m_PhysicsWorldDefinition; //Field offset: 0x24
	[FieldOffset(Offset = "0x354")]
	[SerializeField]
	[Token(Token = "0x400004E")]
	private PhysicsBodyDefinition m_PhysicsBodyDefinition; //Field offset: 0x354
	[FieldOffset(Offset = "0x398")]
	[SerializeField]
	[Token(Token = "0x400004F")]
	private PhysicsShapeDefinition m_PhysicsShapeDefinition; //Field offset: 0x398
	[FieldOffset(Offset = "0x3E8")]
	[SerializeField]
	[Token(Token = "0x4000050")]
	private PhysicsChainDefinition m_PhysicsChainDefinition; //Field offset: 0x3E8
	[FieldOffset(Offset = "0x428")]
	[SerializeField]
	[Token(Token = "0x4000051")]
	private PhysicsDistanceJointDefinition m_PhysicsDistanceJointDefinition; //Field offset: 0x428
	[FieldOffset(Offset = "0x4A0")]
	[SerializeField]
	[Token(Token = "0x4000052")]
	private PhysicsFixedJointDefinition m_PhysicsFixedJointDefinition; //Field offset: 0x4A0
	[FieldOffset(Offset = "0x4F8")]
	[SerializeField]
	[Token(Token = "0x4000053")]
	private PhysicsHingeJointDefinition m_PhysicsHingeJointDefinition; //Field offset: 0x4F8
	[FieldOffset(Offset = "0x568")]
	[SerializeField]
	[Token(Token = "0x4000054")]
	private PhysicsRelativeJointDefinition m_PhysicsRelativeJointDefinition; //Field offset: 0x568
	[FieldOffset(Offset = "0x5DC")]
	[SerializeField]
	[Token(Token = "0x4000055")]
	private PhysicsSliderJointDefinition m_PhysicsSliderJointDefinition; //Field offset: 0x5DC
	[FieldOffset(Offset = "0x64C")]
	[SerializeField]
	[Token(Token = "0x4000056")]
	private PhysicsWheelJointDefinition m_PhysicsWheelJointDefinition; //Field offset: 0x64C
	[FieldOffset(Offset = "0x6B8")]
	[Header("Globals")]
	[Range(1, 64)]
	[SerializeField]
	[Token(Token = "0x4000057")]
	private int m_ConcurrentSimulations; //Field offset: 0x6B8
	[FieldOffset(Offset = "0x6BC")]
	[Min(1E-05)]
	[SerializeField]
	[Token(Token = "0x4000058")]
	private float m_LengthUnitsPerMeter; //Field offset: 0x6BC
	[FieldOffset(Offset = "0x6C0")]
	[SerializeField]
	[Token(Token = "0x4000059")]
	private bool m_DrawInBuild; //Field offset: 0x6C0
	[FieldOffset(Offset = "0x6C1")]
	[SerializeField]
	[Token(Token = "0x400005A")]
	private bool m_BypassLowLevel; //Field offset: 0x6C1

	[Token(Token = "0x17000033")]
	public bool bypassLowLevel
	{
		[Address(RVA = "0x312B610", Offset = "0x312AA10", Length = "0x8")]
		[Token(Token = "0x60000AF")]
		 get { } //Length: 8
		[Address(RVA = "0x312C2E0", Offset = "0x312B6E0", Length = "0x7")]
		[Token(Token = "0x60000B0")]
		 set { } //Length: 7
	}

	[Range(1, 64)]
	[Token(Token = "0x17000030")]
	public int concurrentSimulations
	{
		[Address(RVA = "0x312B620", Offset = "0x312AA20", Length = "0x7")]
		[Token(Token = "0x60000A9")]
		 get { } //Length: 7
		[Address(RVA = "0x312C2F0", Offset = "0x312B6F0", Length = "0x27")]
		[Token(Token = "0x60000AA")]
		 set { } //Length: 39
	}

	[Token(Token = "0x17000032")]
	public bool drawInBuild
	{
		[Address(RVA = "0x312B630", Offset = "0x312AA30", Length = "0x8")]
		[Token(Token = "0x60000AD")]
		 get { } //Length: 8
		[Address(RVA = "0x312C320", Offset = "0x312B720", Length = "0x7")]
		[Token(Token = "0x60000AE")]
		 set { } //Length: 7
	}

	[Token(Token = "0x17000031")]
	public float lengthUnitsPerMeter
	{
		[Address(RVA = "0x312B640", Offset = "0x312AA40", Length = "0x9")]
		[Token(Token = "0x60000AB")]
		 get { } //Length: 9
		[Address(RVA = "0x312C330", Offset = "0x312B730", Length = "0x17")]
		[Token(Token = "0x60000AC")]
		 set { } //Length: 23
	}

	[Token(Token = "0x1700002D")]
	public PhysicsBodyDefinition physicsBodyDefinition
	{
		[Address(RVA = "0x312C1B0", Offset = "0x312B5B0", Length = "0x2F")]
		[Token(Token = "0x60000A3")]
		 get { } //Length: 47
		[Address(RVA = "0x312C350", Offset = "0x312B750", Length = "0x2C")]
		[Token(Token = "0x60000A4")]
		 set { } //Length: 44
	}

	[Token(Token = "0x1700002F")]
	public PhysicsChainDefinition physicsChainDefinition
	{
		[Address(RVA = "0x312C1E0", Offset = "0x312B5E0", Length = "0x2F")]
		[Token(Token = "0x60000A7")]
		 get { } //Length: 47
		[Address(RVA = "0x312C380", Offset = "0x312B780", Length = "0x2C")]
		[Token(Token = "0x60000A8")]
		 set { } //Length: 44
	}

	[Token(Token = "0x1700002A")]
	public LayerNames physicsLayerNames
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x600009D")]
		 get { } //Length: 5
		[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
		[Token(Token = "0x600009E")]
		 set { } //Length: 13
	}

	[Token(Token = "0x1700002E")]
	public PhysicsShapeDefinition physicsShapeDefinition
	{
		[Address(RVA = "0x312C210", Offset = "0x312B610", Length = "0x3A")]
		[Token(Token = "0x60000A5")]
		 get { } //Length: 58
		[Address(RVA = "0x312C3B0", Offset = "0x312B7B0", Length = "0x37")]
		[Token(Token = "0x60000A6")]
		 set { } //Length: 55
	}

	[Token(Token = "0x1700002C")]
	public PhysicsWorldDefinition physicsWorldDefinition
	{
		[Address(RVA = "0x312C250", Offset = "0x312B650", Length = "0x88")]
		[Token(Token = "0x60000A1")]
		 get { } //Length: 136
		[Address(RVA = "0x312C3F0", Offset = "0x312B7F0", Length = "0x7A")]
		[Token(Token = "0x60000A2")]
		 set { } //Length: 122
	}

	[Token(Token = "0x1700002B")]
	public bool useFullLayers
	{
		[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
		[Token(Token = "0x600009F")]
		 get { } //Length: 5
		[Address(RVA = "0xA9A660", Offset = "0xA99A60", Length = "0x4")]
		[Token(Token = "0x60000A0")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x312C190", Offset = "0x312B590", Length = "0x1F")]
	[Token(Token = "0x600009B")]
	public PhysicsLowLevelSettings2D() { }

	[Address(RVA = "0x312B610", Offset = "0x312AA10", Length = "0x8")]
	[Token(Token = "0x60000AF")]
	public bool get_bypassLowLevel() { }

	[Address(RVA = "0x312B620", Offset = "0x312AA20", Length = "0x7")]
	[Token(Token = "0x60000A9")]
	public int get_concurrentSimulations() { }

	[Address(RVA = "0x312B630", Offset = "0x312AA30", Length = "0x8")]
	[Token(Token = "0x60000AD")]
	public bool get_drawInBuild() { }

	[Address(RVA = "0x312B640", Offset = "0x312AA40", Length = "0x9")]
	[Token(Token = "0x60000AB")]
	public float get_lengthUnitsPerMeter() { }

	[Address(RVA = "0x312C1B0", Offset = "0x312B5B0", Length = "0x2F")]
	[Token(Token = "0x60000A3")]
	public PhysicsBodyDefinition get_physicsBodyDefinition() { }

	[Address(RVA = "0x312C1E0", Offset = "0x312B5E0", Length = "0x2F")]
	[Token(Token = "0x60000A7")]
	public PhysicsChainDefinition get_physicsChainDefinition() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x600009D")]
	public LayerNames get_physicsLayerNames() { }

	[Address(RVA = "0x312C210", Offset = "0x312B610", Length = "0x3A")]
	[Token(Token = "0x60000A5")]
	public PhysicsShapeDefinition get_physicsShapeDefinition() { }

	[Address(RVA = "0x312C250", Offset = "0x312B650", Length = "0x88")]
	[Token(Token = "0x60000A1")]
	public PhysicsWorldDefinition get_physicsWorldDefinition() { }

	[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
	[Token(Token = "0x600009F")]
	public bool get_useFullLayers() { }

	[Address(RVA = "0x312B610", Offset = "0x312AA10", Length = "0x8")]
	[RequiredByNativeCode]
	[Token(Token = "0x60000BF")]
	private bool GetBypassLowLevel() { }

	[Address(RVA = "0x312B620", Offset = "0x312AA20", Length = "0x7")]
	[RequiredByNativeCode]
	[Token(Token = "0x60000BC")]
	private int GetConcurrentSimulations() { }

	[Address(RVA = "0x312B630", Offset = "0x312AA30", Length = "0x8")]
	[RequiredByNativeCode]
	[Token(Token = "0x60000BE")]
	private bool GetDrawInBuild() { }

	[Address(RVA = "0x312B640", Offset = "0x312AA40", Length = "0x9")]
	[RequiredByNativeCode]
	[Token(Token = "0x60000BD")]
	private float GetLengthUnitsPerMeter() { }

	[Address(RVA = "0x312B650", Offset = "0x312AA50", Length = "0x2C")]
	[RequiredByNativeCode]
	[Token(Token = "0x60000B3")]
	private void GetPhysicsBodyDefinition(out PhysicsBodyDefinition definition) { }

	[Address(RVA = "0x312B680", Offset = "0x312AA80", Length = "0x2C")]
	[RequiredByNativeCode]
	[Token(Token = "0x60000B5")]
	private void GetPhysicsChainDefinition(out PhysicsChainDefinition definition) { }

	[Address(RVA = "0x312B6B0", Offset = "0x312AAB0", Length = "0x74")]
	[RequiredByNativeCode]
	[Token(Token = "0x60000B6")]
	private void GetPhysicsDistanceJointDefinition(out PhysicsDistanceJointDefinition definition) { }

	[Address(RVA = "0x312B730", Offset = "0x312AB30", Length = "0x44")]
	[RequiredByNativeCode]
	[Token(Token = "0x60000B7")]
	private void GetPhysicsFixedJointDefinition(out PhysicsFixedJointDefinition definition) { }

	[Address(RVA = "0x312B780", Offset = "0x312AB80", Length = "0x5D")]
	[RequiredByNativeCode]
	[Token(Token = "0x60000B8")]
	private void GetPhysicsHingeJointDefinition(out PhysicsHingeJointDefinition definition) { }

	[Address(RVA = "0x312B7E0", Offset = "0x312ABE0", Length = "0x12")]
	[RequiredByNativeCode]
	[Token(Token = "0x60000B1")]
	private void GetPhysicsLayerNames(out LayerNames layerNames) { }

	[Address(RVA = "0x312B800", Offset = "0x312AC00", Length = "0x66")]
	[RequiredByNativeCode]
	[Token(Token = "0x60000B9")]
	private void GetPhysicsRelativeJointDefinition(out PhysicsRelativeJointDefinition definition) { }

	[Address(RVA = "0x312B870", Offset = "0x312AC70", Length = "0x37")]
	[RequiredByNativeCode]
	[Token(Token = "0x60000B4")]
	private void GetPhysicsShapeDefinition(out PhysicsShapeDefinition definition) { }

	[Address(RVA = "0x312B8B0", Offset = "0x312ACB0", Length = "0x5D")]
	[RequiredByNativeCode]
	[Token(Token = "0x60000BA")]
	private void GetPhysicsSliderJointDefinition(out PhysicsSliderJointDefinition definition) { }

	[Address(RVA = "0x312B910", Offset = "0x312AD10", Length = "0x68")]
	[RequiredByNativeCode]
	[Token(Token = "0x60000BB")]
	private void GetPhysicsWheelJointDefinition(out PhysicsWheelJointDefinition definition) { }

	[Address(RVA = "0x312B980", Offset = "0x312AD80", Length = "0x101")]
	[RequiredByNativeCode]
	[Token(Token = "0x60000B2")]
	private void GetPhysicsWorldDefinition(out PhysicsWorldDefinition definition) { }

	[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
	[RequiredByNativeCode]
	[Token(Token = "0x60000C0")]
	private bool GetUseFullLayers() { }

	[Address(RVA = "0x312BA90", Offset = "0x312AE90", Length = "0x6FD")]
	[Token(Token = "0x600009C")]
	private void Reset() { }

	[Address(RVA = "0x312C2E0", Offset = "0x312B6E0", Length = "0x7")]
	[Token(Token = "0x60000B0")]
	public void set_bypassLowLevel(bool value) { }

	[Address(RVA = "0x312C2F0", Offset = "0x312B6F0", Length = "0x27")]
	[Token(Token = "0x60000AA")]
	public void set_concurrentSimulations(int value) { }

	[Address(RVA = "0x312C320", Offset = "0x312B720", Length = "0x7")]
	[Token(Token = "0x60000AE")]
	public void set_drawInBuild(bool value) { }

	[Address(RVA = "0x312C330", Offset = "0x312B730", Length = "0x17")]
	[Token(Token = "0x60000AC")]
	public void set_lengthUnitsPerMeter(float value) { }

	[Address(RVA = "0x312C350", Offset = "0x312B750", Length = "0x2C")]
	[Token(Token = "0x60000A4")]
	public void set_physicsBodyDefinition(PhysicsBodyDefinition value) { }

	[Address(RVA = "0x312C380", Offset = "0x312B780", Length = "0x2C")]
	[Token(Token = "0x60000A8")]
	public void set_physicsChainDefinition(PhysicsChainDefinition value) { }

	[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
	[Token(Token = "0x600009E")]
	public void set_physicsLayerNames(LayerNames value) { }

	[Address(RVA = "0x312C3B0", Offset = "0x312B7B0", Length = "0x37")]
	[Token(Token = "0x60000A6")]
	public void set_physicsShapeDefinition(PhysicsShapeDefinition value) { }

	[Address(RVA = "0x312C3F0", Offset = "0x312B7F0", Length = "0x7A")]
	[Token(Token = "0x60000A2")]
	public void set_physicsWorldDefinition(PhysicsWorldDefinition value) { }

	[Address(RVA = "0xA9A660", Offset = "0xA99A60", Length = "0x4")]
	[Token(Token = "0x60000A0")]
	public void set_useFullLayers(bool value) { }

}

