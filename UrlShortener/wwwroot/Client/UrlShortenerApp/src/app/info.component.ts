import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { CommonModule } from '@angular/common';
import { UrlService } from './Url.service';
import { UrlInfoModel } from '../models/urlInfo.model';

@Component({
  selector: 'app-info',
  templateUrl: './info.component.html',
  standalone: true,
  imports: [CommonModule]
})
export class InfoComponent implements OnInit {
  

  Id: string | null = null;
  UrlInfo: UrlInfoModel | null = null;
  constructor(private route: ActivatedRoute, private UrlService: UrlService) {}

  ngOnInit() {
    this.route.paramMap.subscribe(params => {
      this.Id = params.get('id');
      
      if (this.Id) {

        const idNumber = Number(this.Id);
        if (!isNaN(idNumber)) {
          this.UrlService.getInfo(idNumber).subscribe({
            next: (response) => {
              this.UrlInfo = response;
            },
            error: (error) => {
            }
          });
        } else {
          console.error('Invalid ID format');
        }
      } else {
        console.error('ID is null');
      }
    });
  }
  
}
