import { Component, OnInit } from '@angular/core';
import Site from './models/site.model';
import { SiteService } from './services/site.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit{
  sites: Site[] = [];
  constructor(private siteService:SiteService) { }

  ngOnInit(): void {
    this.GetSites();
  }

  GetSites() {
    this.siteService.GetSites()
    .subscribe((sites) => {
         JSON.stringify(this.sites = sites);
      });
  }
}
