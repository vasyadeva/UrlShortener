import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { FormsModule } from '@angular/forms';
import { UrlService } from './Url.service';
import { UrlModel } from '../models/url.model';
import { CommonModule } from '@angular/common';
import { RouterLink, RouterLinkActive } from '@angular/router';
import { Router } from '@angular/router';
@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet,FormsModule,CommonModule, RouterLink, RouterLinkActive],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'UrlShortenerApp';
  url : string = '';
  errorMessage: string = '';
  urls: UrlModel[] = [];
  isLoading: boolean = true;
  constructor(private UrlService: UrlService,private router: Router) {}

  ngOnInit(): void {
    this.fetchUrls();
  }

  fetchUrls(): void {
    this.UrlService.getAllUrls().subscribe(
      data => {
        this.urls = data;
        this.isLoading = false;
      },
      error => {
        console.error('Error fetching URLs', error);
        this.isLoading = true;
      }
    );
  }
  add() {
    this.UrlService.addUrl(this.url).subscribe({
      next: (response) => {
        this.errorMessage = '';
        this.fetchUrls(); 
        this.url = ''; 
      },
      error: (error) => {
        this.errorMessage = error.error?.error || 'An unexpected error occurred.';
      }
    });
  }

  delete(id : number)
  {
    this.UrlService.deleteUrl(id).subscribe({
      next: (response) => {
        this.errorMessage = '';
        this.fetchUrls(); 
        this.url = ''; 

      },
      error: (error) => {
        this.errorMessage = error.error?.error || 'An unexpected error occurred.';

      }
    });
  }

  info(id : number)
  {
    this.router.navigate(['/info', id]);
  }
}

