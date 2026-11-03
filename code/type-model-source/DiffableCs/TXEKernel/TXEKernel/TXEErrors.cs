namespace TXEKernel;

[Token(Token = "0x20000DB")]
public enum TXEErrors : int
{
	Unknown = -1,
	NoError = 131072,
	StageBoot = 65536,
	StageBoot_PlayerModel = 67584,
	StageBoot_EnemyModel = 69632,
	StageBoot_BulletTemplate = 71680,
	StageBoot_Route = 73728,
	StageBoot_Ruins = 75776,
	StageBoot_TimelineCheck = 75777,
	StageBoot_TimelineCheckEnemy = 75778,
	SaveError_NoError = 131072,
	SaveError_NoSpace = 131073,
	SaveError_BadMounted = 131073,
	SaveError_Broken = 131074,
	SaveError_Busy = 131075,
	SaveError_EXISTS = 131076,
	SaveError_NotFound = 131077,
	SaveError_FingerprintMismatch = 131078,
	SaveError_Internal = 131079,
	SaveError_InvalidLoginUser = 131080,
	SaveError_SaveNotFound = 131081,
	SaveError_NotInitialized = 131082,
	SaveError_NotMounted = 131083,
	SaveError_NoPermission = 131084,
	SaveError_OutOfMemory = 131085,
	SaveError_Other = 131328,
	SaveError_DecodeError = 131329,
	Syntax = 2130706432,
	Network = 2130706433,
	DateRange = 2130706448,
}

