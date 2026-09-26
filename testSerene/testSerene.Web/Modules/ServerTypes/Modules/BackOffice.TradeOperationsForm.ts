import { DateTimeEditor, DecimalEditor, initFormType, IntegerEditor, PrefixedContext, StringEditor } from "@serenity-is/corelib";

export interface TradeOperationsForm {
    TradeOperationsId: IntegerEditor;
    TradeOperationsClientCode: StringEditor;
    TradeOperationsClientName: StringEditor;
    TradeOperationsSymbol: StringEditor;
    TradeOperationsVolume: DecimalEditor;
    TradeOperationsPrice: DecimalEditor;
    TradeOperationsTradeDate: DateTimeEditor;
    TradeOperationsTariffId: IntegerEditor;
    TradeOperationsStatus: StringEditor;
    TradeOperationsNotes: StringEditor;
    TradeOperationsCreatedAt: DateTimeEditor;
    TradeOperationsTotalAmount: DecimalEditor;
    TradeOperationsComissionAmount: DecimalEditor;
    TradeOperationsNetAmount: DecimalEditor;
}

export class TradeOperationsForm extends PrefixedContext {
    static readonly formKey = 'BackOffice.TradeOperation';
    declare private static init: boolean;

    constructor(...args: ConstructorParameters<typeof PrefixedContext>) {
        super(...args);

        if (!TradeOperationsForm.init) {
            TradeOperationsForm.init = true;

            initFormType(TradeOperationsForm, [
                'TradeOperationsId', IntegerEditor,
                'TradeOperationsClientCode', StringEditor,
                'TradeOperationsClientName', StringEditor,
                'TradeOperationsSymbol', StringEditor,
                'TradeOperationsVolume', DecimalEditor,
                'TradeOperationsPrice', DecimalEditor,
                'TradeOperationsTradeDate', DateTimeEditor,
                'TradeOperationsTariffId', IntegerEditor,
                'TradeOperationsStatus', StringEditor,
                'TradeOperationsNotes', StringEditor,
                'TradeOperationsCreatedAt', DateTimeEditor,
                'TradeOperationsTotalAmount', DecimalEditor,
                'TradeOperationsComissionAmount', DecimalEditor,
                'TradeOperationsNetAmount', DecimalEditor
            ]);
        }
    }
}