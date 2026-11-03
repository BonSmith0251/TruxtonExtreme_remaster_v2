namespace Steamworks;

[Token(Token = "0x2000015")]
public static class SteamInventory
{

	[Address(RVA = "0x5F2170", Offset = "0x5F1570", Length = "0x5F")]
	[Token(Token = "0x600028F")]
	public static bool AddPromoItem(out SteamInventoryResult_t pResultHandle, SteamItemDef_t itemDef) { }

	[Address(RVA = "0x5F21D0", Offset = "0x5F15D0", Length = "0x77")]
	[Token(Token = "0x6000290")]
	public static bool AddPromoItems(out SteamInventoryResult_t pResultHandle, SteamItemDef_t[] pArrayItemDefs, uint unArrayLength) { }

	[Address(RVA = "0x5F2250", Offset = "0x5F1650", Length = "0x5E")]
	[Token(Token = "0x6000287")]
	public static bool CheckResultSteamID(SteamInventoryResult_t resultHandle, CSteamID steamIDExpected) { }

	[Address(RVA = "0x5F22B0", Offset = "0x5F16B0", Length = "0x77")]
	[Token(Token = "0x6000291")]
	public static bool ConsumeItem(out SteamInventoryResult_t pResultHandle, SteamItemInstanceID_t itemConsume, uint unQuantity) { }

	[Address(RVA = "0x5F2330", Offset = "0x5F1730", Length = "0x89")]
	[Token(Token = "0x600028C")]
	public static bool DeserializeResult(out SteamInventoryResult_t pOutResultHandle, Byte[] pBuffer, uint unBufferSize, bool bRESERVED_MUST_BE_FALSE = false) { }

	[Address(RVA = "0x5F23C0", Offset = "0x5F17C0", Length = "0x4F")]
	[Token(Token = "0x6000288")]
	public static void DestroyResult(SteamInventoryResult_t resultHandle) { }

	[Address(RVA = "0x5F2410", Offset = "0x5F1810", Length = "0xAD")]
	[Token(Token = "0x6000292")]
	public static bool ExchangeItems(out SteamInventoryResult_t pResultHandle, SteamItemDef_t[] pArrayGenerate, UInt32[] punArrayGenerateQuantity, uint unArrayGenerateLength, SteamItemInstanceID_t[] pArrayDestroy, UInt32[] punArrayDestroyQuantity, uint unArrayDestroyLength) { }

	[Address(RVA = "0x5F24C0", Offset = "0x5F18C0", Length = "0x88")]
	[Token(Token = "0x600028D")]
	public static bool GenerateItems(out SteamInventoryResult_t pResultHandle, SteamItemDef_t[] pArrayItemDefs, UInt32[] punArrayQuantity, uint unArrayLength) { }

	[Address(RVA = "0x5F2550", Offset = "0x5F1950", Length = "0x51")]
	[Token(Token = "0x6000289")]
	public static bool GetAllItems(out SteamInventoryResult_t pResultHandle) { }

	[Address(RVA = "0x5F25B0", Offset = "0x5F19B0", Length = "0xCF")]
	[Token(Token = "0x600029B")]
	public static bool GetEligiblePromoItemDefinitionIDs(CSteamID steamID, SteamItemDef_t[] pItemDefIDs, ref uint punItemDefIDsArraySize) { }

	[Address(RVA = "0x5F2680", Offset = "0x5F1A80", Length = "0xB8")]
	[Token(Token = "0x6000298")]
	public static bool GetItemDefinitionIDs(SteamItemDef_t[] pItemDefIDs, ref uint punItemDefIDsArraySize) { }

	[Address(RVA = "0x5F2740", Offset = "0x5F1B40", Length = "0x1CB")]
	[Token(Token = "0x6000299")]
	public static bool GetItemDefinitionProperty(SteamItemDef_t iDefinition, string pchPropertyName, out string pchValueBuffer, ref uint punValueBufferSizeOut) { }

	[Address(RVA = "0x5F2910", Offset = "0x5F1D10", Length = "0x75")]
	[Token(Token = "0x60002A0")]
	public static bool GetItemPrice(SteamItemDef_t iDefinition, out ulong pCurrentPrice, out ulong pBasePrice) { }

	[Address(RVA = "0x5F2990", Offset = "0x5F1D90", Length = "0x77")]
	[Token(Token = "0x600028A")]
	public static bool GetItemsByID(out SteamInventoryResult_t pResultHandle, SteamItemInstanceID_t[] pInstanceIDs, uint unCountInstanceIDs) { }

	[Address(RVA = "0x5F2A10", Offset = "0x5F1E10", Length = "0x198")]
	[Token(Token = "0x600029F")]
	public static bool GetItemsWithPrices(SteamItemDef_t[] pArrayItemDefs, UInt64[] pCurrentPrices, UInt64[] pBasePrices, uint unArrayLength) { }

	[Address(RVA = "0x5F2BB0", Offset = "0x5F1FB0", Length = "0x47")]
	[Token(Token = "0x600029E")]
	public static uint GetNumItemsWithPrices() { }

	[Address(RVA = "0x5F2C00", Offset = "0x5F2000", Length = "0x1CC")]
	[Token(Token = "0x6000285")]
	public static bool GetResultItemProperty(SteamInventoryResult_t resultHandle, uint unItemIndex, string pchPropertyName, out string pchValueBuffer, ref uint punValueBufferSizeOut) { }

	[Address(RVA = "0x5F2DD0", Offset = "0x5F21D0", Length = "0xCD")]
	[Token(Token = "0x6000284")]
	public static bool GetResultItems(SteamInventoryResult_t resultHandle, SteamItemDetails_t[] pOutItemsArray, ref uint punOutItemsArraySize) { }

