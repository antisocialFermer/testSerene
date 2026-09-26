import { BooleanEditor, DateTimeEditor, DecimalEditor, initFormType, IntegerEditor, PrefixedContext, StringEditor } from "@serenity-is/corelib";

export interface TariffsForm {
    TariffsId: IntegerEditor;
    TariffsCode: StringEditor;
    TariffsName: StringEditor;
    MonthlyFee: DecimalEditor;
    CommissionPercent: DecimalEditor;
    IsActive: BooleanEditor;
    CreatedAt: DateTimeEditor;
}

export class TariffsForm extends PrefixedContext {
    static readonly formKey = 'BackOffice.Tariff';
    declare private static init: boolean;

    constructor(...args: ConstructorParameters<typeof PrefixedContext>) {
        super(...args);

        if (!TariffsForm.init) {
            TariffsForm.init = true;

            initFormType(TariffsForm, [
                'TariffsId', IntegerEditor,
                'TariffsCode', StringEditor,
                'TariffsName', StringEditor,
                'MonthlyFee', DecimalEditor,
                'CommissionPercent', DecimalEditor,
                'IsActive', BooleanEditor,
                'CreatedAt', DateTimeEditor
            ]);
        }
    }
}