import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { TariffsRow } from "./BackOffice.TariffsRow";

export interface TariffsColumns {
    TariffsId: Column<TariffsRow>;
    TariffsCode: Column<TariffsRow>;
    TariffsName: Column<TariffsRow>;
    MonthlyFee: Column<TariffsRow>;
    CommissionPercent: Column<TariffsRow>;
    IsActive: Column<TariffsRow>;
    CreatedAt: Column<TariffsRow>;
}

export class TariffsColumns extends ColumnsBase<TariffsRow> {
    static readonly columnsKey = 'BackOffice.Tariff';
    static readonly Fields = fieldsProxy<TariffsColumns>();
}