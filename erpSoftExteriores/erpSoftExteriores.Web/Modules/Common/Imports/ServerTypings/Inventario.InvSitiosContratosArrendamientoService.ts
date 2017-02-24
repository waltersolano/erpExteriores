namespace erpSoftExteriores.Inventario {
    export namespace InvSitiosContratosArrendamientoService {
        export const baseUrl = 'Inventario/InvSitiosContratosArrendamiento';

        export declare function Create(request: Serenity.SaveRequest<InvSitiosContratosArrendamientoRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Update(request: Serenity.SaveRequest<InvSitiosContratosArrendamientoRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<InvSitiosContratosArrendamientoRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<InvSitiosContratosArrendamientoRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function UpdateArrendadorId(request: Serenity.SaveRequest<InvSitiosContratosArrendamientoRow>, onSuccess?: (response: Serenity.SaveRequest<InvSitiosContratosArrendamientoRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;

        export namespace Methods {
            export declare const Create: string;
            export declare const ValidateNoOverlappingDates: string;
            export declare const Update: string;
            export declare const Delete: string;
            export declare const Retrieve: string;
            export declare const List: string;
            export declare const UpdateArrendadorId: string;
        }

        ['Create', 'ValidateNoOverlappingDates', 'Update', 'Delete', 'Retrieve', 'List', 'UpdateArrendadorId'].forEach(x => {
            (<any>InvSitiosContratosArrendamientoService)[x] = function (r, s, o) { return Q.serviceRequest(baseUrl + '/' + x, r, s, o); };
            (<any>Methods)[x] = baseUrl + '/' + x;
        });
    }
}

