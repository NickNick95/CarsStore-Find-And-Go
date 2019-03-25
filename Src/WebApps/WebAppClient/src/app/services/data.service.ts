import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { CatalogResponse } from './catalog/catalog.responce';
import { CatalogDeleteResponse } from './catalog/catalog.delete.responce';
import { CatalogRequest } from './catalog/catalog.request';
import { UpdateCatalogRequest } from './catalog/update.catalog.request';

@Injectable()
export class DataService {

    private _catalogUrl: string;
    constructor(private http: HttpClient) {
        this._catalogUrl = environment.catalogUrl;
    }

    /*
    * Catalog
    */

    public getCatalogs() : Promise<CatalogResponse[]> {
        const endpoint = `${this._catalogUrl}/catalog`;
        return this.http.get<CatalogResponse[]>(endpoint, {})
            .toPromise()
            .catch(err => this._handleError(err));
    }

    public getCatalog(id: string) {
        const endpoint = `${this._catalogUrl}/catalog/${id}`;
        return this.http.post<CatalogResponse>(endpoint, {})
            .toPromise()
            .catch(err => this._handleError(err));
    }

    public deleteCatalog(id: string) {
        const endpoint = `${this._catalogUrl}/catalog/${id}`;
        return this.http.delete<CatalogDeleteResponse>(endpoint, {})
            .toPromise()
            .catch(err => this._handleError(err));
    }

    public addCatalog(model: CatalogRequest): Promise<CatalogResponse> {
        const endpoint = `${this._catalogUrl}/catalog`;
        return this.http.post<CatalogResponse>(endpoint, model, {})
            .toPromise()
            .catch(err => this._handleError(err));
    }

    public updateCatalog(id: string, model: UpdateCatalogRequest): Promise<CatalogResponse> {
        const endpoint = `${this._catalogUrl}/license/${id}`;
        return this.http.put<CatalogResponse>(endpoint, model, {})
            .toPromise()
            .catch(err => this._handleError(err));
    }

    private _handleError(error) {
        console.error(error); // for demo purposes only
        if (error.status === 401) {
            // this._auth.initImplicitFlow('/some-state;p1=1;p2=2');
        }
        return Promise.reject(error.message || error);
    }

}

