import { DeleteRequest, DeleteResponse, ListRequest, ListResponse, RetrieveRequest, RetrieveResponse, SaveRequest, SaveResponse, ServiceOptions, serviceRequest } from "@serenity-is/corelib";
import { TariffsRow } from "./BackOffice.TariffsRow";

export namespace TariffsService {
    export const baseUrl = 'BackOffice/Tariffs';

    export declare function Create(request: SaveRequest<TariffsRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<TariffsRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<TariffsRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<TariffsRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<TariffsRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<TariffsRow>>;

    export const Methods = {
        Create: "BackOffice/Tariffs/Create",
        Update: "BackOffice/Tariffs/Update",
        Delete: "BackOffice/Tariffs/Delete",
        Retrieve: "BackOffice/Tariffs/Retrieve",
        List: "BackOffice/Tariffs/List"
    } as const;

    [
        'Create',
        'Update',
        'Delete',
        'Retrieve',
        'List'
    ].forEach(x => {
        (<any>TariffsService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}