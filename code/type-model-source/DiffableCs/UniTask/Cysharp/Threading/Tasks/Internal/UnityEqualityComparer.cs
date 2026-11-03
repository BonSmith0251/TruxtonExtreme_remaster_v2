namespace Cysharp.Threading.Tasks.Internal;

[Token(Token = "0x200021E")]
internal static class UnityEqualityComparer
{
	[Token(Token = "0x2000225")]
	private sealed class BoundsEqualityComparer : IEqualityComparer<Bounds>
	{

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000C5B")]
		public BoundsEqualityComparer() { }

		[Address(RVA = "0x2786140", Offset = "0x2785540", Length = "0x84")]
		[Token(Token = "0x6000C59")]
		public override bool Equals(Bounds self, Bounds vector) { }

		[Address(RVA = "0x27861D0", Offset = "0x27855D0", Length = "0xC7")]
		[Token(Token = "0x6000C5A")]
		public override int GetHashCode(Bounds obj) { }

	}

	[Token(Token = "0x200022C")]
	private sealed class BoundsIntEqualityComparer : IEqualityComparer<BoundsInt>
	{

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000C71")]
		public BoundsIntEqualityComparer() { }

		[Address(RVA = "0x27862A0", Offset = "0x27856A0", Length = "0x177")]
		[Token(Token = "0x6000C6F")]
		public override bool Equals(BoundsInt self, BoundsInt vector) { }

		[Address(RVA = "0x2786420", Offset = "0x2785820", Length = "0x15B")]
		[Token(Token = "0x6000C70")]
		public override int GetHashCode(BoundsInt obj) { }

	}

	[Token(Token = "0x200021F")]
	private static class Cache
	{
		[Token(Token = "0x40005F2")]
		public static readonly IEqualityComparer<T> Comparer; //Field offset: 0x0

