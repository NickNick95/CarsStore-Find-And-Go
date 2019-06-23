import { Injectable } from '@angular/core';
import { DataService } from '../data.service';
import { CatalogFactory } from 'src/app/factories/catalog.factory';
import { Catalog } from 'src/app/models/catalog';

@Injectable()
export class CatalogService {

    constructor(private dataService: DataService) {
    }

    public getCatalogs() : Promise<Catalog[]> {
        return new Promise((resolve, reject) => {
            this.dataService.getCatalogs().then(catalog => {
                return catalog ? resolve(catalog) : reject();
            });
        });
    }

    public getCatalog(id: string) : Promise<Catalog> {
        return new Promise((resolve, reject) => {
            this.dataService.getCatalog(id).then(catalogResponse => {
                if (!catalogResponse) { return reject(id); }
                const catalog = CatalogFactory.create(catalogResponse);
                return resolve(catalog);
            });
        });
    }

    public deleteCatalog(id: string): Promise<Catalog> {
        return new Promise((resolve, reject) => {
            this.dataService.deleteCatalog(id).then(response => {
                if (response) { resolve(CatalogFactory.create(response)); }
            }).catch(reject);
        });
    }

    public updateCatalog(catalog: Catalog): Promise<Catalog> {
        return new Promise((resolve, reject) => {
            this.dataService.updateCatalog(catalog.id, CatalogFactory.createUpdateRequest(catalog)).then(response => {
                if (response) { resolve(catalog); }
            }).catch(reject);
        });
    }


    public createCatalog(catalog: Catalog): Promise<Catalog> {
        return new Promise((resolve, reject) => {
            this.dataService.addCatalog(CatalogFactory.createAddRequest(catalog)).then(response => {
                if (response) { resolve(CatalogFactory.create(response)); }
            }).catch(reject);
        });
    }
}