	[Address(RVA = "0x5F2EA0", Offset = "0x5F22A0", Length = "0x4F")]
	[Token(Token = "0x6000283")]
	public static EResult GetResultStatus(SteamInventoryResult_t resultHandle) { }

	[Address(RVA = "0x5F2EF0", Offset = "0x5F22F0", Length = "0x4F")]
	[Token(Token = "0x6000286")]
	public static uint GetResultTimestamp(SteamInventoryResult_t resultHandle) { }

	[Address(RVA = "0x5F2F40", Offset = "0x5F2340", Length = "0x51")]
	[Token(Token = "0x600028E")]
	public static bool GrantPromoItems(out SteamInventoryResult_t pResultHandle) { }

	[Address(RVA = "0x5F2FA0", Offset = "0x5F23A0", Length = "0x128")]
	[Token(Token = "0x60002A8")]
	public static bool InspectItem(out SteamInventoryResult_t pResultHandle, string pchItemToken) { }

	[Address(RVA = "0x5F30D0", Offset = "0x5F24D0", Length = "0x47")]
	[Token(Token = "0x6000297")]
	public static bool LoadItemDefinitions() { }

	[Address(RVA = "0x5F3120", Offset = "0x5F2520", Length = "0x140")]
	[Token(Token = "0x60002A2")]
	public static bool RemoveProperty(SteamInventoryUpdateHandle_t handle, SteamItemInstanceID_t nItemID, string pchPropertyName) { }

	[Address(RVA = "0x5F3270", Offset = "0x5F2670", Length = "0x8F")]
	[Token(Token = "0x600029A")]
	public static SteamAPICall_t RequestEligiblePromoItemDefinitionsIDs(CSteamID steamID) { }

	[Address(RVA = "0x5F3300", Offset = "0x5F2700", Length = "0x88")]
	[Token(Token = "0x600029D")]
	public static SteamAPICall_t RequestPrices() { }

	[Address(RVA = "0x5F3390", Offset = "0x5F2790", Length = "0x47")]
	[Token(Token = "0x6000294")]
	public static void SendItemDropHeartbeat() { }

	[Address(RVA = "0x5F33E0", Offset = "0x5F27E0", Length = "0x75")]
	[Token(Token = "0x600028B")]
	public static bool SerializeResult(SteamInventoryResult_t resultHandle, Byte[] pOutBuffer, out uint punOutBufferSize) { }

	[Address(RVA = "0x5F3710", Offset = "0x5F2B10", Length = "0x1D1")]
	[Token(Token = "0x60002A3")]
	public static bool SetProperty(SteamInventoryUpdateHandle_t handle, SteamItemInstanceID_t nItemID, string pchPropertyName, string pchPropertyValue) { }

	[Address(RVA = "0x5F3460", Offset = "0x5F2860", Length = "0x14E")]
	[Token(Token = "0x60002A4")]
	public static bool SetProperty(SteamInventoryUpdateHandle_t handle, SteamItemInstanceID_t nItemID, string pchPropertyName, bool bValue) { }

	[Address(RVA = "0x5F38F0", Offset = "0x5F2CF0", Length = "0x14D")]
	[Token(Token = "0x60002A5")]
	public static bool SetProperty(SteamInventoryUpdateHandle_t handle, SteamItemInstanceID_t nItemID, string pchPropertyName, long nValue) { }

	[Address(RVA = "0x5F35B0", Offset = "0x5F29B0", Length = "0x15F")]
	[Token(Token = "0x60002A6")]
	public static bool SetProperty(SteamInventoryUpdateHandle_t handle, SteamItemInstanceID_t nItemID, string pchPropertyName, float flValue) { }

	[Address(RVA = "0x5F3A40", Offset = "0x5F2E40", Length = "0xB4")]
	[Token(Token = "0x600029C")]
	public static SteamAPICall_t StartPurchase(SteamItemDef_t[] pArrayItemDefs, UInt32[] punArrayQuantity, uint unArrayLength) { }

	[Address(RVA = "0x5F3B00", Offset = "0x5F2F00", Length = "0x88")]
	[Token(Token = "0x60002A1")]
	public static SteamInventoryUpdateHandle_t StartUpdateProperties() { }

	[Address(RVA = "0x5F3B90", Offset = "0x5F2F90", Length = "0x60")]
	[Token(Token = "0x60002A7")]
	public static bool SubmitUpdateProperties(SteamInventoryUpdateHandle_t handle, out SteamInventoryResult_t pResultHandle) { }

	[Address(RVA = "0x5F3BF0", Offset = "0x5F2FF0", Length = "0xB9")]
	[Token(Token = "0x6000296")]
	public static bool TradeItems(out SteamInventoryResult_t pResultHandle, CSteamID steamIDTradePartner, SteamItemInstanceID_t[] pArrayGive, UInt32[] pArrayGiveQuantity, uint nArrayGiveLength, SteamItemInstanceID_t[] pArrayGet, UInt32[] pArrayGetQuantity, uint nArrayGetLength) { }

	[Address(RVA = "0x5F3CB0", Offset = "0x5F30B0", Length = "0x89")]
	[Token(Token = "0x6000293")]
	public static bool TransferItemQuantity(out SteamInventoryResult_t pResultHandle, SteamItemInstanceID_t itemIdSource, uint unQuantity, SteamItemInstanceID_t itemIdDest) { }

	[Address(RVA = "0x5F3D40", Offset = "0x5F3140", Length = "0x5F")]
	[Token(Token = "0x6000295")]
	public static bool TriggerItemDrop(out SteamInventoryResult_t pResultHandle, SteamItemDef_t dropListDefinition) { }

}

