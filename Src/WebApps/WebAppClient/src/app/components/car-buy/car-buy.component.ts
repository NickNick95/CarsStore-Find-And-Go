import { Component, OnInit } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';
import { CatalogService } from 'src/app/services/catalog/catalog.service';
import { Catalog } from 'src/app/models/catalog';

@Component({
  selector: 'app-car-buy',
  templateUrl: './car-buy.component.html',
  styleUrls: ['./car-buy.component.css']
})
export class CarBuyComponent implements OnInit {

  public idCar: string;
  public catalog: Catalog;

  constructor(protected router: ActivatedRoute,
    private catalogService: CatalogService) {
      this.catalog = new Catalog();
  }

  ngOnInit() {
    const catalogId = this.router.snapshot.paramMap.get('id');
    this.catalogService.getCatalog(catalogId).then(data => {
        this.catalog = data;
    });
  }

  sentMessage(){

    
  }
}
