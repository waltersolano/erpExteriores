namespace erpSoftExteriores.General {
    export interface GenDivisionesAdministrativasN2Row {
        Id?: number;
        Codigo?: string;
        Nombre?: string;
        DivisionSuperiorN1?: number;
        DivisionSuperiorN1Codigo?: string;
        DivisionSuperiorN1Nombre?: string;
        DivisionSuperiorN1DivisionSuperior?: number;
    }

    export namespace GenDivisionesAdministrativasN2Row {
        export const idProperty = 'Id';
        export const nameProperty = 'Nombre';
        export const localTextPrefix = 'General.GenDivisionesAdministrativasN2';
        export const lookupKey = 'General.DivisionesAdministrativasN2';

        export function getLookup(): Q.Lookup<GenDivisionesAdministrativasN2Row> {
            return Q.getLookup<GenDivisionesAdministrativasN2Row>('General.DivisionesAdministrativasN2');
        }

        export namespace Fields {
            export declare const Id: string;
            export declare const Codigo: string;
            export declare const Nombre: string;
            export declare const DivisionSuperiorN1: string;
            export declare const DivisionSuperiorN1Codigo: string;
            export declare const DivisionSuperiorN1Nombre: string;
            export declare const DivisionSuperiorN1DivisionSuperior: string;
        }

        ['Id', 'Codigo', 'Nombre', 'DivisionSuperiorN1', 'DivisionSuperiorN1Codigo', 'DivisionSuperiorN1Nombre', 'DivisionSuperiorN1DivisionSuperior'].forEach(x => (<any>Fields)[x] = x);
    }
}

