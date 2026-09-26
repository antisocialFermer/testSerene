import { EntityGrid } from "@serenity-is/corelib";
import {TariffsColumns} from "../../ServerTypes/Modules/BackOffice.Tariffs.TariffsColumns";
import {TariffsRow} from "../../ServerTypes/Modules/BackOffice.TariffsRow";
import {TariffsService} from "../../ServerTypes/Modules/BackOffice.TariffsService";



import { nsModulesBackOfficeTariffs } from "../../ServerTypes/Namespaces";
import { TariffsDialog } from "./TariffsDialog";

export class TariffsGrid extends EntityGrid<TariffsRow, any> {
    static override[Symbol.typeInfo] = this.registerClass(nsModulesBackOfficeTariffs);

    protected override useAsync() { return true; }
    protected override getColumnsKey() { return TariffsColumns.columnsKey; }
    protected override getDialogType() { return TariffsDialog; }
    protected override getIdProperty() { return TariffsRow.idProperty; }
    protected override getLocalTextPrefix() { return TariffsRow.localTextPrefix; }
    protected override getService() { return TariffsService.baseUrl; }

    protected override afterInit() {
        super.afterInit();
    }
    protected override getDefaultSortBy() {
        return [TariffsRow.Fields.TariffsName];
    }
}
