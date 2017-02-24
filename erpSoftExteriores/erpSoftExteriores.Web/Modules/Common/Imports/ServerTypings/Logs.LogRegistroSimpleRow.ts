namespace erpSoftExteriores.Logs {
    export interface LogRegistroSimpleRow {
        Id?: number;
        EntityType?: string;
        EntityId?: number;
        UsuarioRegistraId?: number;
        FechaRegistro?: string;
        UsuarioModifica?: number;
        FechaModifica?: string;
        Texto1?: string;
        Texto2?: string;
        Ip1?: string;
        Ip2?: string;
        TenantId?: number;
        UsuarioRegistraUsername?: string;
        UsuarioRegistraDisplayName?: string;
        UsuarioRegistraEmail?: string;
        UsuarioRegistraSource?: string;
        UsuarioRegistraPasswordHash?: string;
        UsuarioRegistraPasswordSalt?: string;
        UsuarioRegistraInsertDate?: string;
        UsuarioRegistraInsertUserId?: number;
        UsuarioRegistraUpdateDate?: string;
        UsuarioRegistraUpdateUserId?: number;
        UsuarioRegistraIsActive?: number;
        UsuarioRegistraLastDirectoryUpdate?: string;
        UsuarioRegistraTenantId?: number;
        UsuarioModificaUsername?: string;
        UsuarioModificaDisplayName?: string;
        UsuarioModificaEmail?: string;
        UsuarioModificaSource?: string;
        UsuarioModificaPasswordHash?: string;
        UsuarioModificaPasswordSalt?: string;
        UsuarioModificaInsertDate?: string;
        UsuarioModificaInsertUserId?: number;
        UsuarioModificaUpdateDate?: string;
        UsuarioModificaUpdateUserId?: number;
        UsuarioModificaIsActive?: number;
        UsuarioModificaLastDirectoryUpdate?: string;
        UsuarioModificaTenantId?: number;
    }

    export namespace LogRegistroSimpleRow {
        export const idProperty = 'Id';
        export const nameProperty = 'EntityType';
        export const localTextPrefix = 'Logs.LogRegistroSimple';

        export namespace Fields {
            export declare const Id: string;
            export declare const EntityType: string;
            export declare const EntityId: string;
            export declare const UsuarioRegistraId: string;
            export declare const FechaRegistro: string;
            export declare const UsuarioModifica: string;
            export declare const FechaModifica: string;
            export declare const Texto1: string;
            export declare const Texto2: string;
            export declare const Ip1: string;
            export declare const Ip2: string;
            export declare const TenantId: string;
            export declare const UsuarioRegistraUsername: string;
            export declare const UsuarioRegistraDisplayName: string;
            export declare const UsuarioRegistraEmail: string;
            export declare const UsuarioRegistraSource: string;
            export declare const UsuarioRegistraPasswordHash: string;
            export declare const UsuarioRegistraPasswordSalt: string;
            export declare const UsuarioRegistraInsertDate: string;
            export declare const UsuarioRegistraInsertUserId: string;
            export declare const UsuarioRegistraUpdateDate: string;
            export declare const UsuarioRegistraUpdateUserId: string;
            export declare const UsuarioRegistraIsActive: string;
            export declare const UsuarioRegistraLastDirectoryUpdate: string;
            export declare const UsuarioRegistraTenantId: string;
            export declare const UsuarioModificaUsername: string;
            export declare const UsuarioModificaDisplayName: string;
            export declare const UsuarioModificaEmail: string;
            export declare const UsuarioModificaSource: string;
            export declare const UsuarioModificaPasswordHash: string;
            export declare const UsuarioModificaPasswordSalt: string;
            export declare const UsuarioModificaInsertDate: string;
            export declare const UsuarioModificaInsertUserId: string;
            export declare const UsuarioModificaUpdateDate: string;
            export declare const UsuarioModificaUpdateUserId: string;
            export declare const UsuarioModificaIsActive: string;
            export declare const UsuarioModificaLastDirectoryUpdate: string;
            export declare const UsuarioModificaTenantId: string;
        }

        ['Id', 'EntityType', 'EntityId', 'UsuarioRegistraId', 'FechaRegistro', 'UsuarioModifica', 'FechaModifica', 'Texto1', 'Texto2', 'Ip1', 'Ip2', 'TenantId', 'UsuarioRegistraUsername', 'UsuarioRegistraDisplayName', 'UsuarioRegistraEmail', 'UsuarioRegistraSource', 'UsuarioRegistraPasswordHash', 'UsuarioRegistraPasswordSalt', 'UsuarioRegistraInsertDate', 'UsuarioRegistraInsertUserId', 'UsuarioRegistraUpdateDate', 'UsuarioRegistraUpdateUserId', 'UsuarioRegistraIsActive', 'UsuarioRegistraLastDirectoryUpdate', 'UsuarioRegistraTenantId', 'UsuarioModificaUsername', 'UsuarioModificaDisplayName', 'UsuarioModificaEmail', 'UsuarioModificaSource', 'UsuarioModificaPasswordHash', 'UsuarioModificaPasswordSalt', 'UsuarioModificaInsertDate', 'UsuarioModificaInsertUserId', 'UsuarioModificaUpdateDate', 'UsuarioModificaUpdateUserId', 'UsuarioModificaIsActive', 'UsuarioModificaLastDirectoryUpdate', 'UsuarioModificaTenantId'].forEach(x => (<any>Fields)[x] = x);
    }
}

