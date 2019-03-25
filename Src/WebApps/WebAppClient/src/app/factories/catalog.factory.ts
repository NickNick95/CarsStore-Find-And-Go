import { CatalogResponse } from '../services/catalog/catalog.responce';
import { Catalog } from '../models/catalog';
import { CatalogRequest } from '../services/catalog/catalog.request';
import { UpdateCatalogRequest } from '../services/catalog/update.catalog.request';

export class CatalogFactory {

    public static create(model: CatalogResponse) : Catalog {
        return {
            id: model.id,
            description: model.description,
            title: model.title
        }
    }

    public static createAddRequest(model: Catalog): CatalogRequest {
        return {
            description: model.description,
            title: model.title
        }
    }

    public static createUpdateRequest(model: Catalog): UpdateCatalogRequest {
        return {
            id: model.id,
            description: model.description,
            title: model.title
        };
    }

    
}