		[Address(RVA = "0x16BE100", Offset = "0x16BD500", Length = "0x2A9")]
		[Token(Token = "0x6000C49")]
		private static Cache`1() { }

	}

	[Token(Token = "0x2000227")]
	private sealed class Color32EqualityComparer : IEqualityComparer<Color32>
	{

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000C61")]
		public Color32EqualityComparer() { }

		[Address(RVA = "0x27865E0", Offset = "0x27859E0", Length = "0x72")]
		[Token(Token = "0x6000C5F")]
		public override bool Equals(Color32 self, Color32 vector) { }

		[Address(RVA = "0x2786660", Offset = "0x2785A60", Length = "0x6A")]
		[Token(Token = "0x6000C60")]
		public override int GetHashCode(Color32 obj) { }

	}

	[Token(Token = "0x2000223")]
	private sealed class ColorEqualityComparer : IEqualityComparer<Color>
	{

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000C55")]
		public ColorEqualityComparer() { }

		[Address(RVA = "0x27866D0", Offset = "0x2785AD0", Length = "0x76")]
		[Token(Token = "0x6000C53")]
		public override bool Equals(Color self, Color other) { }

		[Address(RVA = "0xDEDC40", Offset = "0xDED040", Length = "0x6E")]
		[Token(Token = "0x6000C54")]
		public override int GetHashCode(Color obj) { }

	}

	[Token(Token = "0x2000226")]
	private sealed class QuaternionEqualityComparer : IEqualityComparer<Quaternion>
	{

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000C5E")]
		public QuaternionEqualityComparer() { }

		[Address(RVA = "0x27866D0", Offset = "0x2785AD0", Length = "0x76")]
		[Token(Token = "0x6000C5C")]
		public override bool Equals(Quaternion self, Quaternion vector) { }

		[Address(RVA = "0xDEDC40", Offset = "0xDED040", Length = "0x6E")]
		[Token(Token = "0x6000C5D")]
		public override int GetHashCode(Quaternion obj) { }

	}

	[Token(Token = "0x200022A")]
	private sealed class RangeIntEqualityComparer : IEqualityComparer<RangeInt>
	{

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000C6B")]
		public RangeIntEqualityComparer() { }

		[Address(RVA = "0x2789E50", Offset = "0x2789250", Length = "0x3D")]
		[Token(Token = "0x6000C69")]
		public override bool Equals(RangeInt self, RangeInt vector) { }

		[Address(RVA = "0x2789E90", Offset = "0x2789290", Length = "0x2F")]
		[Token(Token = "0x6000C6A")]
		public override int GetHashCode(RangeInt obj) { }

	}

	[Token(Token = "0x2000224")]
	private sealed class RectEqualityComparer : IEqualityComparer<Rect>
	{

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000C58")]
		public RectEqualityComparer() { }

		[Address(RVA = "0x2789EC0", Offset = "0x27892C0", Length = "0x122")]
		[Token(Token = "0x6000C56")]
		public override bool Equals(Rect self, Rect other) { }

		[Address(RVA = "0x2789FF0", Offset = "0x27893F0", Length = "0xD8")]
		[Token(Token = "0x6000C57")]
		public override int GetHashCode(Rect obj) { }

	}

	[Token(Token = "0x200022B")]
	private sealed class RectIntEqualityComparer : IEqualityComparer<RectInt>
	{

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000C6E")]
		public RectIntEqualityComparer() { }

		[Address(RVA = "0x278A0D0", Offset = "0x27894D0", Length = "0x10A")]
		[Token(Token = "0x6000C6C")]
		public override bool Equals(RectInt self, RectInt other) { }

		[Address(RVA = "0x278A1E0", Offset = "0x27895E0", Length = "0xCD")]
		[Token(Token = "0x6000C6D")]
		public override int GetHashCode(RectInt obj) { }

	}

	[Token(Token = "0x2000220")]
	private sealed class Vector2EqualityComparer : IEqualityComparer<Vector2>
	{

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000C4C")]
		public Vector2EqualityComparer() { }

		[Address(RVA = "0x27941A0", Offset = "0x27935A0", Length = "0x42")]
		[Token(Token = "0x6000C4A")]
		public override bool Equals(Vector2 self, Vector2 vector) { }

		[Address(RVA = "0x27941F0", Offset = "0x27935F0", Length = "0x30")]
		[Token(Token = "0x6000C4B")]
		public override int GetHashCode(Vector2 obj) { }

	}

	[Token(Token = "0x2000228")]
	private sealed class Vector2IntEqualityComparer : IEqualityComparer<Vector2Int>
	{

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000C64")]
		public Vector2IntEqualityComparer() { }

		[Address(RVA = "0x2794220", Offset = "0x2793620", Length = "0x4B")]
		[Token(Token = "0x6000C62")]
		public override bool Equals(Vector2Int self, Vector2Int vector) { }

		[Address(RVA = "0x2794270", Offset = "0x2793670", Length = "0x3B")]
		[Token(Token = "0x6000C63")]
		public override int GetHashCode(Vector2Int obj) { }

	}

	[Token(Token = "0x2000221")]
	private sealed class Vector3EqualityComparer : IEqualityComparer<Vector3>
	{

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000C4F")]
		public Vector3EqualityComparer() { }

		[Address(RVA = "0x27942B0", Offset = "0x27936B0", Length = "0x61")]
		[Token(Token = "0x6000C4D")]
		public override bool Equals(Vector3 self, Vector3 vector) { }

		[Address(RVA = "0xE02B20", Offset = "0xE01F20", Length = "0x54")]
		[Token(Token = "0x6000C4E")]
		public override int GetHashCode(Vector3 obj) { }

	}

	[Token(Token = "0x2000229")]
	private sealed class Vector3IntEqualityComparer : IEqualityComparer<Vector3Int>
	{
		[Token(Token = "0x40005F3")]
		public static readonly Vector3IntEqualityComparer Default; //Field offset: 0x0

		[Address(RVA = "0x2794410", Offset = "0x2793810", Length = "0x67")]
		[Token(Token = "0x6000C68")]
		private static Vector3IntEqualityComparer() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000C67")]
		public Vector3IntEqualityComparer() { }

		[Address(RVA = "0x2794320", Offset = "0x2793720", Length = "0x73")]
		[Token(Token = "0x6000C65")]
		public override bool Equals(Vector3Int self, Vector3Int vector) { }

		[Address(RVA = "0x27943A0", Offset = "0x27937A0", Length = "0x6C")]
		[Token(Token = "0x6000C66")]
		public override int GetHashCode(Vector3Int obj) { }

	}

	[Token(Token = "0x2000222")]
	private sealed class Vector4EqualityComparer : IEqualityComparer<Vector4>
	{

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000C52")]
		public Vector4EqualityComparer() { }

		[Address(RVA = "0x27866D0", Offset = "0x2785AD0", Length = "0x76")]
		[Token(Token = "0x6000C50")]
		public override bool Equals(Vector4 self, Vector4 vector) { }

		[Address(RVA = "0xDEDC40", Offset = "0xDED040", Length = "0x6E")]
		[Token(Token = "0x6000C51")]
		public override int GetHashCode(Vector4 obj) { }

	}

	[Token(Token = "0x40005D8")]
	public static readonly IEqualityComparer<Vector2> Vector2; //Field offset: 0x0
	[Token(Token = "0x40005D9")]
	public static readonly IEqualityComparer<Vector3> Vector3; //Field offset: 0x8
	[Token(Token = "0x40005DA")]
	public static readonly IEqualityComparer<Vector4> Vector4; //Field offset: 0x10
	[Token(Token = "0x40005DB")]
	public static readonly IEqualityComparer<Color> Color; //Field offset: 0x18
	[Token(Token = "0x40005DC")]
	public static readonly IEqualityComparer<Color32> Color32; //Field offset: 0x20
	[Token(Token = "0x40005DD")]
	public static readonly IEqualityComparer<Rect> Rect; //Field offset: 0x28
	[Token(Token = "0x40005DE")]
	public static readonly IEqualityComparer<Bounds> Bounds; //Field offset: 0x30
	[Token(Token = "0x40005DF")]
	public static readonly IEqualityComparer<Quaternion> Quaternion; //Field offset: 0x38
	[Token(Token = "0x40005E0")]
	private static readonly RuntimeTypeHandle vector2Type; //Field offset: 0x40
	[Token(Token = "0x40005E1")]
	private static readonly RuntimeTypeHandle vector3Type; //Field offset: 0x48
	[Token(Token = "0x40005E2")]
	private static readonly RuntimeTypeHandle vector4Type; //Field offset: 0x50
	[Token(Token = "0x40005E3")]
	private static readonly RuntimeTypeHandle colorType; //Field offset: 0x58
	[Token(Token = "0x40005E4")]
	private static readonly RuntimeTypeHandle color32Type; //Field offset: 0x60
	[Token(Token = "0x40005E5")]
	private static readonly RuntimeTypeHandle rectType; //Field offset: 0x68
	[Token(Token = "0x40005E6")]
	private static readonly RuntimeTypeHandle boundsType; //Field offset: 0x70
	[Token(Token = "0x40005E7")]
	private static readonly RuntimeTypeHandle quaternionType; //Field offset: 0x78
	[Token(Token = "0x40005E8")]
	public static readonly IEqualityComparer<Vector2Int> Vector2Int; //Field offset: 0x80
	[Token(Token = "0x40005E9")]
	public static readonly IEqualityComparer<Vector3Int> Vector3Int; //Field offset: 0x88
	[Token(Token = "0x40005EA")]
	public static readonly IEqualityComparer<RangeInt> RangeInt; //Field offset: 0x90
	[Token(Token = "0x40005EB")]
	public static readonly IEqualityComparer<RectInt> RectInt; //Field offset: 0x98
	[Token(Token = "0x40005EC")]
	public static readonly IEqualityComparer<BoundsInt> BoundsInt; //Field offset: 0xA0
	[Token(Token = "0x40005ED")]
	private static readonly RuntimeTypeHandle vector2IntType; //Field offset: 0xA8
	[Token(Token = "0x40005EE")]
	private static readonly RuntimeTypeHandle vector3IntType; //Field offset: 0xB0
	[Token(Token = "0x40005EF")]
	private static readonly RuntimeTypeHandle rangeIntType; //Field offset: 0xB8
	[Token(Token = "0x40005F0")]
	private static readonly RuntimeTypeHandle rectIntType; //Field offset: 0xC0
	[Token(Token = "0x40005F1")]
	private static readonly RuntimeTypeHandle boundsIntType; //Field offset: 0xC8

	[Address(RVA = "0x27924B0", Offset = "0x27918B0", Length = "0x85F")]
	[Token(Token = "0x6000C48")]
	private static UnityEqualityComparer() { }

	[Address(RVA = "0x5D49B0", Offset = "0x5D3DB0", Length = "0x75")]
	[Token(Token = "0x6000C46")]
	public static IEqualityComparer<T> GetDefault() { }

	[Address(RVA = "0x2791E90", Offset = "0x2791290", Length = "0x617")]
	[Token(Token = "0x6000C47")]
	private static object GetDefaultHelper(Type type) { }

}

