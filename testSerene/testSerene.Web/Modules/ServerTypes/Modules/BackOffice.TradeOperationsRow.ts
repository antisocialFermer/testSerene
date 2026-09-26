import { fieldsProxy, getLookup, getLookupAsync } from "@serenity-is/corelib";

export interface TradeOperationsRow {
    TradeOperationsId?: number;
    TradeOperationsClientCode?: string;
    TradeOperationsClientName?: string;
    TradeOperationsSymbol?: string;
    TradeOperationsSide?: string;
    TradeOperationsVolume?: number;
    TradeOperationsPrice?: number;
    TradeOperationsTradeDate?: string;
    TradeOperationsTariffId?: number;
    TradeOperationsStatus?: string;
    TradeOperationsNotes?: string;
    TradeOperationsCreatedAt?: string;
    TradeOperationsTotalAmount?: number;
    TradeOperationsCommissionAmount?: number;
    TradeOperationsNetAmount?: number;
}

export abstract class TradeOperationsRow {
    static readonly idProperty = 'TradeOperationsId';
    static readonly nameProperty = 'TradeOperationsClientName';
    static readonly localTextPrefix = 'BackOffice.TradeOperations';
    static readonly lookupKey = 'BackOffice.TradeOperations';

    /** @deprecated use getLookupAsync instead */
    static getLookup() { return getLookup<TradeOperationsRow>('BackOffice.TradeOperations') }
    static async getLookupAsync() { return getLookupAsync<TradeOperationsRow>('BackOffice.TradeOperations') }

    static readonly deletePermission = 'BackOffice:Security';
    static readonly insertPermission = 'BackOffice:Security';
    static readonly readPermission = 'BackOffice:Security';
    static readonly updatePermission = 'BackOffice:Security';

    static readonly Fields = fieldsProxy<TradeOperationsRow>();
}