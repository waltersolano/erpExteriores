﻿namespace erpSoftExteriores.Inventario {
    export namespace InvProductosService {
        export const baseUrl = 'Inventario/InvProductos';

        export declare function Create(request: Serenity.SaveRequest<InvProductosRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Update(request: Serenity.SaveRequest<InvProductosRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<InvProductosRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<InvProductosRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function ValidateIluminacion(request: Serenity.SaveRequest<InvProductosRow>, onSuccess?: (response: Serenity.SaveRequest<InvProductosRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;

        export namespace Methods {
            export declare const Create: string;
            export declare const Update: string;
            export declare const Delete: string;
            export declare const Retrieve: string;
            export declare const List: string;
            export declare const ValidateIluminacion: string;
        }

        ['Create', 'Update', 'Delete', 'Retrieve', 'List', 'ValidateIluminacion'].forEach(x => {
            (<any>InvProductosService)[x] = function (r, s, o) { return Q.serviceRequest(baseUrl + '/' + x, r, s, o); };
            (<any>Methods)[x] = baseUrl + '/' + x;
        });
    }
}

