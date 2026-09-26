import { EntityDialog } from "@serenity-is/corelib";
import {TradeOperationsForm} from "../../ServerTypes/Modules/BackOffice.TradeOperationsForm";
import {TradeOperationsRow} from "../../ServerTypes/Modules/BackOffice.TradeOperationsRow";
import {TradeOperationsService} from "../../ServerTypes/Modules/BackOffice.TradeOperationsService";
import { nsModulesBackOfficeTradeOperations } from "../../ServerTypes/Namespaces";
import {TariffsRow} from "../../ServerTypes/Modules/BackOffice.TariffsRow";
export class TradeOperationsDialog extends EntityDialog<TradeOperationsForm, any> {
    static override[Symbol.typeInfo] = this.registerClass(nsModulesBackOfficeTradeOperations);

    protected override getFormKey() { return TradeOperationsForm.formKey; }
    protected override getIdProperty() { return TradeOperationsRow.idProperty; }
    protected override getLocalTextPrefix() { return TradeOperationsRow.localTextPrefix; }
    protected override getNameProperty() { return TradeOperationsRow.nameProperty; }
    protected override getService() { return TradeOperationsService.baseUrl; }
    protected form = new TradeOperationsForm(this);


    protected calcUpdate(){
        let volume = this.form.TradeOperationsVolume.value;
        let price = this.form.TradeOperationsPrice.value;
        let tariffId =this.form.TradeOperationsTariffId.value;
        let tariff = TariffsRow.getLookup().itemById[tariffId];


        let total = volume * price;
        let comis = total * tariff.CommissionPercent / 100;
        let net = total - comis;
        this.form.TradeOperationsTotalAmount.value = total;
        this.form.TradeOperationsComissionAmount.value = comis;
        this.form.TradeOperationsNetAmount.value = net;
    }


    constructor(props?: any) {
    super(props);

    this.form.TradeOperationsVolume.change(() => {this.calcUpdate();});
    this.form.TradeOperationsPrice.change(() => {this.calcUpdate();});
    }
}