namespace erpSoftExteriores.General {
    export interface GenDivisionesAdministrativasN1Row {
        Id?: number;
        Codigo?: string;
        Nombre?: string;
        DivisionSuperior?: number;
    }

    export namespace GenDivisionesAdministrativasN1Row {
        export const idProperty = 'Id';
        export const nameProperty = 'Nombre';
        export const localTextPrefix = 'General.GenDivisionesAdministrativasN1';
        export const lookupKey = 'General.DivisionesAdministrativasN1';

        export function getLookup(): Q.Lookup<GenDivisionesAdministrativasN1Row> {
            return Q.getLookup<GenDivisionesAdministrativasN1Row>('General.DivisionesAdministrativasN1');
        }

        export namespace Fields {
            export declare const Id: string;
            export declare const Codigo: string;
            export declare const Nombre: string;
            export declare const DivisionSuperior: string;
        }

        ['Id', 'Codigo', 'Nombre', 'DivisionSuperior'].forEach(x => (<any>Fields)[x] = x);
    }
}

