import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { TradeOperationsRow } from "./BackOffice.TradeOperationsRow";

export interface TradeOperationsColumns {
    TradeOperationsColumnsId: Column<TradeOperationsRow>;
    TradeOperationsClientCode: Column<TradeOperationsRow>;
    TradeOperationsClientName: Column<TradeOperationsRow>;
    TradeOperationsSymbol: Column<TradeOperationsRow>;
    TradeOperationsSide: Column<TradeOperationsRow>;
    TradeOperationsVolume: Column<TradeOperationsRow>;
    TradeOperationsPrice: Column<TradeOperationsRow>;
    TradeOperationsTradeDate: Column<TradeOperationsRow>;
    TradeOperationsTariffId: Column<TradeOperationsRow>;
    TradeOperationsStatus: Column<TradeOperationsRow>;
    TradeOperationsNotes: Column<TradeOperationsRow>;
    TradeOperationsCreatedAt: Column<TradeOperationsRow>;
    TradeOperationsTotalAmount: Column<TradeOperationsRow>;
    TradeOperationsCommissionAmount: Column<TradeOperationsRow>;
    TradeOperationsNetAmount: Column<TradeOperationsRow>;
}

export class TradeOperationsColumns extends ColumnsBase<TradeOperationsRow> {
    static readonly columnsKey = 'BackOffice.TradeOperation';
    static readonly Fields = fieldsProxy<TradeOperationsColumns>();
}