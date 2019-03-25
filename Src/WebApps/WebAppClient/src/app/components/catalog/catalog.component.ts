import { Component, OnInit} from '@angular/core';
import { Catalog } from 'src/app/models/catalog';

@Component({
  selector: 'app-catalog',
  templateUrl: './catalog.component.html',
  styleUrls: ['./catalog.component.css']
})
export class CatalogComponent implements OnInit {
  
   public catalogs : Catalog[]; 

  constructor() {

    this.catalogs = [new Catalog()];
   }

  ngOnInit() {

    var cat = new Catalog();
    cat.title = "Lada";
    cat.description = "Lada sedan";

    var cat2 = new Catalog();
    cat.title = "Lada 2101";
    cat.description = "Lada sedan";

    this.catalogs.push(cat);
    this.catalogs.push(cat2);
  }
}
