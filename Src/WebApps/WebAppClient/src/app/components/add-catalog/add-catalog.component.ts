import { Component, OnInit } from '@angular/core';
import { ViewChild, ElementRef } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Catalog } from '../../models/catalog';
import { CatalogService } from 'src/app/services/catalog/catalog.service';

@Component({
  selector: 'app-add-catalog',
  templateUrl: './add-catalog.component.html',
  styleUrls: ['./add-catalog.component.css']
})
export class AddCatalogComponent implements OnInit {

  public catalog : Catalog;

  constructor( 
    protected catalogService: CatalogService,
    protected route: ActivatedRoute,
    protected router: Router) { }

  @ViewChild('submitButton') submitButton: ElementRef;
  ngOnInit() {
    this.catalog = new Catalog();
  }

  public save() {
    this.submitButton.nativeElement.disabled = true;
    this.catalogService.createCatalog(this.catalog).then((customer) => {
      if (!customer) {
        console.log('Fix issue with adding customer');
      }
      this.router.navigate(['/']);
      this.submitButton.nativeElement.disabled = true;
    }).catch(err => {
      console.log(err);
      this.submitButton.nativeElement.disabled = false;
    });
  }
}
