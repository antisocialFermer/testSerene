import { fieldsProxy, getLookup, getLookupAsync } from "@serenity-is/corelib";

export interface TariffsRow {
    TariffsId?: number;
    TariffsCode?: string;
    TariffsName?: string;
    MonthlyFee?: number;
    CommissionPercent?: number;
    IsActive?: boolean;
    CreatedAt?: string;
}

export abstract class TariffsRow {
    static readonly idProperty = 'TariffsId';
    static readonly nameProperty = 'TariffsName';
    static readonly localTextPrefix = 'BackOffice.Tariffs';
    static readonly lookupKey = 'BackOffice.Tariffs';

    /** @deprecated use getLookupAsync instead */
    static getLookup() { return getLookup<TariffsRow>('BackOffice.Tariffs') }
    static async getLookupAsync() { return getLookupAsync<TariffsRow>('BackOffice.Tariffs') }

    static readonly deletePermission = 'BackOffice:Security';
    static readonly insertPermission = 'BackOffice:Security';
    static readonly readPermission = 'BackOffice:Security';
    static readonly updatePermission = 'BackOffice:Security';

    static readonly Fields = fieldsProxy<TariffsRow>();
}