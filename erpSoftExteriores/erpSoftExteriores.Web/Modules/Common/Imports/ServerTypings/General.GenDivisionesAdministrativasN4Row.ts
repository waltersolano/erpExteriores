namespace erpSoftExteriores.General {
    export interface GenDivisionesAdministrativasN4Row {
        Id?: number;
        Codigo?: string;
        Nombre?: string;
        DivisionSuperiorN3?: number;
        DivisionSuperiorN3Codigo?: string;
        DivisionSuperiorN3Nombre?: string;
        DivisionSuperiorN3DivisionSuperiorN2?: number;
    }

    export namespace GenDivisionesAdministrativasN4Row {
        export const idProperty = 'Id';
        export const nameProperty = 'Nombre';
        export const localTextPrefix = 'General.GenDivisionesAdministrativasN4';
        export const lookupKey = 'General.DivisionesAdministrativasN4';

        export function getLookup(): Q.Lookup<GenDivisionesAdministrativasN4Row> {
            return Q.getLookup<GenDivisionesAdministrativasN4Row>('General.DivisionesAdministrativasN4');
        }

        export namespace Fields {
            export declare const Id: string;
            export declare const Codigo: string;
            export declare const Nombre: string;
            export declare const DivisionSuperiorN3: string;
            export declare const DivisionSuperiorN3Codigo: string;
            export declare const DivisionSuperiorN3Nombre: string;
            export declare const DivisionSuperiorN3DivisionSuperiorN2: string;
        }

        ['Id', 'Codigo', 'Nombre', 'DivisionSuperiorN3', 'DivisionSuperiorN3Codigo', 'DivisionSuperiorN3Nombre', 'DivisionSuperiorN3DivisionSuperiorN2'].forEach(x => (<any>Fields)[x] = x);
    }
}

