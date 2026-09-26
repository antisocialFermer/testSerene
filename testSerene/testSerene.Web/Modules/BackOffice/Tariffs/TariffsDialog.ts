import { EntityDialog } from "@serenity-is/corelib";
import {TariffsForm} from "../../ServerTypes/Modules/BackOffice.TariffsForm";
import {TariffsRow} from "../../ServerTypes/Modules/BackOffice.TariffsRow";
import {TariffsService} from "../../ServerTypes/Modules/BackOffice.TariffsService";
import { nsModulesBackOfficeTariffs } from "../../ServerTypes/Namespaces";

export class TariffsDialog extends EntityDialog<TariffsRow, any> {
    static override[Symbol.typeInfo] = this.registerClass(nsModulesBackOfficeTariffs);

    protected override getFormKey() { return TariffsForm.formKey; }
    protected override getIdProperty() { return TariffsRow.idProperty; }
    protected override getLocalTextPrefix() { return TariffsRow.localTextPrefix; }
    protected override getNameProperty() { return TariffsRow.nameProperty; }
    protected override getService() { return TariffsService.baseUrl; }
    protected form = new TariffsForm(this);
}